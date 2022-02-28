using Attendence.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Attendence.DAL
{
    public class StudentDAO:BaseDAO
    {
        public static List<Entity.Student> GetAllStudent()
        {
            string sql = @"select s.AccountID,s.[Name],s.BirthDate,s.[Address],a.[username],a.[password] from Student as s, [Account] as a
                                where  a.ID = s.AccountID";
            DataTable rs = GetDataBySQL(sql);
            List<Entity.Student> List = new List<Entity.Student>();
            foreach (DataRow r in rs.Rows)
            {
                List.Add(new Entity.Student(
                    Convert.ToInt32(r[0]),
                    Convert.ToString(r[1]),
                    Convert.ToDateTime(r[2]),
                    Convert.ToString(r[3]),
                    Convert.ToString(r[4]),
                    Convert.ToString(r[5])
                 ));
            }
            return List;
        }

        internal static int AddStudent(string username,string password,string name,DateTime birthdate,string address)
        {
            string sql = "insert into Account(Username,[password],[role]) " +
                 "values('" + username + "','" + password + "'" + ",'student')";
            string sql2 = @"insert into Student(AccountID,[Name],BirthDate,[Address])
                        values((select top 1 Account.ID from Account order by ID DESC),'" + name + "','" 
                        + birthdate.ToString("MM/dd/yyyy")+"','" + address +"')";
            int Count = UpdateBySql(sql + " " + sql2);
            return Count;
        }

        public static Student GetStudentByUsernameAndPassword(string username, string password)
        {
            string sql = @"select a.ID as AccountID,c.ID as ClassID,s.[Name],s.BirthDate,s.[Address],a.Username,a.[Password] 
                                from Student as s,Account as a,Class as c
                                where s.AccountID = a.ID and c.ID = s.ClassID and a.[Username] = '" + username + "' and a.[Password] = '" + password + "' and [Role] = 'student'";
            DataTable rs = GetDataBySQL(sql);
            if (rs == null)
            {
                return null;
            }
            foreach (DataRow r in rs.Rows)
            {
                return new Student(
                    Convert.ToInt32(r["AccountID"]),
                    Convert.ToInt32(r["ClassID"]),
                    Convert.ToString(r["Name"]),
                    Convert.ToDateTime(r["BirthDate"]),
                    Convert.ToString(r["Address"]),
                    Convert.ToString(r["Username"]),
                    Convert.ToString(r["Password"])
                );
            }
            return null;
        }

        internal static List<Entity.Student> GetAllStudentEmptyClass()
        {
            string sql = @"select s.AccountID,s.[Name],s.BirthDate,s.[Address],a.[username],a.[password] from Student as s, [Account] as a
                                where  a.ID = s.AccountID and ClassID is null";
            DataTable rs = GetDataBySQL(sql);
            if(rs == null)
            {
                return null;
            }
            List<Entity.Student> List = new List<Entity.Student>();
            foreach (DataRow r in rs.Rows)
            {
                List.Add(new Entity.Student(
                    Convert.ToInt32(r[0]),
                    Convert.ToString(r[1]),
                    Convert.ToDateTime(r[2]),
                    Convert.ToString(r[3]),
                    Convert.ToString(r[4]),
                    Convert.ToString(r[5])
                 ));
            }
            return List;
        }

        internal static int UpdateClassStudent(Student s,int selectedValue)
        {
            string sql1 = "update [student] set ClassID = " + selectedValue + " where AccountID = " + s.AccountID;
            return UpdateBySql(sql1);
        }

        internal static void RemoveStudentClass(int ClassID)
        {
            string sql = "update student set classid = NULL where classid = " + ClassID;
            UpdateBySql(sql);
        }

        internal static List<Entity.Student> GetAllStudentByClassID(int classID)
        {
            string sql = @"select s.AccountID,s.[Name],s.BirthDate,s.[Address],a.[username],a.[password] from Student as s, [Account] as a
                                where  a.ID = s.AccountID and ClassID = " + classID;
            DataTable rs = GetDataBySQL(sql);
            List<Entity.Student> List = new List<Entity.Student>();
            if(rs == null)
            {
                return null;
            }
            foreach (DataRow r in rs.Rows)
            {
                List.Add(new Entity.Student(
                    Convert.ToInt32(r[0]),
                    Convert.ToString(r[1]),
                    Convert.ToDateTime(r[2]),
                    Convert.ToString(r[3]),
                    Convert.ToString(r[4]),
                    Convert.ToString(r[5])
                 ));
            }
            return List;
        }

        internal static int UpdateClassStudentByNull(Student s)
        {
            string sql1 = "update [student] set ClassID = null where AccountID = " + s.AccountID;
            return UpdateBySql(sql1);
        }

        internal static void DeleteStudent(Student s)
        {
            string sql = "delete from [account] where ID = " + s.AccountID;
            string sql1 = "delete from student where AccountID = '" + s.AccountID + "'";
            UpdateBySql(sql1 + " " + sql);
        }


        internal static int UpdateStudent(int iD, string username, string password, string name, DateTime birthDate, string address)
        {
            string sql = "update [Account] set username = '" + username + "',password = '" + password + "' where ID = " + iD;
            string sql1 = "update [student] set Name = '" + name + "', Birthdate ='"
                   + birthDate.ToString("MM/dd/yyyy") + "',address='" + address +"' where AccountID = '" + iD + "'";
            return UpdateBySql(sql1 + " " +sql);
        }
        public static List<Student> GetAllStudentByScheduleID(int ScheduleID)
        {
            string sqlGetAllStudentBySchedule = @"select Student.AccountID,Student.[Name] from Student,Schedule
                                            where Student.ClassID = Schedule.ClassID and Schedule.ID = " + ScheduleID;

            DataTable rs = GetDataBySQL(sqlGetAllStudentBySchedule);
            if(rs == null)
            {
                return null;
            }
            List<Student> ListStu = new List<Student>();
            foreach (DataRow item in rs.Rows)
            {
                ListStu.Add(new Student(Convert.ToInt32(item[0]),Convert.ToString(item[1])));
            }
            return ListStu;
        }
    }
}
