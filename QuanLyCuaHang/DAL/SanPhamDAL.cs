using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class SanPhamDAL:dbConnect
    {
        public DataTable GetData()
        {
            return base.GetData("SANPHAM_SelectAll", null);
        }



        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaSP", int.Parse(ID))
            };
            return base.GetData("SANPHAM_SelectByID", para);
        }
        public int Insert(SanPham obj)
        {
            SqlParameter[] para =
            {
                
                new SqlParameter("TenSP", obj.tenSP),
                new SqlParameter("DonGiaSP", obj.donGiaSP),
                new SqlParameter("MaLSP", obj.maLSP),
                new SqlParameter("HangSP", obj.hangSP)
            };

            return base.ExcuteSQL("SANPHAM_Insert", para);
        }
        public DataTable ThongKeSanPham(string Thang, string Nam)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Thang", int.Parse(Nam)),
                new SqlParameter("Nam", int.Parse(Thang))
            };

            return base.GetData("ThongKeTheoSanPham", para);
        }


        public int Update(SanPham obj)
        {

            SqlParameter[] para =
            {
                new SqlParameter("MaSP", obj.maSP),
                new SqlParameter("TenSP", obj.tenSP),
                new SqlParameter("DonGiaSP", obj.donGiaSP),
                new SqlParameter("MaLSP", obj.maLSP),
                new SqlParameter("HangSP", obj.hangSP)
            };

            return base.ExcuteSQL("SANPHAM_Update", para);
        }
        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaSP",int.Parse( ID))
            };

            return base.ExcuteSQL("SANPHAM_Delete", para);
        }
        public DataTable Search(string chuoi)
        {
            SqlParameter[] para =
           {
                new SqlParameter("CHUOI",chuoi)
            };

            //string strQ = "Select * From SanPham Where maSP like '%" + chuoi + "%' or tenSP like '%" + chuoi + "%'";
            return base.GetData("SANPHAM_SEARCH_TEN_MA", para);
        }

       
        //dbConnect config = new dbConnect();
        //public DataTable GetData() //lay du lieu
        //{
        //    DataTable result = new DataTable();
        //    //tao ket noi
        //    //string strQuery = "select * from SINHVIEN";// table SINHVIEN
        //    result = config.GetData("SANPHAM_SelectAll", null);// form load len thi thuc hien load data
        //    return result;
        //}

        ////public DataTable GetData()
        ////{
        ////    return base.GetData("SANPHAM_SelectAll", null);
        ////}



        //public DataTable GetDataByID(string ID)
        //{
        //    SqlParameter[] para =
        //    {
        //        new SqlParameter("MaSP", ID)
        //    };
        //    return config.GetData("SANPHAM_SelectByID", para);
        //}
        ////public int Insert(SanPham obj)
        ////{
        ////    SqlParameter[] para =
        ////    {
        ////        new SqlParameter("MaSP", obj.MaSP),
        ////        new SqlParameter("TenSP", obj.TenSP),
        ////        new SqlParameter("DonGiaSP", obj.DonGiaSP),
        ////        new SqlParameter("MaLSP", obj.MaLSP),
        ////        new SqlParameter("HangSP", obj.HangSP)
        ////    };

        //////ham tim kiem
        ////public DataTable TimKiem(string chuoi)
        ////{
        ////    DataTable result = new DataTable();
        ////    dbConnect config = new dbConnect();//tao ket noi
        ////    string strQuery = "select * from SINHVIEN Where MSSV like'%" + chuoi + "%' or HoTen like '%" + chuoi + "%'";   // tim kiem theo ten va ma
        ////    result = config.GetData(strQuery);// form load len thi thuc hien load data
        ////    return result;
        ////}
        ////them csdl
        //public int Insert(SanPham obj)
        //{
        //    int result = 0;
        //    //string strQuery = "insert into SINHVIEN (MSSV,HoTen,NgaySinh,Phai,Email,SDT,Khoa) values ('" + obj.MSSV + "',N'" + obj.HoTen + "','" + obj.NgaySinh + "',N'" + obj.Phai + "','" + obj.Email + "','" + obj.SDT + "',N'" + obj.Khoa + "')";
        //    dbConnect config = new dbConnect();
        //    result = config.excuteNoneQuery("SANPHAM_Insert");
        //    return result; //tra ve so ghi nhan thuc hien
        //}
        ////check ID
        //public bool CheckID(string MaSP)
        //{
        //    //  bool result = true;
        //    dbConnect config = new dbConnect();
        //    string strQuery = "select * from SANPHAM where maSP ='" + MaSP + "'";
        //    DataTable DT = new DataTable();
        //    DT = config.GetData(strQuery);
        //    if (DT.Rows.Count > 0)
        //        return true;
        //    return false;
        //}
        //public int Update(SanPham obj)
        //{
        //    int result = 0;
        //   // string strQuery = "update SINHVIEN set HoTen=N'" + obj.HoTen + "',NgaySinh='" + obj.NgaySinh + "',Phai=N'" + obj.Phai + "',Email='" + obj.Email + "',SDT='" + obj.SDT + "' where MSSV='" + obj.MSSV + "'";
        //    dbConnect config = new dbConnect();
        //    result = config.excuteNoneQuery("SANPHAM_Update");
        //    return result; //tra ve so ghi nhan thuc hien
        //}
        //// xoa
        //public int Delete(string MaSP)
        //{
        //    int result = 0;
        //    //string strQuery = "delete from SINHVIEN where MSSV='" + MaSP + "'";
        //    dbConnect config = new dbConnect();
        //    result = config.excuteNoneQuery("SANPHAM_Delete");
        //    return result; //tra ve so ghi nhan thuc hien
        //}

    }
}
