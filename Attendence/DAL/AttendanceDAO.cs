using Attendence.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Attendence.DAL
{
    public class AttendanceDAO:BaseDAO
    {
        public static List<Attendence.Entity.Attendance> GetAllAtttendanceByScheduleID(int ID)
        {
            string sql = @"select Attedance.StudentID,Student.[Name], Schedule.ID,[Status] from Student,Schedule,Attedance
                                 where Student.ClassID = Schedule.ClassID and Attedance.ScheduleID = Schedule.ID
                                 and Attedance.StudentID = Student.AccountID and Schedule.ID = " + ID;
            DataTable rs = GetDataBySQL(sql);
            if (rs == null)
            {
                return null;
            }
            List<Attendence.Entity.Attendance> List = new List<Attendence.Entity.Attendance>();
            foreach (DataRow r in rs.Rows)
            {
                List.Add(new Attendence.Entity.Attendance(
                   Convert.ToInt32(r[0]),
                   Convert.ToString(r[1]),
                   Convert.ToInt32(r[2]),
                   Convert.ToBoolean(r[3])
                ));
            }
            return List;
        }

        public static object GetAllAtttendanceByCourseIdAndClassIdAndStudentId(string courseID, string classID, string studentID)
        {
            string sql = @"with r as (
	                    select Schedule.ID as ScheduleID,Schedule.[date],Class.[Name] as ClassName,Slot.ID as SlotID,Room.[Name] as RoomName
	                    from Schedule,Class,Slot,Room where Schedule.CourseID = '" + courseID + "' and Schedule.ClassID = '" + classID + "' and Class.ID = Schedule.ClassID" +
                        " and Slot.ID = Schedule.SlotID and Room.ID = Schedule.RoomID ) select * from Attedance inner join r " +
                        "on Attedance.ScheduleID = r.ScheduleID and StudentID = '" + studentID +"'";
            DataTable rs = GetDataBySQL(sql);
            if (rs == null)
            {
                return null;
            }
            List<Attendence.Entity.Attendance> List = new List<Attendence.Entity.Attendance>();
            foreach (DataRow r in rs.Rows)
            {
                List.Add(new Attendence.Entity.Attendance(
                   Convert.ToInt32(r[0]),
                   Convert.ToInt32(r[1]),
                   Convert.ToBoolean(r[2]),
                   Convert.ToDateTime(r[4]),
                   Convert.ToString(r[5]),
                   Convert.ToString(r[7]),
                   Convert.ToInt32(r[6])
                ));
            }
            return List;
        }

        public static int AddAttendanceByScheduleID(int ScheduleID)
        {
            List<Student> ListStu = StudentDAO.GetAllStudentByScheduleID(ScheduleID);
            if(ListStu == null)
            {
                return 0;
            }
            int count = 0;
            string sql = "";
            foreach (var item in ListStu)
            {
               sql = "insert into Attedance(StudentID,ScheduleID,[Status]) values('" + item.AccountID +"', '" + ScheduleID +"', 'false') ";
               BaseDAO.UpdateBySql(sql);
               count++;
            }
            return count;
        }

        public static void AddSaveAttendance(string scheduleID, string studentID, string status)
        {
            string sql = "update Attedance set [status] = '" + status +"' where StudentID = " + studentID + " and ScheduleID = " + scheduleID;
            UpdateBySql(sql);
        }
    }
}
