using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class NhanVienKinhDoanh: CongTyABC
    {
        double doanhSoBanHangToiThieu;
        double doanhSoBanHangTheoThang;
        public static double HoaHong = 0.15;
        public NhanVienKinhDoanh(): base()
        {
            
        }
        public NhanVienKinhDoanh(string ma, string ten, int namSinh, string gt, double luong, int namVaoLam, double toiThieu, double kinhDoanh) 
            : base(ma, ten, namSinh, gt, luong, namVaoLam)
        {
            doanhSoBanHangToiThieu = toiThieu;
            doanhSoBanHangTheoThang = kinhDoanh;
        }

        public override double Luong()
        {
            double doanhThu = 0;
            double doanhSoVuotMuc = Math.Max(doanhSoBanHangTheoThang - doanhSoBanHangToiThieu, 0);
            doanhThu = doanhSoVuotMuc * 500;
            return heSoLuong * CongTyABC.LuongCoBan + (NhanVienKinhDoanh.HoaHong * doanhThu);
        }

        public override char XepLoai()
        {
            if (doanhSoBanHangTheoThang > 2 * doanhSoBanHangToiThieu)
                return 'A';
            else if (doanhSoBanHangTheoThang < 0.5 * doanhSoBanHangToiThieu)
                return 'D';
            else if (doanhSoBanHangTheoThang >= doanhSoBanHangToiThieu)
                return 'B';
            else
                return 'C';
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Doanh số bán tối thiểu: {doanhSoBanHangToiThieu}");
            Console.WriteLine($"Doanh số bán theo thang: {doanhSoBanHangTheoThang}");
            Console.WriteLine($"Lương: {Luong():N0}");
            Console.WriteLine($"Xếp loại: {XepLoai()}");
        }
    }
}
