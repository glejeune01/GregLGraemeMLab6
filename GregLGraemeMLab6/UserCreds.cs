using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GregLGraemeMLab6
{
    public class UserCreds
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Group { get; set; }

        public UserCreds(string username, string password, string group)
        {
            Username = username;
            Password = password;
            Group = group;
        }
    }
}
