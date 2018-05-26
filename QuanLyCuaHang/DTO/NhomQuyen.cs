using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DTO
{
    public class NhomQuyen
    {
        private int MaVT;
        private string MaQ;

        public NhomQuyen() { }
        public NhomQuyen(int MaVT, string MaQ)
        {
            this.MaVT = MaVT;
            this.MaQ = MaQ;
        }
        //public NhomQuyen(DataRow row)
        //{
        //    this.MaVT = (string)row["maVT"];
        //    this.MaQ = (string)row["maQ"];

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
        public string maQ
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
    }
}
