using Attendence.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Attendence.DAL
{
    public class ScheduleDAO:BaseDAO
    {
        public static List<Schedule> GetAllSchedule()
        {
            string sql = @"select Schedule.ID,Course.ID as CourseID,Course.[Name],Slot.ID as SlotID,CONCAT('Slot ', Slot.ID) as SlotName,Class.ID as ClassID,Class.[Name],Room.ID as RoomID
                           ,Room.[Name],AdminID,Teacher.AccountID as TeacherID,Teacher.[Name],Schedule.[date] from Course,Slot,Class,Room,Teacher,Schedule
                        where Schedule.CourseID = Course.ID and Schedule.SlotID = Slot.ID and Class.ID = Schedule.ClassID and Schedule.RoomID = Room.ID
                        and Teacher.AccountID = Schedule.TeacherID";
            DataTable rs = GetDataBySQL(sql);
            if(rs == null)
            {
                return null;
            }
            List<Schedule> List = new List<Schedule>();
            foreach (DataRow r in rs.Rows)
            {
                List.Add(new Schedule(
                    Convert.ToInt32(r[0]),
                    Convert.ToInt32(r[1]),
                    Convert.ToString(r[2]),
                    Convert.ToInt32(r[3]),
                    Convert.ToString(r[4]),
                    Convert.ToInt32(r[5]),
                    Convert.ToString(r[6]),
                    Convert.ToInt32(r[7]),
                    Convert.ToString(r[8]),
                    Convert.ToInt32(r[9]),
                    Convert.ToInt32(r[10]),
                    Convert.ToString(r[11]),
                    Convert.ToDateTime(r["date"]) 
                ));
            }
            return List;
        }

        public static object GetAllScheduleByTeacherIdAndDate(int ID, string time)
        {
            string sql = @"select Schedule.ID,Course.ID as CourseID,Course.[Name],Slot.ID as SlotID,CONCAT('Slot ', Slot.ID) as SlotName,Class.ID as ClassID,Class.[Name],Room.ID as RoomID
                           ,Room.[Name],AdminID,Teacher.AccountID as TeacherID,Teacher.[Name],Schedule.[date] from Course,Slot,Class,Room,Teacher,Schedule
                        where Schedule.CourseID = Course.ID and Schedule.SlotID = Slot.ID and Class.ID = Schedule.ClassID and Schedule.RoomID = Room.ID
                        and Teacher.AccountID = Schedule.TeacherID and TeacherID = " + ID + " and [date] = '" + time + "' order by slotID";
            DataTable rs = GetDataBySQL(sql);
            if (rs == null)
            {
                return null;
            }
            List<Schedule> List = new List<Schedule>();
            foreach (DataRow r in rs.Rows)
            {
                List.Add(new Schedule(
                    Convert.ToInt32(r[0]),
                    Convert.ToInt32(r[1]),
                    Convert.ToString(r[2]),
                    Convert.ToInt32(r[3]),
                    Convert.ToString(r[4]),
                    Convert.ToInt32(r[5]),
                    Convert.ToString(r[6]),
                    Convert.ToInt32(r[7]),
                    Convert.ToString(r[8]),
                    Convert.ToInt32(r[9]),
                    Convert.ToInt32(r[10]),
                    Convert.ToString(r[11]),
                    Convert.ToDateTime(r["date"])
                ));
            }
            return List;
        }

        internal static void RemoveScheduleByCourseID(int iD)
        {
            string sql = "delete from schedule where courseID = " + iD;
            UpdateBySql(sql);
        }

        internal static void RemoveScheduleByRoomID(object iD)
        {
            string sql = "delete from schedule where roomID = " + iD;
            UpdateBySql(sql);
        }

        public static int AddSchedule(Schedule s)
        {
            string sql = @"insert into Schedule(CourseID,SlotID,ClassID,RoomID,AdminID,TeacherID,[date])
                            values(" +s.CourseID +"," + s.SlotID +","+s.ClassID +"," + s.RoomID +",1," + s.TeacherID +",'" + s.StartDate.ToString("yyyy-MM-dd") +"')";

            return UpdateBySql(sql);
        }

        internal static int DeleteSchedule(Schedule s)
        {
            string sql = "delete from schedule where ID = " + s.ID;
            return UpdateBySql(sql);
        }

        internal static void RemoveScheduleByClassID(int iD)
        {
            string sql = "delete from schedule where classID = " + iD;
            UpdateBySql(sql);
        }
        public static List<Schedule> GetAllScheduleTodayByTeacherID(int ID,string time)
        {
            string sql = @"select Schedule.ID,Course.ID as CourseID,Course.[Name],Slot.ID as SlotID,CONCAT('Slot ', Slot.ID) as SlotName,Class.ID as ClassID,Class.[Name],Room.ID as RoomID
                           ,Room.[Name],AdminID,Teacher.AccountID as TeacherID,Teacher.[Name],Schedule.[date] from Course,Slot,Class,Room,Teacher,Schedule
                        where Schedule.CourseID = Course.ID and Schedule.SlotID = Slot.ID and Class.ID = Schedule.ClassID and Schedule.RoomID = Room.ID
                        and Teacher.AccountID = Schedule.TeacherID and TeacherID = " + ID + " and [date] = '" + time + "' order by slotID";
            DataTable rs = GetDataBySQL(sql);
            if (rs == null)
            {
                return null;
            }
            List<Schedule> List = new List<Schedule>();
            foreach (DataRow r in rs.Rows)
            {
                List.Add(new Schedule(
                    Convert.ToInt32(r[0]),
                    Convert.ToInt32(r[1]),
                    Convert.ToString(r[2]),
                    Convert.ToInt32(r[3]),
                    Convert.ToString(r[4]),
                    Convert.ToInt32(r[5]),
                    Convert.ToString(r[6]),
                    Convert.ToInt32(r[7]),
                    Convert.ToString(r[8]),
                    Convert.ToInt32(r[9]),
                    Convert.ToInt32(r[10]),
                    Convert.ToString(r[11]),
                    Convert.ToDateTime(r["date"])
                ));
            }
            return List;
        }
    }
}
