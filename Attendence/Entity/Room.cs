using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attendence.Entity
{
    class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Activity { get; set; }

        public Room(int iD, string name, bool activity)
        {
            ID = iD;
            Name = name;
            Activity = activity;
        }
        public Room( string name, bool activity)
        {
            Name = name;
            Activity = activity;
        }
        public Room()
        {
        }
    }
}
