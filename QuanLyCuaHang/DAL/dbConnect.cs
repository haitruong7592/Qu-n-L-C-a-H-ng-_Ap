using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class dbConnect

    {
        private SqlConnection conn;
        public dbConnect()
        {
            conn = new SqlConnection(@"Data Source=.;Initial Catalog=QUANLYCUAHANG;Integrated Security=True");
           // @"Data Source=.;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        }

        public DataTable GetData(string strSQL)// select
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }


        public DataTable GetData(string procName, SqlParameter[] para)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (para != null)
                cmd.Parameters.AddRange(para);
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public int ExcuteSQL(string strSQL)
        {
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row;

        }

        public int ExcuteSQL(string procName, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            if (para != null)
                cmd.Parameters.AddRange(para);   //AddRange(para);
            int row;
            try
            {
                conn.Open();
                row = cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            return row;
        }


        //private SqlConnection con;
        //public String strConnect = @"Data Source=.;Initial Catalog=QUANLYCUAHANG;Integrated Security=True";
        ////@"Data Source=DESKTOP-J45K4LK;Integrated Security=SSPI;Initial Catalog=QuanLyDoAnNienLuan";

        ////Khoi tao mac dinh
        //public dbConnect()
        //{
        //    Connect();
        //}

        ////Ham ket noi CSDL
        //private void Connect()
        //{
        //    try
        //    {
        //        con = new SqlConnection(strConnect); // khoi tao connect
        //        con.Open(); // mo ket noi
        //        if (con.State == ConnectionState.Open)
        //        {
        //            con.Close(); //Dong ket noi
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi kết nối: " + ex.Message.ToString());
        //    }
        //}

        ////Ham getData
        //public DataTable GetData(String strSQL)
        //{
        //    DataTable result = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
        //    da.Fill(result);
        //    return result;
        //}
        //public DataTable GetData(string procName, SqlParameter[] para)
        //{
        //    DataTable dt = new DataTable();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = procName;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    if (para != null)
        //        cmd.Parameters.AddRange(para);
        //    cmd.Connection = con;
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    da.SelectCommand = cmd;
        //    con.Open();
        //    da.Fill(dt);
        //    con.Close();
        //    return dt;
        //}
        ////public DataTable GetData(string strSQL)// select
        ////{
        ////    DataTable dt = new DataTable();
        ////    SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
        ////    conn.Open();
        ////    da.Fill(dt);
        ////    conn.Close();
        ////    return dt;
        ////}

        ////public DataTable GetData(string procName, SqlParameter[] para)
        ////{
        ////    DataTable dt = new DataTable();
        ////    SqlCommand cmd = new SqlCommand();
        ////    cmd.CommandText = procName;
        ////    cmd.CommandType = CommandType.StoredProcedure;
        ////    if (para != null)
        ////        cmd.Parameters.AddRange(para);
        ////    cmd.Connection = conn;
        ////    SqlDataAdapter da = new SqlDataAdapter();
        ////    da.SelectCommand = cmd;
        ////    conn.Open();
        ////    da.Fill(dt);
        ////    conn.Close();
        ////    return dt;
        ////}
        ////Them,xoa,sua
        //public int excuteNoneQuery(String sql)
        //{
        //    int result = 0;
        //    if (con.State == ConnectionState.Closed)
        //    {
        //        con.Open();// Mo ket noi
        //    }
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = sql; //Cau lenh truy van
        //    result = cmd.ExecuteNonQuery();
        //    return result;
        //}
        ////Tra ve mot doi tuong nao do
        //public object exeCuteScalarQuery(String sql)
        //{
        //    object result = 0;
        //    if (con.State == ConnectionState.Closed)
        //    {
        //        con.Open();// Mo ket noi
        //    }
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = sql; //Cau lenh truy van
        //    result = cmd.ExecuteScalar();
        //    return result;
        //}

    }
}
