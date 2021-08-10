using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuipClash.Shared
{
    public class PlayerInfo
    {
        public string username { get; set; }
        public bool isPartyLeader { get; set; }

        public int points { get; set; }
        public PlayerState playerState { get; set; }
        public enum PlayerState
        {
            Lobby,
            Responding,
            Waiting,
            Voting,
            EndGame,
        };

        public PlayerInfo() { }
        public PlayerInfo(string _username, bool _isPartyLeader)
        {
            username = _username;
            isPartyLeader = _isPartyLeader;
        }
    }
}
