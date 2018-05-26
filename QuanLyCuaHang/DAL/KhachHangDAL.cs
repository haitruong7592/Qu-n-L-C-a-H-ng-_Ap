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
    public class KhachHangDAL:dbConnect
    {
        public DataTable GetData()
        {
            return base.GetData("KHACHHANG_SelectAll", null);
        }

        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH", int.Parse(ID))
            };
            return base.GetData("KHACHHANG_SelectByID", para);
        }

        public DataTable ThongKeTheoKhachHang(string Thang, string Nam)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Thang", int.Parse(Thang)),
                new SqlParameter("Nam", int.Parse(Nam))
            };
            return base.GetData("ThongKeTheoKhachHang", para);
        }
        public int Insert(KhachHang obj)
        {
            SqlParameter[] para =
            {
               
                new SqlParameter("TenKH", obj.tenKH),
                new SqlParameter("SdtKH", obj.sDT),
                new SqlParameter("PhaiKH", obj.gioiTinh),
                new SqlParameter("NgaySinh", obj.ngSinh),
                new SqlParameter("Email", obj.email),
                new SqlParameter("DiaChi", obj.diaChi),
                new SqlParameter("MaLKH", obj.maLKH),
                new SqlParameter("GhiChu", obj.ghiChu)
            };

            return base.ExcuteSQL("KHACHHANG_Insert", para);
        }

        public int Update(KhachHang obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH", obj.maKH),
                new SqlParameter("TenKH", obj.tenKH),
                new SqlParameter("SdtKH", obj.sDT),
                new SqlParameter("PhaiKH", obj.gioiTinh),
                new SqlParameter("NgaySinh", obj.ngSinh),
                new SqlParameter("Email", obj.email),
                new SqlParameter("DiaChi", obj.diaChi),
                new SqlParameter("MaLKH", obj.maLKH),
                new SqlParameter("GhiChu", obj.ghiChu)
            };

            return base.ExcuteSQL("KHACHHANG_Update", para);
        }
        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH", int.Parse(ID))
            };

            return base.ExcuteSQL("KHACHHANG_Delete", para);
        }
        public DataTable Search(string chuoi)
        {
            SqlParameter[] para =
            {
                new SqlParameter("CHUOI", chuoi)
            };
            // string strQ = "	SELECT      KHACHHANG.maKH, KHACHHANG.tenKH, KHACHHANG.sdtKH, KHACHHANG.phaiKH, KHACHHANG.ngsinhKH, KHACHHANG.emailKH, KHACHHANG.diachiKH, LOAIKHACHHANG.tenLKH, KHACHHANG.ghichuKH FROM KHACHHANG INNER JOIN LOAIKHACHHANG ON KHACHHANG.maLKH = LOAIKHACHHANG.maLKH WHERE tenKH like '%" + chuoi + "%' or tenLKH like '%" + chuoi + "%'";
            return base.GetData("KHACHHANG_Search_Ten_LoaiKH", para);
        }
        public DataTable SearchuBySDT(string SDT)
        {
            SqlParameter[] para =
            {
                new SqlParameter("SDT", SDT)
            };
            return base.GetData("KHACHHANG_SearchBySDT", para);
        }
    }
}
