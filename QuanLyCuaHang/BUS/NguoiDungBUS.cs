using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BUS
{
    public class NguoiDungBUS
    {
        NguoiDungDAL dal = new NguoiDungDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }
        public DataTable GetDataNguoiDung()
        {
            return dal.GetDataNguoiDung();
        }
        public DataTable GetDataByID(string ID)
        {
            return dal.GetDataByID(ID);
        }
        public DataTable GetDataID_Ten()
        {
            return dal.GetDataID_Ten();
        }
        public int Insert(NguoiDung obj)
        {
            return dal.Insert(obj);
        }
        //public bool CheckID(string MaND)
        //{
        //    return dal.CheckID(MaND);
        //}
        public int Update(NguoiDung obj)
        {
            return dal.Update(obj);
        }
        public int Delete(string ID)
        {
            return dal.Delete(ID);
        }
        public bool Login(string userName, string passWord)
        {
            return dal.Login(userName, passWord);
        }
      

    }
}
