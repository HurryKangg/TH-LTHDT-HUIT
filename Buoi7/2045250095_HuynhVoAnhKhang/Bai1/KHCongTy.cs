using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class KHCongTy : CongTyABC, ITroGia
    {
        int slNV;
        public KHCongTy(): base()
        {
            
        }
        public KHCongTy(string ma, string ten, int sl, double don, int slNV):
            base(ma,ten,sl,don)
        {
            this.slNV = slNV;
        }
        public override double ChietKhau()
        {
            if (slNV > 500)
                return soLuong * donGia * 0.05;
            else if (slNV > 100)
                return soLuong * donGia * 0.03;
            return 0;
        }

        public double hoTro()
        {
            return soLuong * 120000;
        }

        public override double ThanhTien()
        {
            return base.ThanhTien() - hoTro();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"So luong nhan vien: {slNV}");
            Console.WriteLine($"Ho tro: {hoTro():N0}");
        }
    }
}
