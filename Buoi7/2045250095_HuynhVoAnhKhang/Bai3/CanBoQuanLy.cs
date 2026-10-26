using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class CanBoQuanLy: CongTyABC
    {
        string chucVu;
        double heSoChucVu;
        public CanBoQuanLy(): base()
        {
            
        }

        public CanBoQuanLy(string ma, string ten, int namSinh, string gt, double luong, int namVaoLam, string cv, double hscv) : base(ma, ten, namSinh, gt, luong, namVaoLam)
        {
            chucVu = cv;
            heSoChucVu = hscv;
        }

        public override double Luong()
        {
            return heSoLuong * CongTyABC.LuongCoBan + PhuCapChucVu();
        }
        public double PhuCapChucVu()
        {
            return heSoChucVu * 1100000;
        }

        public override char XepLoai()
        {
            return 'A';
        }


        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Chức vụ: {chucVu}");
            Console.WriteLine($"Hệ số chức vụ: {heSoChucVu:F2}");
            Console.WriteLine($"Lương: {Luong():N0}");
            Console.WriteLine($"Xếp loại: {XepLoai()}");
        }
    }
}
