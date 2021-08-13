using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuipClash.Shared
{
    public class PlayerInfo
    {
        public string gameID { get; set; }
        public bool isPartyLeader { get; set; }
        public string username { get; set; }
        public int mascottNumber { get; set; }

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
        public PlayerInfo(string _gameID, bool _isPartyLeader, string _username, int _mascottNumber)
        {
            gameID = _gameID;
            isPartyLeader = _isPartyLeader;
            username = _username;
            mascottNumber = _mascottNumber;
        }
    }
}
