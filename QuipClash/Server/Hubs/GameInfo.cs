using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuipClash.Shared;

namespace QuipClash.Server.Hubs
{
    public class GameInfo
    {
        public readonly Dictionary<string, PlayerInfo> players = new Dictionary<string, PlayerInfo>();

        public readonly List<RoundInfo> rounds = new List<RoundInfo>();
        public int numberOfRounds;

        public int roundIndex = 0;

        public GameInfo(int _numberOfRounds)
        {
            numberOfRounds = _numberOfRounds;
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