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
    public class LoaiKhachHangDAL:dbConnect
    {
        public DataTable GetData()
        {
            return base.GetData("LOAIKHACHHANG_SelectAll", null);
        }

        public DataTable GetDataID_Ten()
        {
            return base.GetData("LOAIKHACHHANG_SelectID_Ten", null);
        }
        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLKH", int.Parse(ID))
            };
            return base.GetData("LOAIKHACHHANG_SelectByID", para);
        }
        public int Insert(LoaiKhachHang obj)
        {
            SqlParameter[] para =
            {
                
                new SqlParameter("TenLKH", obj.tenLKH),
                new SqlParameter("ChuanLKH", obj.chuanLKH),
                new SqlParameter("GhiChuLKH", obj.ghiChu)

            };

            return base.ExcuteSQL("LOAIKHACHHANG_Insert", para);
        }

        public int Update(LoaiKhachHang obj)
        {
            SqlParameter[] para =
            {
               // new SqlParameter("MaLKH", obj.maLKH),
                new SqlParameter("TenLKH", obj.tenLKH),
                new SqlParameter("ChuanLKH", obj.chuanLKH),
                new SqlParameter("GhiChuLKH", obj.ghiChu)
            };

            return base.ExcuteSQL("LOAIKHACHHANG_Update", para);
        }
        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLKH", int.Parse(ID))
            };

            return base.ExcuteSQL("LOAIKHACHHANG_Delete", para);
        }
    }
}
