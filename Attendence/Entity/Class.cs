using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attendence.Entity
{
    class Class
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Class(int iD, string name,  string description)
        {
            ID = iD;
            Name = name;
            this.Description = description;
        }
        public Class(string name, string description)
        {
            Name = name;
            this.Description = description;
        }

        public Class()
        {
        }
    }
}
