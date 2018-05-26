using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class VaiTro
    {
        private int MaVT;
        private string TenVT; 
        public VaiTro() { }
        public VaiTro(int MaVT, string TenVT)
        {
            this.MaVT = MaVT;
            this.TenVT = TenVT;
        }
        //public VaiTro(DataRow row)
        //{
        //    this.MaVT = (string)row["maVT"];
        //    this.TenVT = (string)row["tenVT"];

        //}
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
        public string tenVT
        {
            get
            {
                return TenVT;
            }

            set
            {
                TenVT = value;
            }
        }
    }
}
