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
    public class NguoiDungDAL:dbConnect
    {
        public DataTable GetData()
        {
            return base.GetData("NGUOIDUNG_SelectAll", null);
        }

        public DataTable GetDataNguoiDung()
        {
            return base.GetData("NguoiDung_HienThi", null);
        }
        public DataTable GetDataID_Ten()
        {
  
            return base.GetData("NGUOIDUNG_SelectID_TenND", null);
        }
        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaND",int.Parse( ID))
            };
            return base.GetData("NGUOIDUNG_SelectByID", para);
        }
        //public NguoiDung GeteDataByTen_ID(string TaiKhoanND)
        //{
        //    NguoiDung result = null;
        //    string query = "NGUOIDUNG_SelectByTaiKhoan @TaiKhoanND";
        //    result = base.exeCuteScalarQuery(query);
        //    return result;
        //}
        //public int Insert(NguoiDung obj)
        //{
        //    int result = 0;
        //    //string strQuery = "insert into SINHVIEN (MSSV,HoTen,NgaySinh,Phai,Email,SDT,Khoa) values ('" + obj.MSSV + "',N'" + obj.HoTen + "','" + obj.NgaySinh + "',N'" + obj.Phai + "','" + obj.Email + "','" + obj.SDT + "',N'" + obj.Khoa + "')";
            
        //    result = base.excuteNoneQuery("NGUOIDUNG_Insert");
        //    return result; //tra ve so ghi nhan thuc hien
        //}
        //check ID
        //public bool CheckID(string MaND)
        //{
        //    //  bool result = true;
            
        //    //string strQuery = "select * from SANPHAM where maSP ='" + MaSP + "'";
        //    DataTable DT = new DataTable();
        //    DT = base.GetData("NGUOIDUNG_SelectByID");
        //    if (DT.Rows.Count > 0)
        //        return true;
        //    return false;
        //}
        //public int Update(NguoiDung obj)
        //{
        //    int result = 0;
        //     string strQuery = "update SINHVIEN set HoTen=N'" + obj.HoTen + "',NgaySinh='" + obj.NgaySinh + "',Phai=N'" + obj.Phai + "',Email='" + obj.Email + "',SDT='" + obj.SDT + "' where MSSV='" + obj.MSSV + "'";
        //    dbConnect config = new dbConnect();
        //    result = base.excuteNoneQuery("NGUOIDUNG_Update");
        //    return result; //tra ve so ghi nhan thuc hien
        //}
        // xoa
        //public int Delete(string MaND)
        //{
        //    int result = 0;
        //    string strQuery = "delete from SINHVIEN where MSSV='" + MaSP + "'";
        //    dbConnect config = new dbConnect();
        //    result = base.excuteNoneQuery("NGUOIDUNG_Delete");
        //    return result; //tra ve so ghi nhan thuc hien
        //}
        public bool Login(string userName, string passWord)
        {
            //DataConfig con = new DataConfig();
            string query = "SELECT * FROM NGUOIDUNG WHERE taikhoanND = '" + userName + "' AND matkhauND = '" + passWord + "' ";
            DataTable result = new DataTable();
            result = base.GetData(query);

            return result.Rows.Count > 0;
        }
        public int Insert(NguoiDung obj)
        {
            SqlParameter[] para =
            {
               // new SqlParameter("MaND", obj.maND),
                new SqlParameter("TenND", obj.tenND),
                new SqlParameter("GioiTinhND", obj.gioiTinhND),
                new SqlParameter("NgaySinhND", obj.ngaySinhND),
                new SqlParameter("NgayLam", obj.ngayLam),
                new SqlParameter("MaVT", obj.maVT),
                new SqlParameter("TaiKhoan", obj.taiKhoan),
                new SqlParameter("MatKhau", obj.matKhau),
               // new SqlParameter("TrangThai", obj.trangThaiND),
                new SqlParameter("GhiChu", obj.ghiChu)

            };

            return base.ExcuteSQL("NGUOIDUNG_Insert", para);
        }

        public int Update(NguoiDung obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaND", obj.maND),
                new SqlParameter("TenND", obj.tenND),
                new SqlParameter("GioiTinhND", obj.gioiTinhND),
                new SqlParameter("NgaySinhND", obj.ngaySinhND),
                new SqlParameter("NgayLam", obj.ngayLam),
                new SqlParameter("MaVT", obj.maVT),
                new SqlParameter("TaiKhoan", obj.taiKhoan),
                new SqlParameter("MatKhau", obj.matKhau),
                //new SqlParameter("TrangThai", obj.trangThaiND),
                new SqlParameter("GhiChu", obj.ghiChu)
            };

            return base.ExcuteSQL("NGUOIDUNG_Update", para);
        }
        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaND",int.Parse( ID))
            };

            return base.ExcuteSQL("NGUOIDUNG_Delete", para);
        }
     
    }
}
