using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class DaiLyCap1 : KhachHang
    {
        double thoiGianHopTac;
        public DaiLyCap1(): base()
        {
            
        }

        public DaiLyCap1(string ma, string ten, int sl, double gia, double tg) : base(ma, ten, sl, gia)
        {
            this.thoiGianHopTac = tg;
        }

        public override double ChietKhau()
        {
            double chietKhau = 0.3;
            if(thoiGianHopTac > 3)
            {
                chietKhau += thoiGianHopTac * 0.01;
                if (chietKhau > 0.35) chietKhau = 0.35;
            }
            return chietKhau * gia * sl; 
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Thoi gian hop tac: {thoiGianHopTac}");
            Console.WriteLine($"Chiet khau: {ChietKhau():N0}");
            Console.WriteLine($"Thanh tien: {ThanhTien():N0}");
        }
    }
}
