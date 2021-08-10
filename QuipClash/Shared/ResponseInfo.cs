using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuipClash.Shared
{
    public class ResponseInfo
    {
        public string response { get; set; }
        public string authorID { get; set; }
        public int optionNumber { get; set; }

        public ResponseInfo() { }
        public ResponseInfo(string _response, string _authorID, int _optionNumber)
        {
            response = _response;
            authorID = _authorID;
            optionNumber = _optionNumber;
        }
    }
}
