using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForBankProject
{
    internal class User
    { 
        public int SecurityNumber { get; set; }
        public int Password { get; set; }
        public User(int securityNumber, int password)
        {
            SecurityNumber = securityNumber;
            Password = password;
        }
    }
}
