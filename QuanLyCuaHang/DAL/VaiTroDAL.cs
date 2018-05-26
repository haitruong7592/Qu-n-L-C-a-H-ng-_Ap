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
    public class VaiTroDAL:dbConnect
    {
        public DataTable GetData()
        {
            return base.GetData("VAITRO_SelectAll", null);
        }
        public DataTable GetDataID_TenVT()
        {
            return base.GetData("VAITRO_SelectID_Ten", null);
        }

        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaVT", int.Parse(ID))
            };
            return base.GetData("VAITRO_SelectByID", para);
        }
        public int Insert(VaiTro obj)
        {
            SqlParameter[] para =
            {
              
                new SqlParameter("TenVT", obj.tenVT)
            };

            return base.ExcuteSQL("VAITRO_Insert", para);
        }

        public int Update(VaiTro obj)
        {
            SqlParameter[] para =
            {
                //new SqlParameter("MaVT", obj.maVT),
                new SqlParameter("TenVT", obj.tenVT)
            };

            return base.ExcuteSQL("VAITRO_Update", para);
        }
        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaVT", int.Parse(ID))
            };

            return base.ExcuteSQL("VAITRO_Delete", para);
        }
    }
}
