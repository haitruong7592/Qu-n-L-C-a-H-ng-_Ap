using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class SanPham
    {
        private int MaSP;
        private string TenSP;
        private double DonGiaSP;
        private int MaLSP;
        private string HangSP; 
        public SanPham() { }
        public SanPham(int MaSP, string TenSP, double DonGiaSP, int MaLSP,  string HangSP)
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.DonGiaSP = DonGiaSP;
            this.MaLSP = MaLSP;
            this.HangSP = HangSP;
           
        }
        //public SanPham(DataRow row)
        //{
        //    this.MaSP = (string)row["maSP"];
        //    this.TenSP = (string)row["tenSP"];
        //    this.DonGiaSP = float.Parse(row["dongiaSP"].ToString());
        //    this.MaLSP = (string)row["maLSP"];
        //    this.HangSP = (string)row["hangSP"];
        //}
        public override string ToString()
        {
            return this.TenSP;
        }
        public int maSP
        {
            get
            {
                return MaSP;
            }

            set
            {
                MaSP = value;
            }
        }
        public string tenSP
        {
            get
            {
                return TenSP;
            }

            set
            {
                TenSP = value;
            }
        }
        public double donGiaSP
        {
            get
            {
                return DonGiaSP;
            }

            set
            {
                DonGiaSP = value;
            }
        }
        public int maLSP
        {
            get
            {
                return MaLSP;
            }

            set
            {
                MaLSP = value;
            }
        }
        public string hangSP
        {
            get
            {
                return HangSP;
            }

            set
            {
                HangSP = value;
            }
        }
    }
}
