using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class DaiLyCap1 : CongTyABC
    {
        int soNamHT;
        public DaiLyCap1(): base()
        {
            
        }

        public DaiLyCap1(string ma, string ten, int sl, double don, int nam):
            base(ma, ten, sl, don)
        {
            this.soNamHT = nam;
        }
        public override double ChietKhau()
        {
            double ck = 0.3;
            if (soNamHT > 3)
                ck = ck + 0.01 * soNamHT;
            if (ck > 0.35)
                ck = 0.35;
            return ck * soLuong * donGia;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"So nam hien tai: {soNamHT}");
        }
    }
}
