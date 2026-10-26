using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class NhaLau : CongTyABC
    {
        int soLau;
        public NhaLau(): base()
        {
            
        }

        public NhaLau(string ma, double dai, double rong, int lau) : base(ma, dai, rong)
        {
            this.soLau = lau;
        }

        public override double GiaBan()
        {
            return DienTich() * 10000 + soLau * 100000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Số lầu: {soLau}");
            Console.WriteLine($"Giá bán: {GiaBan():N0}");
        }
    }
}
