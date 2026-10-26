using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class KhachHangThanThiet : HoaDon, ILaiSuat
    {
        public KhachHangThanThiet(): base()
        {
            
        }

        public KhachHangThanThiet(string ma, string ten, DateTime ngay, int sl, HangHoa mh):
            base(ma, ten, ngay, sl, mh)
        {

        }

        public double ThanhToanTamUng()
        {
            return 0.6 * TongThanhTien();
        }
        public double laiSuatTraCham()
        {
            return 0.03 * (TongThanhTien() - ThanhToanTamUng());
        }

        public override double TienKhuyenMai()
        {
            if (soLuong > 60)
                return 0.4 * mh.DonGia;
            else if (soLuong <= 60 && ThanhTien() >= 800000)
                return 0.3 * ThanhTien();
            else
                return 0;
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
