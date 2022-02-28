using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
namespace Attendence.DAL
{
    public class BaseDAO
    {
        public static SqlConnection GetConnection()
        {
            string con = ConfigurationManager.ConnectionStrings["AttendentConnectString"].ToString();
            return new SqlConnection(con);
        }
        public static DataTable GetDataBySQL(string sql)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable rs = new DataTable();
            adapter.Fill(rs);
            if (rs.Rows.Count > 0)
            {
                return rs;
            }
            return null;
        } 
        public static int UpdateBySql(string sql)
        {
            SqlCommand command = new SqlCommand(sql,GetConnection());
            command.Connection.Open();
            int Count = command.ExecuteNonQuery();
            command.Connection.Close();
            return Count;
        }
    }
}
