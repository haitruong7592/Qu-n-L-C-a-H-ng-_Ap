using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Quyen
    {
        private int MaQ;
        private string TenQ;
        public Quyen() { }
        public Quyen(int MaQ, string TenQ)
        {
            this.MaQ = MaQ;
            this.TenQ = TenQ;
        }
        //public Quyen(DataRow row)
        //{
        //    this.MaQ = (string)row["maQ"];
        //    this.TenQ = (string)row["ten Q"];

        //}
        public int maQ
        {
            get
            {
                return MaQ;
            }

            set
            {
                MaQ = value;
            }
        }
        public string tenQ
        {
            get
            {
                return TenQ;
            }

            set
            {
                TenQ = value;
            }
        }
    }
}
