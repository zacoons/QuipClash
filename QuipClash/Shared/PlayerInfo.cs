using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuipClash.Shared
{
    public class PlayerInfo
    {
        public string gameID { get; set; }
        public string username { get; set; }
        public bool isPartyLeader { get; set; }

        public int points { get; set; }
        public PlayerState playerState { get; set; }
        public enum PlayerState
        {
            Menu,
            Lobby,
            Responding,
            Waiting,
            Voting,
            EndGame,
        };

        public PlayerInfo() { }
        public PlayerInfo(string _gameID, string _username, bool _isPartyLeader)
        {
            gameID = _gameID;
            username = _username;
            isPartyLeader = _isPartyLeader;
        }
    }
}
