using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class KhachHangCN : KhachHang
    {
        int khoagCach;
        public KhachHangCN(): base()
        {
            
        }
        public KhachHangCN(string ma, string ten, int sl, double gia, int kc) : base(ma, ten, sl, gia)
        {
            this.khoagCach = kc;
        }

        public override double ChietKhau()
        {
            double chietKhau = 0;
            if (sl < 5)
                chietKhau = 0;
            else
                chietKhau = sl * 0.03 * gia; 


            return (khoagCach < 10) ? chietKhau += 20000* sl : chietKhau;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Khoang cach: {khoagCach}");
            Console.WriteLine($"Chiet khau: {ChietKhau():N0}");
            Console.WriteLine($"Thanh tien: {ThanhTien():N0}");
        }
    }
}
