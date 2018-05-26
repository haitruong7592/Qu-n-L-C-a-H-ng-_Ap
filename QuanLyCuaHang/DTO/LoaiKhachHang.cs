using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class LoaiKhachHang
    {
        private int MaLKH;
        private string TenLKH;
        private string ChuanLKH;
        private string GhiChu;
        public LoaiKhachHang() { }
        public LoaiKhachHang(int MaLKH, string TenLKH, string ChuanLKH, string GhiChu)
        {
            this.MaLKH = MaLKH;
            this.TenLKH = TenLKH;
            this.ChuanLKH = ChuanLKH;
            this.GhiChu = GhiChu;
        }
        //public LoaiKhachHang(DataRow row)
        //{
        //    this.MaLKH = (string)row["maLKH"];
        //    this.TenLKH = (string)row["tenLKH"];
        //    this.ChuanLKH = (string)row["chuanLKH"];
        //    this.GhiChu = (string)row["ghichuKH"];

        //}
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
        public string tenLKH
        {
            get
            {
                return TenLKH;
            }

            set
            {
                TenLKH = value;
            }
        }
        public string chuanLKH
        {
            get
            {
                return ChuanLKH;
            }

            set
            {
                ChuanLKH = value;
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
