using Attendence.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Attendence.DAL
{
    class SlotDAO:BaseDAO
    {
        public static List<Slot> GetAllSlot()
        {
            string sql = "select * from slot";
            DataTable rs = GetDataBySQL(sql);
            List<Slot> List = new List<Slot>();
            foreach (DataRow r in rs.Rows)
            {
                List.Add(new Slot(
                    Convert.ToInt32(r[0]),
                    Convert.ToString(r[1]),
                    Convert.ToString(r[2])
                    ));
            }
            return List;
        }
    }
}
