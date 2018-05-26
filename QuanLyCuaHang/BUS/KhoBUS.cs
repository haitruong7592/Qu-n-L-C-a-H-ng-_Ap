using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class KhoBUS
    {
        KhoDAL dal = new KhoDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }
        public DataTable GetDataThemMH(string ID)
        {
            return dal.GetDataThemMH(ID);
        }
        public int UpdateSoLuong(string MaMH, string SoLuong)
        {
            return dal.UpdateSoLuong(MaMH, SoLuong);
        }
        public DataTable GetDataID_TenSP()
        {
            return dal.GetDataID_TenSP();
        }
        public DataTable ThongKeTheoMatHang_SP(string MaSP, string Thang, string Nam)
        {
            return dal.ThongKeTheoMatHang_SP(MaSP, Thang, Nam);
        }
        public DataTable GetDataLastID()
        {
            return dal.GetDataLastID();
        }
        public DataTable GetDataByID(string ID)
        {
            return dal.GetDataByID(ID);
        }
        public int Insert(Kho obj)
        {
            return dal.Insert(obj);
        }
        public int Update(Kho obj)
        {
            return dal.Update(obj);
        }
        public int Delete(string ID)
        {
            return dal.Delete(ID);
        }
    }
}
