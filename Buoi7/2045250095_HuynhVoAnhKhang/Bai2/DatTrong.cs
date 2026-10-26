using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class DatTrong : CongTyABC
    {
        public DatTrong(): base() { }
        public DatTrong(string ma, double dai, double rong) 
            : base(ma, dai, rong)
        {
        }

        public override double GiaBan()
        {
            return DienTich() * 10000;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Giá bán: {GiaBan():N0}");
        }
    }
}
