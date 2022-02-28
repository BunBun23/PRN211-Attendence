using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attendence.DAL
{
    public class ValidateDAO:BaseDAO
    {
        public static bool CheckClassHaveSlotInDateInput(int ClassID, int SlotID, DateTime StartDate)
        {
            string sql = @"select * from Schedule
                        where ClassID = " + ClassID +" and SlotID = " + SlotID +" and date = '" + StartDate.ToString("yyyy-MM-dd") +"'";
            if(GetDataBySQL(sql) != null)
            {
                return true;
            }
            return false;
        }
        public static bool CheckRoomEmptyInSlotOnDate(int RoomID, int SlotID, DateTime StartDate)
        {
            string sql = @"select * from Schedule
                        where RoomID = " + RoomID + " and SlotID = " + SlotID + " and date = '" + StartDate.ToString("yyyy-MM-dd") + "'";
            if (GetDataBySQL(sql) != null)
            {
                return true;
            }
            return false;
        }
        public static bool CheckTeacherActiveInSlotOnDate(int TeacherID, int SlotID, DateTime StartDate)
        {
            string sql = @"select * from Schedule
                        where TeacherID = " + TeacherID + " and SlotID = " + SlotID + " and date = '" + StartDate.ToString("yyyy-MM-dd") + "'";
            if (GetDataBySQL(sql) != null)
            {
                return true;
            }
            return false;
        }
        public static bool CheckAttendaceByScheduleID(int ScheduleID)
        {
            string sql = "select * from Attedance where ScheduleID = " + ScheduleID;
            if (GetDataBySQL(sql) != null)
            {
                return true;
            }
            return false;
        }

        internal static bool CheckScheduleExist(int iD)
        {
            string sql = "select * from Attedance where ScheduleID = " + iD;
            if (GetDataBySQL(sql) != null)
            {
                return true;
            }
            return false;
        }

        internal static bool CheckStudentAvtive(int accountID)
        {
            string sql = "select * from Attedance where StudentID = " + accountID;
            if (GetDataBySQL(sql) != null)
            {
                return true;
            }
            return false;
        }
    }
}
