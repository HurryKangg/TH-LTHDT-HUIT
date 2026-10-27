using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khách VIP
            var kh = new TaiKhoanKH("khach01", "123", "0901", true, "VIP");

            // Tài xế
            var tx1 = new XeGanMay("tx01", "123", "0902", true, "D01", "Nguyễn Văn A");
            var tx2 = new XeOto("tx02", "123", "0903", true, "D02", "Trần Văn B",7);
            var tx3 = new XeTaiOto("tx03", "123", "0904", true, "D03", "Lê Văn C",5);

            // Chuyến 1: xe máy, 23h đêm
            var cx1 = new ChuyenXe(tx1, kh, "100", "200", 10, 23, DateTime.Today);
            double tien1 = cx1.TinhThanhTien();
            tx1.ThemDoanhThu(tien1);
            cx1.Xuat();

            Console.WriteLine();

            // Chuyến 2: ô tô 4 chỗ
            var cx2 = new ChuyenXe(tx2, kh, "150", "250", 20, 10, DateTime.Today);
            double tien2 = cx2.TinhThanhTien();
            tx2.ThemDoanhThu(tien2);
            cx2.Xuat();

            Console.WriteLine();

            // Chuyến 3: xe tải 3.5 tấn
            var cx3 = new ChuyenXe(tx3, kh, "300", "400", 25, 9, DateTime.Today);
            double tien3 = cx3.TinhThanhTien();
            tx3.ThemDoanhThu(tien3);
            cx3.Xuat();

            // Tổng kết
            Console.WriteLine("\n===== TỔNG KẾT =====");
            Console.WriteLine($"{tx1.TenTX}: doanh thu = {tx1.DoanhThuTrongNgay:N0}, thưởng = 0");
            Console.WriteLine($"{tx2.TenTX}: doanh thu = {tx2.DoanhThuTrongNgay:N0}, thưởng = {tx2.TraPhiLaiChoCongTy():N0}");
            Console.WriteLine($"{tx3.TenTX}: doanh thu = {tx3.DoanhThuTrongNgay:N0}, thưởng = {tx3.TraPhiLaiChoCongTy():N0}");
        }
    }
}
