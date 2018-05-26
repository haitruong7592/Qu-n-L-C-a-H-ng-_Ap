using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Kho
    {
        private int MaMH;
        private int MaSP;
        private int MaSize;
        private int MaMau;
        private int SoLuong;
        public Kho() { }
        public Kho(int MaMH, int MaSP, int MaSize, int MaMau, int SoLuong)
        {

            this.MaMH = MaMH;
            this.MaSP = MaSP;
            this.MaSize = MaSize;
            this.SoLuong = SoLuong;
        }
        //public Kho(DataRow row)
        //{
        //    this.MaMH = (string)row["maMH"];
        //    this.MaSP = (string)row["maSP"];
        //    this.MaSize = (string)row["maKH"];
        //    this.MaMau = (string)row["maMau"];
        //    this.SoLuong = (int)row["slSP"];

        //}
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
        public int maSize
        {
            get
            {
                return MaSize;
            }

            set
            {
                MaSize = value;
            }
        }
        public int maMau
        {
            get
            {
                return MaMau;
            }

            set
            {
                MaMau = value;
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
    }
}
