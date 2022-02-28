using Attendence.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Attendence.DAL
{
    public class TeacherDAO:BaseDAO
    {
        public static List<Entity.Teacher> GetAllTeacher()
        {
            string sql = @"select t.AccountID,t.[Name],t.BirthDate,t.[Address],a.[username],a.[password] from teacher as t, [Account] as a
                                where  a.ID = t.AccountID";
            DataTable rs = GetDataBySQL(sql);
            List<Entity.Teacher> List = new List<Entity.Teacher>();
            foreach (DataRow r in rs.Rows)
            {
                List.Add(new Entity.Teacher(
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

        internal static int AddTeacher(string username, string password, string name, DateTime birthDate, string address)
        {
            string sql = "insert into Account(Username,[password],[role]) " +
                 "values('" + username + "','" + password + "'" + ",'teacher')";
            string sql2 = @"insert into teacher(AccountID,[Name],BirthDate,[Address])
                        values((select top 1 Account.ID from Account order by ID DESC),'" + name + "','"
                        + birthDate.ToString("MM/dd/yyyy") + "','" + address + "')";
            int Count = UpdateBySql(sql + " " + sql2);
            return Count;
        }

        internal static void DeleteTeacher(Teacher c)
        {
            string sql = "delete from [account] where ID = " + c.AccountID;
            string sql1 = "delete from teacher where AccountID = '" + c.AccountID + "'";
            string sql2 = "delete from schedule where teacherid = '" + c.AccountID + "'";
            UpdateBySql(sql2+" "+sql1 + " " + sql);
        }

        internal static int UpdateTeacher(int iD, string username, string password, string name, DateTime birthDate, string address)
        {
            string sql = "update [Account] set username = '" + username + "',password = '" + password + "' where ID = " + iD;
            string sql1 = "update [teacher] set Name = '" + name + "', Birthdate ='"
                   + birthDate.ToString("MM/dd/yyyy") + "',address='" + address + "' where AccountID = '" + iD + "'";
            return UpdateBySql(sql1 + " " + sql);
        }
        public static Teacher GetTeacherByUsernameAndPassword(string username,string password)
        {
            string sql = @"select a.ID,t.[Name],t.birthdate,t.[address],a.Username,a.[Password] from Account as a, Teacher as t
                                where t.AccountID = a.ID and a.username = '" + username + "' and [password] = '" + password + "' and [role] = 'teacher'";
            DataTable rs = GetDataBySQL(sql);
            if(rs == null)
            {
                return null;
            }
            foreach (DataRow r in rs.Rows)
            {
                return new Teacher(
                Convert.ToInt32(r[0]),
                Convert.ToString(r[1]),
                Convert.ToDateTime(r[2]),
                Convert.ToString(r[3]),
                Convert.ToString(r[4]),
                Convert.ToString(r[5])
                );
            }
            return null;
        }
    }
}
