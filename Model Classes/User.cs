using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlue.Model_Classes
{
    public class User
    {
        public string FullName { get; set; }
        public string Username { get; set; } // should uniquely identify a user
        public string AccountType { get; set; }
        public string EmailType { get; set; }
        public char[] Password { get; set; }
    }
}
