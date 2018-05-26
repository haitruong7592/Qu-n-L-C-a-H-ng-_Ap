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
    public class VaiTroBUS
    {
        VaiTroDAL dal = new VaiTroDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }
        public DataTable GetDataID_TenVT()
        {
            return dal.GetDataID_TenVT();
        }

        public DataTable GetDataByID(string ID)
        {
            return dal.GetDataByID(ID);
        }
        public int Insert(VaiTro obj)
        {
            return dal.Insert(obj);
        }
        public int Update(VaiTro obj)
        {
            return dal.Update(obj);
        }
        public int Delete(string ID)
        {
            return dal.Delete(ID);
        }
    }
}
