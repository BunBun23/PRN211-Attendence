using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Attendence.Entity;
namespace Attendence.DAL
{
    class AdminDAO:BaseDAO
    {
        public static Admin GetAdminByUserNameAndPassword(string username, string password)
        {
            string sql = "select * from account where username = '" + username + "' and password = '" + password + "' and role = 'admin'";
            DataTable rs = GetDataBySQL(sql);
            if (rs != null)
            {
                return new Admin(
                    Convert.ToInt32(rs.Rows[0][0]),
                    Convert.ToString(rs.Rows[0][1]),
                    Convert.ToString(rs.Rows[0][2]),
                    Convert.ToString(rs.Rows[0][3])
                 );
            }
            return null;
        }
    }
}
