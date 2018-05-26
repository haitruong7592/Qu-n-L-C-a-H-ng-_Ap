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
    public class KhachHangBUS
    {
        KhachHangDAL dal = new KhachHangDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }
        public DataTable Search(string chuoi)
        {
            return dal.Search(chuoi);
        }
        public DataTable SearchuBySDT(string SDT)
        {
            return dal.SearchuBySDT(SDT);
        }
        public DataTable ThongKeTheoKhachHang(string Thang, string Nam)
        {
            return dal.ThongKeTheoKhachHang(Thang, Nam);
        }
        public DataTable GetDataByID(string ID)
        {
            return dal.GetDataByID(ID);
        }
        public int Insert(KhachHang obj)
        {
            return dal.Insert(obj);
        }
        public int Update(KhachHang obj)
        {
            return dal.Update(obj);
        }
        public int Delete(string ID)
        {
            return dal.Delete(ID);
        }
    }
}
