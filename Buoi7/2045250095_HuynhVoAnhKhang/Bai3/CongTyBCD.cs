using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class CongTyBCD: CongTyT, IDanhHieu
    {
        double soTienThiDua;
        public double SoTienThiDua { get { return soTienThiDua; } set { soTienThiDua = value; } }
        public CongTyBCD(): base() 
        {
        }
        public CongTyBCD(string ma, string ten, double soTien):
            base(ma, ten)
        {
            soTienThiDua = soTien;
        }
        public override double Luong()
        {
            return 0.15 * SoTienThiDua;
        }
        public string XepLoaiDanhHieu()
        {
            if (Luong() > 20000)
                return "Chiến sĩ thi đua";
            else if (Luong() > 10000)
                return "Lao động tiên tiến";  
            else
                return "Không";
        }
        public string NangLucNhanVien()
        {
            string dh = XepLoaiDanhHieu();
            if (dh.Equals("Chiến sĩ thi đua", StringComparison.OrdinalIgnoreCase))
                return "Năng lực tốt";
            else if (dh.Equals("Lao động tiên tiến", StringComparison.OrdinalIgnoreCase))
                return "Có năng lực";
            else
                return "Không quan tâm";
        }
        public string TrangThaiXetThiDua()
        {
            return "Chưa xét";
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Số tiền thi đua: {soTienThiDua}");
            Console.WriteLine($"Lương: {Luong():N0}");
            Console.WriteLine($"Xét thi đua: Chưa xét thi đua");
            Console.WriteLine($"Xếp loại danh hiệu: {XepLoaiDanhHieu()}");
            Console.WriteLine($"Năng lực nhân viên: {NangLucNhanVien()}");
        }

        public void XuatChuaXet()
        {
            base.Xuat();
            Console.WriteLine($"Số tiền thi đua: {soTienThiDua:N0}");
            Console.WriteLine($"Lương: {Luong():N0}");
            Console.WriteLine($"Trạng thái xét thi đua: {TrangThaiXetThiDua()}");
            Console.WriteLine($"Danh hiệu: {XepLoaiDanhHieu()}");
            Console.WriteLine($"Năng lực nhân viên: {NangLucNhanVien()}");
        }
    }
}
