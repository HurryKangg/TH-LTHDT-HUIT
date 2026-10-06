using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class HinhTron
    {
        private double banKinh;
        public double BanKinh
        {
            get { return banKinh; }
            set
            {
                if (value >= 0)
                    banKinh = value;
            }
        }
        public HinhTron()
        {
            BanKinh = 0;
        }
        public HinhTron(double banKinh)
        {
            this.BanKinh = banKinh;
        }
        public double ChuVi()
        {
            return 2 * Math.PI * this.BanKinh;
        }
        public double DienTich()
        {
            return Math.PI * Math.Pow(this.BanKinh, 2);
        }
        public double KTNhap(string tb)
        {
            while (true)
            {
                Console.Write(tb);
                if(double.TryParse(Console.ReadLine(), out double r) && r >=0 )
                {
                    return r;
                }
                Console.WriteLine("Vui lòng nhập lại bán kính: bán kính phải dương!!!");
            }
        }
        public void Nhap()
        {
            BanKinh = KTNhap("Nhập bán kính: ");
        }
        public void Xuat()
        {
            Console.WriteLine($"R = {this.banKinh}");
            Console.WriteLine($"Chu vi hình tròn: {ChuVi():0.00}");
            Console.WriteLine($"Diện tích hình tròn: {DienTich():0.00}");
        }
    }
}
