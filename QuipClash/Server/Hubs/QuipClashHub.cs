using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.AspNetCore.SignalR;
using QuipClash.Shared;

namespace QuipClash.Server.Hubs
{
    public class QuipClashHub : Hub
    {
        public static readonly Dictionary<string, GameInfo> ActiveGames = new Dictionary<string, GameInfo>();

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            foreach (var kv in ActiveGames)
            {
                foreach (var player in kv.Value.players)
                {
                    if (player.Key == Context.ConnectionId)
                        await RemovePlayer(kv.Key);
                }
            }
        }

        public async Task CreateGame()
        {
            //generates a random game ID
            string gameID = GenerateGameID();

            //makes sure that the ID is unique. If it's not, then it's regenerated
            if (ActiveGames.ContainsKey(gameID))
                await CreateGame();
            else
            {
                ActiveGames.Add(gameID, new GameInfo());

                await Clients.Client(Context.ConnectionId).SendAsync("CompleteCreateGame", gameID);
            }
        }
        private string GenerateGameID()
        {
            var random = new Random();
            var alphabet = new char[]
                { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] characters = new char[4];

            for (int i = 0; i < 4; i++)
            {
                var isCharacterInt = random.NextDouble() >= 0.5; ;

                if (isCharacterInt)
                    characters[i] = random.Next(0, 9).ToString().ToCharArray()[0];
                else
                    characters[i] = alphabet[random.Next(0, 26)];
            }

            return new string(characters);
        }

        public async Task RegisterPlayer(string gameID, string username, int mascottNumber)
        {
            //If the game hasn't started
            if (ActiveGames[gameID].rounds.Count == 0)
            {
                var players = ActiveGames[gameID].players;

                players.Add(Context.ConnectionId, new PlayerInfo(gameID, players.Count == 0, username, mascottNumber));

                foreach (string _connectionID in players.Keys.ToArray())
                    await Groups.AddToGroupAsync(_connectionID, gameID);

                await Clients.Group(gameID).SendAsync("UpdateUI");
                await Clients.Client(Context.ConnectionId).SendAsync("UpdatePlayerState", PlayerInfo.PlayerState.Lobby);
            }
        }
        public async Task RemovePlayer(string gameID)
        {
            var activeGame = ActiveGames[gameID];
            var players = activeGame.players;
            
            players.Remove(Context.ConnectionId);

            if (players.Count == 0)
            {
                ActiveGames.Remove(gameID);
                return;
            }

            //Creates the game's player group
            foreach (string _connectionID in players.Keys.ToArray())
                await Groups.AddToGroupAsync(_connectionID, gameID);

            //If the game has started or if the party leader left
            if (activeGame.rounds.Count > 0 || !players.ContainsValue(players.Values.FirstOrDefault((p) => p.isPartyLeader == true)))
            {
                await Clients.Group(gameID).SendAsync("UpdatePlayerState", PlayerInfo.PlayerState.Menu);
                ActiveGames.Remove(gameID);
            }
            else
                await Clients.Group(gameID).SendAsync("UpdateUI");
        }

        public async Task StartGame(string gameID)
        {
            await StartNewRound(gameID);
        }

        public async Task SendResponse(string gameID, string response, int duelIndex)
        {
            var activeGame = ActiveGames[gameID];
            var roundInfo = activeGame.rounds[activeGame.roundIndex];
            var duelInfo = roundInfo.duels[duelIndex];

            //adds the user's response to the array and removes them from the duel's response queue
            duelInfo.responses.Add(new ResponseInfo(response, Context.ConnectionId, duelInfo.responses.Count));

            //checks if it was the final response in a duel and if it was the final duel in a round
            if (duelInfo.responses.Count > 1)
            {
                roundInfo.completedDuels++;
                
                if (roundInfo.isDuelingComplete)
                    await StartNextVote(gameID);
            }
        }

        public async Task SendVote(string gameID, int voteOption)
        {
            var activeGame = ActiveGames[gameID];
            var roundInfo = activeGame.rounds[activeGame.roundIndex];
            var duelInfo = roundInfo.duels[roundInfo.completedVotes];

            //gives a point to the author of the option that was voted for
            activeGame.players[duelInfo.responses[voteOption].authorID].points++;
            await Clients.Group(gameID).SendAsync("UpdateVote", voteOption);
            
            //removes the voter from the backlog
            duelInfo.voters.Remove(Context.ConnectionId);
            //checks if the voting for that duel is complete and if it was the final vote in a round
            if (duelInfo.isVotingComplete)
            {
                roundInfo.completedVotes++;

                if (roundInfo.isVotingComplete)
                {
                    activeGame.roundIndex++;
                    await StartNewRound(gameID);
                }
                else
                    await StartNextVote(gameID);
            }
        }

        private async Task StartNextVote(string gameID)
        {
            var activeGame = ActiveGames[gameID];
            var roundInfo = activeGame.rounds[activeGame.roundIndex];
            var duelInfo = roundInfo.duels[roundInfo.completedVotes];
            
            //gets all of the players except the ones that took part in the duel that's being voted
            var voters = activeGame.players.Keys.ToList().Except(duelInfo.players.ToList()).ToList();
            duelInfo.voters = voters;
            
            //lets the voters know about what they're voting for
            foreach (string _player in activeGame.players.Keys)
            {
                if(voters.Contains(_player))
                    await Clients.Client(_player).SendAsync("BeginVote", duelInfo.prompt, duelInfo.responses, true);
                else
                    await Clients.Client(_player).SendAsync("BeginVote", duelInfo.prompt, duelInfo.responses, false);

                await Clients.Client(_player).SendAsync("UpdatePlayerState", PlayerInfo.PlayerState.Voting);
            }
        }

        private async Task StartNewRound(string gameID)
        {
            var activeGame = ActiveGames[gameID];
            var activeRounds = ActiveGames[gameID].rounds;

            if (activeRounds.Count == GameInfo.NumberOfRounds)
                await EndGame(gameID);
            else
            {
                //creates a new round and adds it to the list
                activeRounds.Add(new RoundInfo(activeGame.players.Keys.ToList(), activeGame.roundIndex));

                //if there's a player sitting out they get told to wait. If not, then this is undone in the next section
                await Clients.Group(gameID).SendAsync("UpdatePlayerState", PlayerInfo.PlayerState.Waiting);

                //lets the duellers know about their duel
                for (int i = 0; i < activeRounds[activeGame.roundIndex].duels.Count; i++)
                {
                    var duelInfo = activeRounds[activeGame.roundIndex].duels[i];
                    await Clients.Client(duelInfo.players[0]).SendAsync("BeginRespond", duelInfo.prompt, i);
                    await Clients.Client(duelInfo.players[1]).SendAsync("BeginRespond", duelInfo.prompt, i);
                }
            }
        }

        private async Task EndGame(string gameID)
        {
            var players = ActiveGames[gameID].players;

            var leaderboard = players.Values.ToList();
            //order players by most points to least points
            leaderboard = leaderboard.OrderByDescending(p => p.points).ToList();

            //sends everyone the leaderboard and the message to display the end game screen
            await Clients.Group(gameID).SendAsync("GameEnded", leaderboard);
            await Clients.Group(gameID).SendAsync("UpdatePlayerState", PlayerInfo.PlayerState.EndGame);

            ActiveGames.Remove(gameID);
        }
    }
}