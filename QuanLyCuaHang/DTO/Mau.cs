using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Mau
    {
        private int MaMau;
        private string MauSP;
        public Mau() { }
        public Mau(int MaMau, string MauSP)
        {
            this.MaMau = MaMau;
            this.MauSP = MauSP;
        }
        //public Mau(DataRow row)
        //{
        //    this.MaMau = (string)row["maMau"];
        //    this.MauSP = (string)row["mau"];

        //}
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

        public string mauSP
        {
            get
            {
                return MauSP;
            }

            set
            {
                MauSP = value;

            }
        }
    }
}