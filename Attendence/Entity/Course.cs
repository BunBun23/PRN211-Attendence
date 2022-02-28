using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attendence.Entity
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Activity { get; set; }
        public string Description { get; set; }

        public Course()
        {
        }

        public Course(int iD, string name, bool activity, string description)
        {
            ID = iD;
            Name = name;
            Activity = activity;
            Description = description;
        }

        public Course(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public Course(string name, bool activity, string description)
        {
            Name = name;
            Activity = activity;
            Description = description;
        }
    }
}
