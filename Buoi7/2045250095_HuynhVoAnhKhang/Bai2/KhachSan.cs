using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class KhachSan: CongTyABC, ITroGia
    {
        int soSao;
        public KhachSan(): base()
        {
            
        }
        public KhachSan(string ma, double dai, double rong, int sao) : base(ma, dai, rong)
        {
            this.soSao = sao;
        }

        public override double GiaBan()
        {
            return 100000 + soSao * 50000;
        }
        public double hoTro()
        {
            return ChieuRong * 5000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Số sao: {soSao}");
            Console.WriteLine($"Giá bán: {GiaBan():N0}");
            Console.WriteLine($"Hỗ trợ: {hoTro():N0}");
        }
    }
}
