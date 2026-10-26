using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class KhachHangVIP: HoaDon, ILaiSuat
    {
        public KhachHangVIP()
        {
            
        }

        public KhachHangVIP(string ma, string ten, DateTime ngay, int sl, HangHoa mh) :
            base(ma, ten, ngay, sl, mh)
        {

        }


        public override double TienKhuyenMai()
        {
            if (soLuong > 50)
                return 0.5 * mh.DonGia;
            else if (soLuong <= 50 && ThanhTien() >= 600000)
                return 0.4 * ThanhTien();
            else
                return 0.1 * ThanhTien();
        }
        public double ThanhToanTamUng()
        {
            return 0.4 * TongThanhTien();
        }
        public double laiSuatTraCham()
        {
            return 0.02 * (TongThanhTien() - ThanhToanTamUng());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Tiền khuyến mãi: {TienKhuyenMai():N0}");
            Console.WriteLine($"Thành tiền: {ThanhTien():N0}");
            Console.WriteLine($"Tổng thành tiền: {TongThanhTien():N0}");
            Console.WriteLine($"Thanh toán tạm ứng: {ThanhToanTamUng():N0}");
            Console.WriteLine($"Lãi suất trả chậm: {laiSuatTraCham():N0}");
        }
    }
}
