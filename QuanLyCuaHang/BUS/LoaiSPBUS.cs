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
    public class LoaiSPBUS
    {
        LoaiSPDAL dal = new LoaiSPDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }
        public DataTable GetDataID_TenLSP()
        {
            return dal.GetDataID_TenLSP();
        }
        public DataTable GetDataByID(string ID)
        {
            return dal.GetDataByID(ID);
        }
        public int Insert(LoaiSP obj)
        {
            return dal.Insert(obj);
        }

        //public int Delete(string MaLSP)
        //{
        //    int result = 0;
        //    result = base.excuteNoneQuery("LSP_Delete");
        //    return result; //tra ve so ghi nhan thuc hien
        //}
        public int Update(LoaiSP obj)
        {
            return dal.Update(obj);
        }
        public int Delete(string ID)
        {
            return dal.Delete(ID);
        }
    }
}
