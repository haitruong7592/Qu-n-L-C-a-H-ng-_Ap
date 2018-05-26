using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Size
    {
        private int MaSize;
        private string SizeSP; 
        public Size() { }
        public Size(int MaSize, string SizeSP)
        {
            this.MaSize = MaSize;
            this.SizeSP = SizeSP;
        }
        //public Size(DataRow row)
        //{
        //    this.MaSize = (string)row["maSize"];
        //    this.SizeSP = (string)row["size"];

        //}
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
        public string sizeSP
        {
            get
            {
                return SizeSP;
            }

            set
            {
                SizeSP = value;
            }
        }
    }
}
