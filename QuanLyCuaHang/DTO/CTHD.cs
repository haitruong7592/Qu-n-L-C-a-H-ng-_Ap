using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class CTHD
    {
        private int MaCTHD;
        private int MaHD;
        private int MaMH;
        private int SoLuong;
        private double DonGia;
        public CTHD() { }
        public CTHD(int MaCTHD, int MaHD, int MaMH, int SoLuong, double DonGia)
        {
            this.MaCTHD = MaCTHD;
            this.MaHD = MaHD;
            this.MaMH = MaMH;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
        }
        //public CTHD(DataRow row)
        //{
        //    this.MaCTHD = (string)row["maCTHD"];
        //    this.MaHD = (string)row["maHD"];
        //    this.MaMH = (string)row["maMH"];
        //    this.SoLuong = (int)row["soluong"];
        //    this.DonGia = float.Parse(row["dongia"].ToString());

        //}
        public int maCTHD
        {
            get
            {
                return MaCTHD;
            }

            set
            {
                MaCTHD = value;
            }
        }
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
        public int maMH
        {
            get
            {
                return MaMH;
            }

            set
            {
                MaMH = value;
            }
        }
        public int soLuong
        {
            get
            {
                return SoLuong;
            }

            set
            {
                SoLuong = value;
            }
        }
        public double donGia
        {
            get
            {
                return DonGia;
            }

            set
            {
                DonGia = value;
            }
        }
    }
}
