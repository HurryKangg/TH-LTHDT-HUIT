using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class CanBoQuanLy : NhanVienABC
    {
        string chucVu;
        double heSoChucVu;
        public string ChucVu { get { return chucVu; } set {  chucVu = value; } }
        public double HeSoChucVu { get { return heSoChucVu; } set {  heSoChucVu = value; } }

        public CanBoQuanLy() : base() { }
        public CanBoQuanLy(string ma, string ten, int namSinh, string gt, double he, int namVL, string ChucVu, double heSo) : base(ma, ten, namSinh, gt, he, namVL)
        {
            ChucVu = chucVu;
            HeSoChucVu = heSo;
        }
        public override double Luong()
        {
            return heSoLuong * NhanVienABC.LuongCoBan + PhuCapChucVu();
        }

        public double PhuCapChucVu()
        {
            return heSoChucVu * 1350;
        }

        public override char XepLoai()
        {
            return 'A';
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Chuc vu: {chucVu}");
            Console.WriteLine($"He so chuc vu: {heSoChucVu}");
            Console.WriteLine($"Xep loai: {XepLoai()}");
            Console.WriteLine($"Luong: {Luong():N0}");
        }
    }
}
