using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attendence.Entity
{
    class Slot
    {
        public int ID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public Slot(int iD, string startDate, string endDate)
        {
            ID = iD;
            StartDate = startDate;
            EndDate = endDate;
        }
        public string FullName
        {
            get
            {
                return "Slot " + ID;
            }
        }
    }
}
