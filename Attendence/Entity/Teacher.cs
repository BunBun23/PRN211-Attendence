using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attendence.Entity
{
   public class Teacher
    {
        public int AccountID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Teacher(int accountID, string name, DateTime birthDate, string address, string username, string password)
        {
            AccountID = accountID;
            Name = name;
            BirthDate = birthDate;
            Address = address;
            Username = username;
            Password = password;
        }

        public Teacher()
        {
        }
    }
}
