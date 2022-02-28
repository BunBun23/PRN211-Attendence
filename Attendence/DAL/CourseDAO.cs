using Attendence.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Attendence.DAL
{
    public class CourseDAO:BaseDAO
    {
        public static List<Course> GetAllCourse()
        {
            string sql = "select * from course";
            DataTable rs = GetDataBySQL(sql);
            List<Course> List = new List<Course>();
            foreach (DataRow r in rs.Rows)
            {
                List.Add(new Course(
                    Convert.ToInt32(r["ID"]),
                    Convert.ToString(r["Name"]),
                    Convert.ToBoolean(r["Activity"]),
                    Convert.ToString(r["Description"])
                ));
            }
            return List;
        }
        public static List<Course> GetAllCourseActive()
        {
            string sql = "select * from course where activity = 'true'";
            DataTable rs = GetDataBySQL(sql);
            List<Course> List = new List<Course>();
            foreach (DataRow r in rs.Rows)
            {
                List.Add(new Course(
                    Convert.ToInt32(r["ID"]),
                    Convert.ToString(r["Name"]),
                    Convert.ToBoolean(r["Activity"]),
                    Convert.ToString(r["Description"])
                ));
            }
            return List;
        }
        public static int AddCourse(Course c)
        {
            string sql = "insert into Course(Name,Activity,Description) " +
                "values('" + c.Name + "','" + c.Activity + "','" + c.Description + "')";
            int Count = UpdateBySql(sql);
            return Count;
        }
        public static void DeleteCourseByID(int ID)
        {
            string sql = "delete from course where id = '" + ID + "'";
            UpdateBySql(sql);
        }

        internal static int UpdateCourse(int ID, string Name, bool Num, string des)
        {
            string sql = "update [course] set Name = '" + Name + "', activity ='"
                + Num + "', description = '" + des + "' where ID = '" + ID + "'";
            return UpdateBySql(sql);
        }
        public static List<Course> GetAllCourseByClassID(int ClassID)
        {
            string sql = "select distinct Course.ID,Course.[Name] from Course ,Schedule where Schedule.ClassID = '" + ClassID +"' and Course.ID = Schedule.CourseID";
            DataTable rs = GetDataBySQL(sql);
            List<Course> List = new List<Course>();
            foreach (DataRow r in rs.Rows)
            {
                List.Add(new Course(
                    Convert.ToInt32(r["ID"]),
                    Convert.ToString(r["Name"])
                ));
            }
            return List;
        }
    }
}
