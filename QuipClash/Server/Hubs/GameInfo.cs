using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using QuipClash.Shared;

namespace QuipClash.Server.Hubs
{
    public class GameInfo
    {
        public static readonly int NumberOfRounds = 3;
        public static readonly int ResponseTime = 60;
        public static readonly int VoteTime = 30;
        
        public readonly Dictionary<string, PlayerInfo> players = new Dictionary<string, PlayerInfo>();

        public readonly List<RoundInfo> rounds = new List<RoundInfo>();

        public int roundIndex = 0;
    }
}

public class RoundInfo
{
    private readonly string[] prompts = new string[]
    {
        "My gandma is the best at...",
        "The tool that you would use for getting toast out of a toaster",
        "How did the cow jump over the moon",
        "The worst thing to be reincarnated as",
        "A man went to jail for...",
        "Why did the chicken cross the road",
        "How would you describe what a dog is to an alien",
        "A word for a spider with diarrhea",
        "An interesting ice-cream flavour",
        "The worst thing to make a spaceship out of",
        "Something you never see a cop doing",
        "Something you would never find on pizza",
        "The title of a tragedy movie starring a cat",
        "A very unique greeting",
        "Use three words to describe snow",
        "What did the cavement use instead of walkie-talkies",
        "The name of an animal that you would never want to cuddle with",
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
            var randomPromptIndex = new Random().Next(0, prompts.Length);
            duels.Add(new DuelInfo(prompts[randomPromptIndex], players.GetRange(0, 2).ToArray()));
            players.RemoveRange(0, 2);
        }
    }
}

public class DuelInfo
{
    public string[] players;
    public string prompt;
    public List<ResponseInfo> responses = new List<ResponseInfo>(2);

    public List<string> voters = new List<string>();
    public bool isVotingComplete => voters.Count == 0;

    public DuelInfo(string _prompt, string[] _players)
    {
        prompt = _prompt;
        players = _players;
    }
}