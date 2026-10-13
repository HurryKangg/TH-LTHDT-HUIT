using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class KhachHangCT : KhachHang
    {
        int slNV;
        public KhachHangCT(): base()
        {
            
        }

        public KhachHangCT(string ma,string ten, int sl, double gia, int slNV):
            base(ma, ten, sl, gia)
        {
            this.slNV = slNV;
        }
        public override double ChietKhau()
        {
            double chietKhau = 0;
            if (slNV > 5000)
                chietKhau = 0.05;
            else if (slNV > 1000)
                chietKhau = 0.03;
            return chietKhau * sl * gia;

        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"So luong nhan vien: {slNV}");
            Console.WriteLine($"Chiet khau: {ChietKhau():N0}");
            Console.WriteLine($"Thanh tien: {ThanhTien():N0}");

        }
    }
}
