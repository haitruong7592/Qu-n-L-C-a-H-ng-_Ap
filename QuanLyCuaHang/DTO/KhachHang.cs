using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class KhachHang
    {
        private int MaKH;
        private string TenKH;
        private string SDT;
        private string GioiTinh;
        private DateTime NgSinh;
        private string Email;
        private string DiaChi;
        private int MaLKH;
        private string GhiChu;
        public KhachHang() { }
        public KhachHang(int MaKH, string TenKH, string SDT, string GioiTinh, DateTime NgSinh, string Email, string DiaChi, int MaLKH, string GhiChu)
        {
            this.MaKH = MaKH;
            this.TenKH = TenKH;
            this.SDT = SDT;
            this.GioiTinh = GioiTinh;
            this.NgSinh = NgSinh;
            this.Email = Email;
            this.DiaChi = DiaChi;
            this.MaLKH = MaLKH;
            this.GhiChu = GhiChu;

        }
        //public KhachHang(DataRow row)
        //{
        //    this.MaKH = (string)row["maKH"];
        //    this.TenKH = (string)row["tenKH"];
        //    this.SDT = (string)row["sdtKH"];
        //    this.GioiTinh = (string)row["phaiKH"];
        //    this.NgSinh = (DateTime)row["ngsinhKH"];
        //    this.Email = (string)row["emailKH"];
        //    this.DiaChi = (string)row["diachiKH"];
        //    this.MaLKH = (string)row["maLKH"];
        //    this.GhiChu = (string)row["ghichuKH"];
        //}
        public override string ToString()
        {
            return this.TenKH;
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
        public string tenKH
        {
            get
            {
                return TenKH;
            }

            set
            {
                TenKH = value;
            }
        }
        public string sDT
        {
            get
            {
                return SDT;
            }

            set
            {
                SDT = value;
            }
        }
        public string gioiTinh
        {
            get
            {
                return GioiTinh;
            }

            set
            {
                GioiTinh = value;
            }
        }
        public DateTime ngSinh
        {
            get
            {
                return NgSinh;
            }

            set
            {
                NgSinh = value;
            }
        }
        public string email
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }
        public string diaChi
        {
            get
            {
                return DiaChi;
            }

            set
            {
                DiaChi = value;
            }
        }
        public int maLKH
        {
            get
            {
                return MaLKH;
            }

            set
            {
                MaLKH = value;
            }
        }
        public string ghiChu
        {
            get
            {
                return GhiChu;
            }

            set
            {
                GhiChu = value;
            }
        }
    }
}
