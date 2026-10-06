using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    public class HinhChuNhat
    {
        private double cd;
        private double cr;

        public double Cd
        {
            get { return cd; }
            set
            {
                if(value > 0)
                    cd = value;
            }
        }
        public double Cr
        {
            get { return cr; }
            set
            {
                if (value > 0) cr = value;
            }
        }
        public HinhChuNhat()
        {
            Cd = 0;
            Cr = 0;
        }
        public HinhChuNhat(double cd, double cr)
        {
            this.Cd = cd;
            this.Cr = cr;
        }
        public HinhChuNhat(HinhChuNhat obj)
        {
            this.Cd = obj.Cd;
            this.Cr = obj.Cr;
        }
        public void ChangeSize(int tx, int ty, int kieu)
        {
            if(kieu == 1)
            {
                cd += tx;
                cr += ty;
            }
            else
            {
                cd -= tx;
                cr -= ty;
            }
        }
        public void ChangeSize(HinhChuNhat a, int kieu)
        {
            if(kieu == 1)
            {
                cd += a.Cd;
                cr += a.Cr;
            }
            else
            {
                cd -= a.Cd;
                cr -= a.Cr;
            }
        }
        public double tinhChuVi()
        {
            return (cd + cr) * 2;
        }
        public double tinhDienTich()
        {
            return cd * cr;
        }
        public double tinhDuongCheo()
        {
            return Math.Sqrt(cd * cd + cr * cr);
        }
        public void xuat()
        {
            Console.WriteLine("Chieu dai: " + cd);
            Console.WriteLine("Chieu rong: " + cr);
            Console.WriteLine("Chu vi: " + tinhChuVi());
            Console.WriteLine("Dien tich: " + tinhDienTich());
            Console.WriteLine("Duong cheo: " + tinhDuongCheo());
        }
        public void nhap()
        {
            Console.Write("Nhap chieu dai: ");
            Cd = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            Cr = double.Parse(Console.ReadLine());
        }

    }
}
