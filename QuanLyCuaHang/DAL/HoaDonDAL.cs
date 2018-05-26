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
    public class HoaDonDAL:dbConnect
    {
        public DataTable GetData()
        {
            return base.GetData("HOADON_SelectAll", null);
        }

        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD", int.Parse(ID))
            };
            return base.GetData("HOADON_SelectByID", para);
        }

        public DataTable GetDataByTenKH(string TenKH)
        {
            SqlParameter[] para =
            {
                new SqlParameter("TenKH", TenKH)
            };
            return base.GetData("HOADON_SelectByTenKH", para);
        }
        public DataTable GetDataDistanceTime(DateTime TuNgay, DateTime DenNgay)
        {
            SqlParameter[] para =
            {
                new SqlParameter("TuNgay", TuNgay),
                new SqlParameter("DenNgay", DenNgay)
            };
            return base.GetData("HOADON_SelectDistanceTime", para);
        }

        public DataTable GetDataDistanceTime_TenKH(DateTime TuNgay, DateTime DenNgay, string TenKH)
        {
            SqlParameter[] para =
            {
                new SqlParameter("TuNgay", TuNgay),
                new SqlParameter("DenNgay", DenNgay),
                new SqlParameter("TenKH", TenKH)
            };
            return base.GetData("HOADON_SelectDistanceTime_TenKH", para);
        }
        public int Insert(HoaDon obj)
        {
            SqlParameter[] para =
            {
               
                new SqlParameter("MaND", obj.maND),
                new SqlParameter("MaKH", obj.maKH),
                new SqlParameter("NgayHD", obj.ngayHD),
                new SqlParameter("TongTien", obj.tongTien),
                new SqlParameter("TrangThaiHD", obj.trangThaiHD)
            };

            return base.ExcuteSQL("HOADON_Insert", para);
        }

        public int Update(HoaDon obj)
        {
            SqlParameter[] para =
            {
                //new SqlParameter("MaHD", obj.maHD),
                new SqlParameter("MaND", obj.maND),
                new SqlParameter("MaKH", obj.maKH),
                new SqlParameter("NgayHD", obj.ngayHD),
                new SqlParameter("TongTien", obj.tongTien),
                new SqlParameter("TrangThaiHD", obj.trangThaiHD)
            };

            return base.ExcuteSQL("HOADON_Update", para);
        }
        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD", int.Parse(ID))
            };

            return base.ExcuteSQL("HOADON_Delete", para);
        }
    }
}
