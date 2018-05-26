using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class QuyenDAL:dbConnect
    {
        public DataTable GetData()
        {
            return base.GetData("QUYEN_SelectAll", null);
        }

        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaQ", int.Parse(ID))
            };
            return base.GetData("QUYEN_SelectByID", para);
        }
        public int Insert(Quyen obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("TenQ", obj.tenQ)
            };

            return base.ExcuteSQL("QUYEN_Insert", para);
        }

        public int Update(Quyen obj)
        {
            SqlParameter[] para =
            {
               // new SqlParameter("MaQ", obj.maQ),
                new SqlParameter("TenQ", obj.tenQ)
            };

            return base.ExcuteSQL("QUYEN_Update", para);
        }
        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaQ", int.Parse(ID))
            };

            return base.ExcuteSQL("QUYEN_Delete", para);
        }
    }
}
