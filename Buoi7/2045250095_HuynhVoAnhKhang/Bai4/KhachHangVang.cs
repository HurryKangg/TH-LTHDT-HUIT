using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class KhachHangVang : HoaDon
    {
        public KhachHangVang(): base()
        {
            
        }
        public KhachHangVang(string ma, string ten, DateTime ngay, int sl, HangHoa mh) :
            base(ma, ten, ngay, sl, mh)
        {

        }

        public override double TienKhuyenMai()
        {
            if (ThanhTien() > 1000000)
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
        }
    }
}
