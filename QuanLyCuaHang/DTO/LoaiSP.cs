using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class LoaiSP
    {
        private int MaLSP;
        private string TenLSP;
        public LoaiSP() { }
        public LoaiSP(int MaLSP, string TenLSP)
        {
            this.MaLSP = MaLSP;
            this.TenLSP = TenLSP;
        }
        //public LoaiSP(DataRow row)
        //{
        //    this.MaLSP = (string)row["maLSP"];
        //    this.TenLSP = (string)row["tenLSP"];

        //}
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

        public string tenLSP
        {
            get
            {
                return TenLSP;
            }

            set
            {
                TenLSP = value;

            }
        }
    }
}