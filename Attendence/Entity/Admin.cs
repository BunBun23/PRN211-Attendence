using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attendence.Entity
{
    class Admin
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Admin()
        {
        }

        public Admin(int iD, string userName, string password, string role)
        {
            ID = iD;
            UserName = userName;
            Password = password;
            Role = role;
        }
    }
}
