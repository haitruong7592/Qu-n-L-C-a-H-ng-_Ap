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
    public class HoaDonBUS
    {
        HoaDonDAL dal = new HoaDonDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }

        public DataTable GetDataByID(string ID)
        {
            return dal.GetDataByID(ID);
        }
        public DataTable GetDataDistanceTime(DateTime TuNgay, DateTime DenNgay)
        {
            return dal.GetDataDistanceTime(TuNgay, DenNgay);
        }
        public DataTable GetDataDistanceTime_TenKH(DateTime TuNgay, DateTime DenNgay, string TenKH)
        {
            return dal.GetDataDistanceTime_TenKH(TuNgay, DenNgay, TenKH);
        }

        public DataTable GetDataByTenKH(string TenKH)
        {
            return dal.GetDataByTenKH(TenKH);
        }

        public int Insert(HoaDon obj)
        {
            return dal.Insert(obj);
        }
        public int Update(HoaDon obj)
        {
            return dal.Update(obj);
        }
        public int Delete(string ID)
        {
            return dal.Delete(ID);
        }
    }
}
