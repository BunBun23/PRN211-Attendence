using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attendence.Entity
{
    public class Schedule
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int SlotID { get; set; }
        public string SlotName { get; set; }
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public int RoomID { get; set; }
        public string  RoomName { get; set; }
        public int AdminID { get; set; }
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public DateTime StartDate { get; set; }

        public Schedule(int iD, int courseID, string courseName, int slotID, string slotName, int classID,
            string className, int roomID, string roomName, int adminID, int teacherID, string teacherName, DateTime startDate)
        {
            ID = iD;
            CourseID = courseID;
            CourseName = courseName;
            SlotID = slotID;
            SlotName = slotName;
            ClassID = classID;
            ClassName = className;
            RoomID = roomID;
            RoomName = roomName;
            AdminID = adminID;
            TeacherID = teacherID;
            TeacherName = teacherName;
            StartDate = startDate;
        }

        public Schedule(int courseID, int slotID, int classID, int roomID, int adminID, int teacherID, DateTime startDate)
        {
            CourseID = courseID;
            SlotID = slotID;
            ClassID = classID;
            RoomID = roomID;
            AdminID = adminID;
            TeacherID = teacherID;
            StartDate = startDate;
        }
    }
}
