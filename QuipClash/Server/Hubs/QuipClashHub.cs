using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using QuipClash.Shared;

namespace QuipClash.Server.Hubs
{
    public class QuipClashHub : Hub
    {
        public static readonly Dictionary<string, PlayerInfo> Players = new Dictionary<string, PlayerInfo>();

        private static List<RoundInfo> Rounds = new List<RoundInfo>();
        private static int NumberOfRounds = 1;

        private static int roundIndex = 0;

        public async Task RegisterPlayer(string username)
        {
            Players.Add(Context.ConnectionId, new PlayerInfo(username, Players.Count == 0));
            await Clients.All.SendAsync("UpdateUI");
        }
        public async Task RemovePlayer()
        {
            Players.Remove(Context.ConnectionId);
            await Clients.All.SendAsync("UpdateUI");
        }

        public async Task StartGame()
        {
            await StartNewRound();
        }

        public async Task SendResponse(string response, int duelIndex)
        {
            var roundInfo = Rounds[roundIndex];
            var duelInfo = roundInfo.duels[duelIndex];

            //adds the user's response to the array
            duelInfo.responses.Add(new ResponseInfo(response, Context.ConnectionId, duelInfo.responses.Count));

            //checks if it was the final response in a duel and if it was the final duel in a round
            if (duelInfo.responses.Count > 1)
            {
                roundInfo.completedDuels++;
                
                if (roundInfo.isDuelingComplete)
                    await StartNextVote();
            }
        }

        public async Task SendVote(int voteOption)
        {
            var roundInfo = Rounds[roundIndex];
            var duelInfo = roundInfo.duels[roundInfo.completedVotes];

            //gives a point to the author of the option that was voted for
            Players[duelInfo.responses[voteOption].authorID].points++;
            
            //removes the voter from the backlog
            duelInfo.voters.Remove(Context.ConnectionId);
            //checks if the voting for that duel is complete and if it was the final vote in a round
            if (duelInfo.isVotingComplete)
            {
                roundInfo.completedVotes++;

                if (roundInfo.isVotingComplete)
                {
                    roundIndex++;
                    await StartNewRound();
                }
                else
                    await StartNextVote();
            }
        }

        async Task StartNextVote()
        {
            var roundInfo = Rounds[roundIndex];
            var duelInfo = roundInfo.duels[roundInfo.completedVotes];
            
            //gets all of the players except the ones that took part in the duel that's being voted
            var voters = Players.Keys.ToList().Except(duelInfo.players.ToList()).ToList();
            duelInfo.voters = voters;
            
            //lets the voters know about what they're voting for
            foreach (string _voter in voters)
            {
                await Clients.Client(_voter).SendAsync("ReceiveResponses", duelInfo.prompt, duelInfo.responses);
                await Clients.Client(_voter).SendAsync("UpdatePlayerState", PlayerInfo.PlayerState.Voting);
            }
        }

        async Task StartNewRound()
        {
            if (Rounds.Count == NumberOfRounds)
                await EndGame();
            else
            {
                //creates a new round and adds it to the list
                Rounds.Add(new RoundInfo(Players.Keys.ToList(), roundIndex));

                //if there's a player sitting out they get told to wait. If not, then this is undone in the next section
                await Clients.All.SendAsync("UpdatePlayerState", PlayerInfo.PlayerState.Waiting);

                //lets the duellers know about their duel
                for (int i = 0; i < Rounds[roundIndex].duels.Count; i++)
                {
                    var duelInfo = Rounds[roundIndex].duels[i];
                    await Clients.Client(duelInfo.players[0]).SendAsync("BeginRespond", duelInfo.prompt, i);
                    await Clients.Client(duelInfo.players[1]).SendAsync("BeginRespond", duelInfo.prompt, i);
                }
            }
        }

        async Task EndGame()
        {
            var leaderboard = Players.Values.ToList();
            //order players by most points to least points
            leaderboard = leaderboard.OrderByDescending(p => p.points).ToList();

            //sends everyone the leaderboard and the message to display the end game screen
            await Clients.All.SendAsync("GameEnded", leaderboard);
            await Clients.All.SendAsync("UpdatePlayerState", PlayerInfo.PlayerState.EndGame);
        }
    }
}

public class RoundInfo
{
    private readonly string[] prompts = new string[]
    {
        "A word for a spider with diarrhea",
        "The tool that you would use for getting toast out of a toaster",
        "My gandma is the best at ____",
        "A man went to jail for...",
        "Why did the chicken cross the road?",
        "How would you describe what a dog is to an alien?",
        "The worst thing to be reincarnated as",
        "The worst thing to make a spaceship out of",
    };

    public readonly List<DuelInfo> duels = new List<DuelInfo>();

    public int completedDuels;
    public bool isDuelingComplete => completedDuels == duels.Count;

    public int completedVotes;
    public bool isVotingComplete => completedVotes == duels.Count;

    public RoundInfo(List<string> players, int roundIndex)
    {
        var isEven = (players.Count % 2) == 0;

        //if there is an odd number of players, remove one from the duel queue
        if (!isEven)
        {
            var sittingOutPlayer = players[roundIndex];
            players.Remove(sittingOutPlayer);
        }

        //add a new duel for each pair of players
        while (players.Count > 0)
        {
            duels.Add(new DuelInfo(prompts[new Random().Next(0, prompts.Length)], players.GetRange(0, 2).ToArray()));
            players.RemoveRange(0, 2);
        }
    }
}

public class DuelInfo
{
    public string[] players;
    public string prompt;
    public List<ResponseInfo> responses = new List<ResponseInfo>();

    public List<string> voters = new List<string>();
    public bool isVotingComplete => voters.Count == 0;

    public DuelInfo(string _prompt, string[] _players)
    {
        prompt = _prompt;
        players = _players;
    }
}