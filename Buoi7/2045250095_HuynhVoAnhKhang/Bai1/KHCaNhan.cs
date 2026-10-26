using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class KHCaNhan : CongTyABC, ITroGia
    {
        double kc;
        public KHCaNhan(): base()
        {
            
        }

        public KHCaNhan(string ma, string ten, int sl, double donGia, double kc) : base(ma, ten, sl, donGia)
        {
            this.kc = kc;
        }

        public override double ChietKhau()
        {
            double ck = 0;
            if (soLuong > 7)
                ck += 0.05 * donGia * soLuong;
            if ( kc < 10 )
                ck += 10000 * soLuong;
            return ck;                   
        }

        public double hoTro()
        {
            double troGia = 0;
            troGia = 0.02 * soLuong * donGia;
            return (soLuong > 2) ? troGia += 100000 : troGia; 
        }

        public override double ThanhTien()
        {
            return base.ThanhTien() - hoTro();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Khoang cach: {kc}");
            Console.WriteLine($"Ho tro: {hoTro():N0}");
            Console.WriteLine($"Thanh tien: {ThanhTien():N0}");
        }
    }
}
