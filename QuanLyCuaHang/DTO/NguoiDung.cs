using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class NguoiDung
    {
        private int MaND;
        private string TenND;
        private string GioiTinhND;
        private DateTime NgaySinhND;
        private DateTime NgayLam;
        private int MaVT;
        private string TaiKhoan;
        private string MatKhau;
        private int TrangThaiND;
        private string GhiChu;

        public NguoiDung() { }
        public NguoiDung(int MaND, string TenND, string GioiTinhND, DateTime NgaySinhND, DateTime NgayLam, int MaVT, string TaiKhoan, string MatKhau, int TrangThaiND, string GhiChu)
        {
            this.MaND = MaND;
            this.TenND = TenND;
            this.GioiTinhND = GioiTinhND;
            this.NgaySinhND = NgaySinhND;
            this.NgayLam = NgayLam;
            this.MaVT = MaVT;
            this.TaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
            this.TrangThaiND = TrangThaiND;
            this.GhiChu = GhiChu;

        }
        //public NguoiDung(DataRow row)
        //{
        //    this.MaND = (string)row["maND"];
        //    this.TenND = (string)row["tenND"];
        //    this.GioiTinhND = (string)row["gioitinhND"];
        //    this.NgaySinhND = (DateTime)row["ngaysinhND"];
        //    this.NgayLam = (DateTime)row["ngaylam"];
        //    this.MaVT = (string)row["maVT"];
        //    this.TaiKhoan = (string)row["taikhoanND"];
        //    this.MatKhau = (string)row["matkhauND"];
        //    this.TrangThaiND = (int)row["trangthaiND"];
        //    this.GhiChu = (string)row["ghichuND"];
        //}
        public override string ToString()
        {
            return this.TenND;
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
        public string tenND
        {
            get
            {
                return TenND;
            }

            set
            {
                TenND = value;
            }
        }
        public string gioiTinhND
        {
            get
            {
                return GioiTinhND;
            }

            set
            {
                GioiTinhND = value;
            }
        }
        public DateTime ngaySinhND
        {
            get
            {
                return NgaySinhND;
            }

            set
            {
                NgaySinhND = value;
            }
        }
        public DateTime ngayLam
        {
            get
            {
                return NgayLam;
            }

            set
            {
                NgayLam = value;
            }
        }
        public int maVT
        {
            get
            {
                return MaVT;
            }

            set
            {
                MaVT = value;
            }
        }
        public string taiKhoan
        {
            get
            {
                return TaiKhoan;
            }

            set
            {
                TaiKhoan = value;
            }
        }
        public string matKhau
        {
            get
            {
                return MatKhau;
            }

            set
            {
                MatKhau = value;
            }
        }
        public int trangThaiND
        {
            get
            {
                return TrangThaiND;
            }

            set
            {
                TrangThaiND = value;
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
