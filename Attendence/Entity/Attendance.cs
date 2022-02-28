using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attendence.Entity
{
    public class Attendance
    {
        public int AccountID { get; set; }
        public string Name { get; set; }
        public int ScheduleID { get; set; }
        public bool Status { get; set; }
        public string Cheked { get; set; }

        public DateTime Date { get; set; }
        public string ClassName { get; set; }
        public int SlotID { get; set; }
        public string RoomName { get; set; }

        public string statusStr;
        public Attendance(int accountID, string name, int scheduleID, bool status)
        {
            AccountID = accountID;
            Name = name;
            ScheduleID = scheduleID;
            Status = status;
            if(Status == true)
            {
                Cheked = "checked";
                statusStr = "Attend";
            }
            else
            {
                Cheked = "";
                statusStr = "Absent";
            }
        }

        public Attendance(int accountID, int scheduleID, bool status)
        {
            AccountID = accountID;
            ScheduleID = scheduleID;
            Status = status;
            if (Status == true)
            {
                Cheked = "checked";
                statusStr = "Attend";
            }
            else
            {
                Cheked = "";
                statusStr = "Absent";
            }
        }
        public Attendance(int studentId,int scheduleId,bool status,DateTime date,string className,string roomName, int slot)
        {
            AccountID = studentId;
            ScheduleID = scheduleId;
            Status = status;
            Date = date;
            ClassName = className;
            RoomName = roomName;
            SlotID = slot;
            if (Status == true)
            {
                Cheked = "checked";
                statusStr = "Attend";
            }
            else
            {
                Cheked = "";
                statusStr = "Absent";
            }
        }
        public string StatusStr
        {
            get { return statusStr; }
            set {}
        }
        public Attendance()
        {
        }
    }
}
