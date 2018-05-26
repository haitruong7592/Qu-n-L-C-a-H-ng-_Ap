using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamDAL dal = new SanPhamDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }

        public DataTable GetDataByID(string ID)
        {
            return dal.GetDataByID(ID);
        }
        public DataTable ThongKeSanPham(string Thang, string Nam)
        {
            return dal.ThongKeSanPham(Thang, Nam);
        }
        public int Insert(SanPham obj)
        {
            return dal.Insert(obj);
        }
 
        public int Update(SanPham obj)
        {
            return dal.Update(obj);
        }
        public int Delete(string ID)
        {
            return dal.Delete(ID);
        }
        public DataTable Search(string chuoi)
        {
            return dal.Search(chuoi);
        }
       

    }
}
