using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class HangHoa
    {
        protected string maHH;
        protected string tenHH;
        protected double donGia;

        public string MaHH
        {
            get { return maHH; }
            set { maHH = value; }
        }

        public string TenHH
        {
            get { return tenHH; }
            set { tenHH = value; }
        }

        public double DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public HangHoa()
        {
            MaHH = "MH000";
            TenHH = "No Name";
            DonGia = 0;
        }

        public HangHoa(string ma, string ten, double gia)
        {
            this.maHH = ma;
            this.tenHH = ten;
            this.donGia = gia;
        }
                                              
    }
}
