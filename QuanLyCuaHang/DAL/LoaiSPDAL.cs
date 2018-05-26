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
    public class LoaiSPDAL:dbConnect
    {

        public DataTable GetData()
        {
            return base.GetData("LSP_SelectAll", null);
        }
        public DataTable GetDataID_TenLSP()
        {
            return base.GetData("LSP_SelectID_Ten", null);
        }
        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLSP", int.Parse(ID))
            };
            return base.GetData("LSP_SelectByID", para);
        }
        //public int Insert(LoaiSP obj)
        //{
        //    int result = 0;
        //    string strQuery = "insert into SINHVIEN (MSSV,HoTen,NgaySinh,Phai,Email,SDT,Khoa) values ('" + obj.MSSV + "',N'" + obj.HoTen + "','" + obj.NgaySinh + "',N'" + obj.Phai + "','" + obj.Email + "','" + obj.SDT + "',N'" + obj.Khoa + "')";

        //    result = base.excuteNoneQuery("LSP_Insert");
        //    return result; //tra ve so ghi nhan thuc hien
        //}
        //check ID
        //public bool CheckID(string MaLSP)
        //{
        //    //  bool result = true;

        //    //string strQuery = "select * from SANPHAM where maSP ='" + MaSP + "'";
        //    DataTable DT = new DataTable();
        //    DT = base.GetData("LSP_SelectByID");
        //    if (DT.Rows.Count > 0)
        //        return true;
        //    return false;
        //}
        //public int Update(LoaiSP obj)
        //{
        //    int result = 0;
        //    // string strQuery = "update SINHVIEN set HoTen=N'" + obj.HoTen + "',NgaySinh='" + obj.NgaySinh + "',Phai=N'" + obj.Phai + "',Email='" + obj.Email + "',SDT='" + obj.SDT + "' where MSSV='" + obj.MSSV + "'";
        //    //dbConnect config = new dbConnect();
        //    result = base.excuteNoneQuery("LSP_Update");
        //    return result; //tra ve so ghi nhan thuc hien
        //}
        // xoa
        //public int Delete(string MaLSP)
        //{
        //    int result = 0;
        //    //string strQuery = "delete from SINHVIEN where MSSV='" + MaSP + "'";
        //    //dbConnect config = new dbConnect();
        //    result = base.excuteNoneQuery("LSP_Delete");
        //    return result; //tra ve so ghi nhan thuc hien
        //}
        public int Insert(LoaiSP obj)
        {
            SqlParameter[] para =
            {
                
                new SqlParameter("TenLSP", obj.tenLSP)

            };

            return base.ExcuteSQL("LSP_Insert", para);
        }

        
        public int Update(LoaiSP obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLSP", obj.maLSP),
                new SqlParameter("TenLSP", obj.tenLSP)
            };

            return base.ExcuteSQL("LSP_Update", para);
        }
        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLSP", int.Parse(ID))
            };

            return base.ExcuteSQL("LSP_Delete", para);
        }
    }
}
