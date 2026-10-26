using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class NhanVienSanXuat : CongTyABC
    {
        int soNgayNghi;
        public NhanVienSanXuat(): base()
        {
            
        }
        public NhanVienSanXuat(string ma, string ten, int namSinh, string gt, double luong, int namVaoLam, int ngay) 
            : base(ma, ten, namSinh, gt, luong, namVaoLam)
        {
            soNgayNghi = ngay;
        }

        public static double HeSoPhuCapNangNhoc = 0.1;
        public override double Luong()
        {
            return heSoLuong * CongTyABC.LuongCoBan * (1 + NhanVienSanXuat.HeSoPhuCapNangNhoc);
        }

        public override char XepLoai()
        {
            if (soNgayNghi <= 1)
                return 'A';
            else if (soNgayNghi <= 3)
                return 'B';
            else if (soNgayNghi <= 5)
                return 'C';
            else
                return 'D';
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Số ngày nghỉ: {soNgayNghi}");
            Console.WriteLine($"Lương: {Luong():N0}");
            Console.WriteLine($"Xếp loại: {XepLoai()}");
        }
    }
}
