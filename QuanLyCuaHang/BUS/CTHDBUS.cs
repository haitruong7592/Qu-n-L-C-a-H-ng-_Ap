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
    public class CTHDBUS
    {
        CTHDDAL dal = new CTHDDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }
        public DataTable GetDataLastID()
        {
            return dal.GetDataLastID();
        }
        public DataTable GetDataByID(string ID)
        {
            return dal.GetDataById(ID);
        }
        
        public int Insert(CTHD obj)
        {
            return dal.Insert(obj);
        }
        public int Update(CTHD obj)
        {
            return dal.Update(obj);
        }
        public int Delete(string ID)
        {
            return dal.Delete(ID);
        }

    }
}
