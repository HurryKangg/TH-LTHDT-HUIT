using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public abstract class HoaDon: IHoaDon
    {
        protected string maKH;
        protected string tenKH;
        protected DateTime ngayLap;
        protected int soLuong;
        protected HangHoa mh;
        public HangHoa MH
        {
            get { return mh; }
            set { mh = value; }
        }
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }
        public int SoLuong
        {
            get{ return soLuong; }
            set { soLuong = value; }
        }
        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

        public HoaDon()
        {
            MaKH = "KH000";
            tenKH = "";
            NgayLap = DateTime.Now;
            SoLuong = 0;
            mh = new HangHoa();
        }

        public HoaDon(string maKH, string tenKH, DateTime ngay,int sl, HangHoa mhang)
        {
            this.MaKH = maKH;
            this.tenKH = tenKH;
            this.NgayLap = ngay;
            this.SoLuong = sl;
            this.MH = mhang;
        }

        public double ThanhTien()
        {
            return soLuong * MH.DonGia;
        }
        public abstract double TienKhuyenMai();
        public double TongThanhTien()
        {
            return ThanhTien() - TienKhuyenMai();
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Mã KH: {maKH}");
            Console.WriteLine($"Tên KH: {tenKH}");
            Console.WriteLine($"Ngày: {ngayLap}");
            Console.WriteLine($"Số lượng: {soLuong}");
            Console.WriteLine($"Mã hàng: {MH.MaHH} - Tên hàng: {MH.TenHH} - Đơn giá: {MH.DonGia}");
        }
    }
}
