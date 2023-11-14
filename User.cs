using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForBankProject
{
    internal class User
    { 
        public string Username { get; set; }
        public string Password { get; set; }
        public User(string username, string password)
        {
            Username = username + "a";
            Password = password;
        }
    }
}
