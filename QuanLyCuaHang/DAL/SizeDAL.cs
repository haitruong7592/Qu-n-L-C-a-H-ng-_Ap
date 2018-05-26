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
    public class SizeDAL:dbConnect
    {
        public DataTable GetData()
        {
            return base.GetData("SIZE_SelectAll", null);
        }

        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaSize", int.Parse(ID))
            };
            return base.GetData("SIZE_SelectByID", para);
        }
        public DataTable GetDataID_TenSize()
        {
            return base.GetData("SIZE_SelectID_TenSize", null);
        }
        //public int Insert(Size obj)
        //{
        //    int result = 0;
        //    result = base.excuteNoneQuery("SIZE_Insert");
        //    return result; //tra ve so ghi nhan thuc hien
        //}

        //public int Update(Size obj)
        //{
        //    int result = 0;
        //    // string strQuery = "update SINHVIEN set HoTen=N'" + obj.HoTen + "',NgaySinh='" + obj.NgaySinh + "',Phai=N'" + obj.Phai + "',Email='" + obj.Email + "',SDT='" + obj.SDT + "' where MSSV='" + obj.MSSV + "'";
        //    //dbConnect config = new dbConnect();
        //    result = base.excuteNoneQuery("SIZE_Update");
        //    return result; //tra ve so ghi nhan thuc hien
        //}
        //public int Delete(string Masi)
        //{
        //    int result = 0;
        //    result = base.excuteNoneQuery("LSP_Delete");
        //    return result; //tra ve so ghi nhan thuc hien
        //}


        public int Insert(Size obj)
        {
            SqlParameter[] para =
            {
               
                new SqlParameter("Size", obj.sizeSP)
            };

            return base.ExcuteSQL("SIZE_Insert", para);
        }

        public int Update(Size obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaSize", obj.maSize),
                new SqlParameter("Size", obj.sizeSP)
            };

            return base.ExcuteSQL("SIZE_Update", para);
        }
        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaSize", int.Parse(ID))
            };

            return base.ExcuteSQL("SIZE_Delete", para);
        }
    }
}
