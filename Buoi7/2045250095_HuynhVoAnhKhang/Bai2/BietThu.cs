using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class BietThu : CongTyABC, ITroGia
    {
        public BietThu(): base() { }
        public BietThu(string ma, double dai, double rong) : base(ma, dai, rong)
        {
        }

        public override double GiaBan()
        {
            return DienTich() * 400000;
        }

        public double hoTro()
        {
            return DienTich() * 1000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Giá bán: {GiaBan():N0}");
            Console.WriteLine($"Hỗ trợ: {hoTro():N0}");
        }
    }
}
