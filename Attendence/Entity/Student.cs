using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attendence.Entity
{
    public class Student
    {
        public int AccountID { get; set; }
        public int ClassID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string CreateDate { get; set; }
        public Student()
        {
        }

        public Student(int accountID, int classID,  string name, DateTime birthDate, string address,string u,string pas)
        {
            AccountID = accountID;
            ClassID = classID;
            Name = name;
            BirthDate = birthDate;
            Address = address;
            Username = u;
            Password = pas;
        }
        public Student(int accountID,string name,DateTime date,string address, string u, string pas)
        {
            AccountID = accountID;
            Name = name;
            BirthDate = date;
            Address = address;
            Username = u;
            Password = pas;
        }

        public Student(string username, string password, string name, DateTime birthDate, string address)
        {
            Username = username;
            Password = password;
            Name = name;
            BirthDate = birthDate;
            Address = address;
        }
        public Student(string name,DateTime date,string username,string password)
        {
            Name = name;
            BirthDate = date;
            Username = username;
            Password = password;
        }

        public Student(int accountID, string name)
        {
            AccountID = accountID;
            Name = name;
        }
    }
}
