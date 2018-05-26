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
    public class LoaiKhachHangBUS
    {
        LoaiKhachHangDAL dal = new LoaiKhachHangDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }
        public DataTable GetDataID_Ten()
        {
            return dal.GetDataID_Ten();
        }
        public DataTable GetDataByID(string ID)
        {
            return dal.GetDataByID(ID);
        }
        public int Insert(LoaiKhachHang obj)
        {
            return dal.Insert(obj);
        }
        public int Update(LoaiKhachHang obj)
        {
            return dal.Update(obj);
        }
        public int Delete(string ID)
        {
            return dal.Delete(ID);
        }
    }
}
