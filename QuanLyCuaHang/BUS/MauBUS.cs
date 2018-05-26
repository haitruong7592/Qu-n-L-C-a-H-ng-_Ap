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
    public class MauBUS
    {
        MauDAL dal = new MauDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }

        public DataTable GetDataByID(string ID)
        {
            return dal.GetDataByID(ID);
        }
        public DataTable GetDataByID_TenMau()
        {
            return dal.GetDataByID_TenMau();
        }
        public int Insert(Mau obj)
        {
            return dal.Insert(obj);
        }
        public int Update(Mau obj)
        {
            return dal.Update(obj);
        }
        public int Delete(string ID)
        {
            return dal.Delete(ID);
        }
    }
}
