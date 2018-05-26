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
    public class QuyenBUS
    {
        QuyenDAL dal = new QuyenDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }

        public DataTable GetDataByID(string ID)
        {
            return dal.GetDataByID(ID);
        }
        public int Insert(Quyen obj)
        {
            return dal.Insert(obj);
        }
        public int Update(Quyen obj)
        {
            return dal.Update(obj);
        }
        public int Delete(string ID)
        {
            return dal.Delete(ID);
        }
    }
}
