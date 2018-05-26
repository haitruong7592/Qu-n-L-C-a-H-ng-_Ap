using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class HoaDon
    {
        private int MaHD;
        private int MaND;
        private int MaKH;
        private DateTime NgayHD;
        private double TongTien;
        private string TrangThaiHD;
        public HoaDon() { }
        public HoaDon(int MaHD, int MaND, int MaKH, DateTime NgayHD, double TongTien, string TrangThaiHD)
        {
            
            this.MaHD = MaHD;
            this.MaND = MaND;
            this.MaKH = MaKH;
            this.NgayHD = NgayHD;
            this.TongTien = TongTien;
            this.TrangThaiHD = TrangThaiHD;
        }
        //public HoaDon(DataRow row)
        //{
        //    this.MaHD = (string)row["maHD"];
        //    this.MaND = (string)row["maND"];
        //    this.MaKH = (string)row["maKH"];
        //    this.NgayHD = (DateTime)row["ngayHD"];
        //    this.TongTien = float.Parse(row["tongtien"].ToString());
        //    this.TrangThaiHD = (string)row["trangthaiHD"];

        //}
        public int maHD
        {
            get
            {
                return MaHD;
            }

            set
            {
                MaHD = value;
            }
        }
        public int maND
        {
            get
            {
                return MaND;
            }

            set
            {
                MaND = value;
            }
        }
        public int maKH
        {
            get
            {
                return MaKH;
            }

            set
            {
                MaKH = value;
            }
        }
        public DateTime ngayHD
        {
            get
            {
                return NgayHD;
            }

            set
            {
                NgayHD = value;
            }
        }
        public double tongTien
        {
            get
            {
                return TongTien;
            }

            set
            {
                TongTien = value;
            }
        }
        public string trangThaiHD
        {
            get
            {
                return TrangThaiHD;
            }

            set
            {
                TrangThaiHD = value;
            }
        }
    }
}
