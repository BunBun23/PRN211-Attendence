using Attendence.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Attendence.DAL
{
    class RoomDAO : BaseDAO
    {
        public static List<Room> GetAllRoom()
        {
            string sql = "select * from room";
            DataTable rs = GetDataBySQL(sql);
            List<Room> List = new List<Room>();
            foreach (DataRow r in rs.Rows)
            {
                List.Add(new Room(
                    Convert.ToInt32(r["ID"]),
                    Convert.ToString(r["Name"]),
                    Convert.ToBoolean(r["Activity"])
                    ));
            }
            return List;
        }
        public static List<Room> GetAllRoomActive()
        {
            string sql = "select * from room where activity = 'true'";
            DataTable rs = GetDataBySQL(sql);
            List<Room> List = new List<Room>();
            foreach (DataRow r in rs.Rows)
            {
                List.Add(new Room(
                    Convert.ToInt32(r["ID"]),
                    Convert.ToString(r["Name"]),
                    Convert.ToBoolean(r["Activity"])
                    ));
            }
            return List;
        }

        internal static int AddRoom(Room r)
        {
            string sql = "insert into Room(Name,Activity) " +
                 "values('" + r.Name + "','" + r.Activity + "')";
            int Count = UpdateBySql(sql);
            return Count;
        }

        internal static void DeleteRoomByID(int iD)
        {
            string sql = "delete from room where id = '" + iD + "'";
            UpdateBySql(sql);
        }

        internal static int UpdateRoom(int iD, string name, bool active)
        {
            string sql = "update [room] set Name = '" + name + "', Activity ='"
                   + active + "' where ID = '" + iD + "'";
            return UpdateBySql(sql);

        }
    }
}
