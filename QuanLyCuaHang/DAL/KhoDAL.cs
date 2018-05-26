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
    public class KhoDAL:dbConnect
    {
        public DataTable GetData()
        {
            return base.GetData("KHO_SelectAll", null);
        }

        public DataTable GetDataID_TenSP()
        {
            return base.GetData("KHO_SelectID_TenSP", null);
        }

        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaMH", int.Parse(ID))
            };
            return base.GetData("KHO_SelectByID", para);
        }
        public DataTable GetDataThemMH(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaMH", int.Parse(ID))
            };
            return base.GetData("ThemMatHang", para);
        }

        public DataTable ThongKeTheoMatHang_SP(string MaSP, string Thang, string Nam)
        {
            SqlParameter[] para =
            {
                new SqlParameter("v_maSP", int.Parse(MaSP)),
                new SqlParameter("v_nam", int.Parse(Nam)),
                new SqlParameter("v_thang", int.Parse(Thang)),
            };
            return base.GetData("thongke_mathang_sp", para);
        }
        public DataTable GetDataLastID()
        {
            return base.GetData("SANPHAM_SelectLastID",null);
        }
        public int Insert(Kho obj)
        {
            //obj.maSP = ExcuteSQL("SANPHAM_SelectLastID");
            SqlParameter[] para =
            {
               
                new SqlParameter("MaSP", obj.maSP),
                new SqlParameter("MaSize", obj.maSize),
                new SqlParameter("MaMau", obj.maMau),
                new SqlParameter("SLSP", obj.soLuong)

            };

            return base.ExcuteSQL("KHO_Insert", para);
        }

        public int UpdateSoLuong(string MaMH, string SoLuong)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaMH", int.Parse(MaMH)),
                new SqlParameter("SoLuong", double.Parse(SoLuong))
            };
            return base.ExcuteSQL("KHO_UpdateSoLuong", para);
        }
        public int Update(Kho obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaMH", obj.maMH),
                new SqlParameter("MaSP", obj.maSP),
                new SqlParameter("MaSize", obj.maSize),
                new SqlParameter("MaMau", obj.maMau),
                new SqlParameter("SLSP", obj.soLuong)
            };

            return base.ExcuteSQL("KHO_Update", para);
        }
        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaMH", int.Parse(ID))
            };

            return base.ExcuteSQL("KHO_Delete", para);
        }
    }
}
