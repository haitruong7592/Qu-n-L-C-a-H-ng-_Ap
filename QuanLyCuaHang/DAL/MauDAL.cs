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
    public class MauDAL:dbConnect
    {
        public DataTable GetData()
        {
            return base.GetData("MAU_SelectAll", null);
        }

        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaMau", int.Parse(ID))
            };
            return base.GetData("MAU_SelectByID", para);
        }
        public DataTable GetDataByID_TenMau()
        {
            return base.GetData("MAU_SelectID_Ten", null);
        }
        public int Insert(Mau obj)
        {
            SqlParameter[] para =
            {
               
                new SqlParameter("Mau", obj.mauSP)

            };

            return base.ExcuteSQL("MAU_Insert", para);
        }

        public int Update(Mau obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaMau", obj.maMau),
                new SqlParameter("Mau", obj.mauSP)
            };

            return base.ExcuteSQL("MAU_Update", para);
        }
        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaMau", int.Parse(ID))
            };

            return base.ExcuteSQL("MAU_Delete", para);
        }
    }
}
