using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class ctbh
    {

        public static double VAT = 0.1;

        protected string masp;
        protected string tensp;
        protected double gia;
        protected int sl;

        public string MaSP
        {
            get { return masp; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 6 && value.StartsWith("SP"))
                    masp = value;
                else
                    masp = "SP000";
            }
        }

        public string TenSP
        {
            get { return tensp; }
            set { tensp = value; }
        }
        public double Gia
        {
            get { return gia; }
            set
            {
                if(value >= 0)
                    gia = value;
                else 
                    gia = 0;
            }
        }

        public int Sl
        {
            get { return sl; }
            set
            {
                if(value >=0 )
                    sl = value;
                else
                    sl = 0;
            }
        }

        public ctbh()
        {
            MaSP = "SP0010";
            TenSP = "May tinh Dell";
            Gia = 15000;
            Sl = 2;
        }

        public ctbh(string ma, string ten, double gia, int sl)
        {
            this.MaSP = ma;
            this.TenSP = ten;
            this.Gia = gia;
            this.Sl = sl;
        }

        public double ThanhTien()
        {
            return sl * gia * (1 + ctbh.VAT);
        }

        public void Xuat()
        {
            Console.WriteLine($"{masp,-10} {tensp,-25} {gia,-12:N0} {sl,-12} {ThanhTien(), -12}");
        }

    }
}
