using Attendence.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Attendence.DAL
{
    class ClassDAO:BaseDAO
    {
        public static List<Class> GetAllClasss()
        {
            string sql = "select ID,[Name],description from class";
            DataTable rs = GetDataBySQL(sql);
            if(rs == null)
            {
                return null;
            }
            List<Class> List = new List<Class>();
            foreach (DataRow r in rs.Rows)
            {
                List.Add(new Class(
                   Convert.ToInt32(r["ID"]),
                   Convert.ToString(r["Name"]),
                   Convert.ToString(r["description"])
                ));
            }
            return List;
        }
        public static int AddClass(Class c)
        {
            string sql = "insert into Class(Name,NumberStudent,Description) " +
                "values('" + c.Name +"','"+c.Description +"')";
            int Count = UpdateBySql(sql);
            return Count;
        }
        public static void DeleteClassByID(int ID)
        {
            string sql = "delete from class where id = '" + ID + "'";
            UpdateBySql(sql);
        }

        internal static int UpdateClass(int ID,string Name,string des)
        {
            string sql = "update [class] set Name = '" + Name + "', description = '" + des + "' where ID = '" + ID + "'";
           return UpdateBySql(sql);
        }
    }
}
