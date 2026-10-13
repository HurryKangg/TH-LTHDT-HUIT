using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class NhanVienSX : NhanVienABC
    {
        int soNgayNghi;
        static double HeSoPhuCapNangNhoc = 0.1;
        public int SoNgayNghi { get { return soNgayNghi; } set { soNgayNghi = value; } }
        public NhanVienSX():base(){}
        public NhanVienSX(string ma, string ten, int namSinh, string gt, double he, int namVL, int soNgayNghi) : base(ma, ten, namSinh, gt, he, namVL)
        {
            SoNgayNghi = soNgayNghi;
        }

        public override double Luong()
        {
            return heSoLuong * NhanVienABC.LuongCoBan * (1 + NhanVienSX.HeSoPhuCapNangNhoc);
        }

        public override char XepLoai()
        {
            if (soNgayNghi <= 1) return 'A';
            else if (soNgayNghi > 1 && soNgayNghi <= 3) return 'B';
            else if (soNgayNghi > 4 && soNgayNghi <= 5) return 'C';
            else return 'D';
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"So ngay nghi: {soNgayNghi}");
            Console.WriteLine($"Xep loai: {XepLoai()}");
            Console.WriteLine($"Luong: {Luong():N0}");
        }
    }
}
