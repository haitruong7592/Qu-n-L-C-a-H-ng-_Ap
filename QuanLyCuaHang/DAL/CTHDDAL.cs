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
    public class CTHDDAL:dbConnect
    {
        
        public DataTable GetData()
        {
            return base.GetData("CTHD_SelectAll", null);
        }

        public DataTable GetDataLastID()
        {
            return base.GetData("HOADON_SelectLastID", null);
        }
        public DataTable GetDataById(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaCTHD", int.Parse(id))
            };
            return base.GetData("CTHD_SelectByID", para);
        }
        public int Insert(CTHD obj)
        {
            SqlParameter[] para =
            {
               
                new SqlParameter("MaHD", obj.maHD),
                new SqlParameter("MaMH", obj.maMH),
                new SqlParameter("SoLuong", obj.soLuong),
                new SqlParameter("DonGia", obj.donGia)
            };

            return base.ExcuteSQL("CTHD_Insert", para);
        }

        public int Update(CTHD obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaCTHD", obj.maCTHD),
                new SqlParameter("MaHD", obj.maHD),
                new SqlParameter("MaMH", obj.maMH),
                new SqlParameter("SoLuong", obj.soLuong),
                new SqlParameter("DonGia", obj.donGia)
            };

            return base.ExcuteSQL("CTHD_Update", para);
        }
        public int Delete(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaCTHD", int.Parse(id))
            };

            return base.ExcuteSQL("CTHD_Delect", para);
        }

        //private static CTHDDAL instance;

        //public static CTHDDAL Instance
        //{
        //    get
        //    {
        //        if (instance == null) instance = new CTHDDAL();
        //        return instance;
        //    }

        //    private set
        //    {
        //        instance = value;
        //    }
        //}
        //private CTHDDAL() { }

        // lấy tất cả danh sách sản phẩm

        //public List<CTHD> LayTatCaCTHD()
        //{
        //    List<CTHD> result = new List<CTHD>();
        //    string query = "CTHD_SelectAll";
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    foreach (DataRow item in data.Rows)
        //    {
        //        result.Add(new CTHD(item));
        //    }
        //    return result;
        //}

        /// lấy theo mã sản phẩm

        //public CTHD LayTheoMaCTHD(string MaSP)
        //{
        //    CTHD result = new CTHD();
        //    string query = "CTHD_SelectByID @MaSP";
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaSP });
        //    foreach (DataRow item in data.Rows)
        //    {
        //        result = new CTHD(item);
        //    }
        //    return result;
        //}

        // Cập nhật sản phâm
        //public bool CapNhatThongTinCTHD(string MaSP, string TenSP, double DonGiaSP, string MaLSP, string HangSP)
        //{
        //    string query = "CTHD_Update @MaSP ,@TenSP ,@DonGiaSP ,@MaLSP , @HangSP ";
        //    return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaSP, TenSP, DonGiaSP, MaLSP, HangSP }) > 0;
        //}
        // Thêm Sản Phẩm
        //public bool ThemCTHD(string MaSP, string TenSP, double DonGiaSP, string MaLSP, string HangSP)
        //{
        //    string query = "CTHD_Insert @MaSP ,@TenSP ,@DonGiaSP ,@MaLSP , @HangSP";
        //    return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaSP, TenSP, DonGiaSP, MaLSP, HangSP }) > 0;
        //}

        //Xoá Sản Phẩm
        //public bool XoaCTHD(string MaSP)
        //{
        //    string query = "CTHD_Delete @MaSP";
        //    return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaSP }) > 0;
        //}

        //public bool isTonTaiCTHD(string MaSP)
        //{
        //    string query = "IsTonTaiCTHD @MaSP";
        //    return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { MaSP }) > 0;
        //}
    }
}
