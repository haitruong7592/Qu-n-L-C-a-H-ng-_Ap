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
    public class NhomQuyenDAL:dbConnect
    {
        public DataTable GetData()
        {
            return base.GetData("NHOMQUYEN_SelectAll", null);
        }

        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaQ", int.Parse(ID))
            };
            return base.GetData("NHOMQUYEN_SelectByID", para);
        }
        public int Insert(NhomQuyen obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaVT", obj.maVT),
                new SqlParameter("MaQ", obj.maQ)

            };

            return base.ExcuteSQL("NHOMQUYEN_Insert", para);
        }

        public int Update(NhomQuyen obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaVT", obj.maVT),
                new SqlParameter("MaQ", obj.maQ)
            };

            return base.ExcuteSQL("NHOMQUYEN_Update", para);
        }
        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaQ", int.Parse(ID))
            };

            return base.ExcuteSQL("NHOMQUYEN_Delete", para);
        }
    }
}
