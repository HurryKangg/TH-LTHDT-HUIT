using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    public class ChuyenXe
    {
        protected TaiKhoanTaiXe taiXe;
        protected TaiKhoanKH khachHang;
        protected string diaChiDon;
        protected string diaChiDen;
        protected double khoangCach;
        protected int gioDon;
        protected DateTime ngayDi;

        public TaiKhoanTaiXe TaiXe { get { return taiXe; } set { taiXe = value; } }
        public TaiKhoanKH KhachHang { get { return khachHang; } set { khachHang = value; } }
        public string DiaChiDon { get { return diaChiDon; } set { diaChiDon = value; } }
        public string DiaChiDen { get { return diaChiDen; } set { diaChiDen = value; } }
        public double KhoangCach { get { return khoangCach; } set { khoangCach = value; } }
        public int GioDon { get { return gioDon; } set { gioDon = value; } }
        public DateTime NgayDi { get { return ngayDi; } set { ngayDi = value; } }

        public ChuyenXe()
        {

        }

        public ChuyenXe(TaiKhoanTaiXe taiXe, TaiKhoanKH khachHang, string diaChiDon, string diaChiDen,
            double khoangCach, int gioDon, DateTime ngayDi)
        {
            TaiXe = taiXe;
            KhachHang = khachHang;
            DiaChiDon = diaChiDon;
            DiaChiDen = diaChiDen;
            KhoangCach = khoangCach;
            GioDon = gioDon;
            NgayDi = ngayDi;
        }

        public double TinhThanhTien()
        {
            DateTime time = ngayDi.Date.AddHours(GioDon);
            double tien = TaiXe.TinhTienChuyenDi(khoangCach, time);

            if (KhachHang.IsVIP() && tien > 200000)
                tien *= 0.9;
            return tien;
        }

        public virtual void Xuat()
        {
            double giaCuoc = TinhThanhTien();
            double phi = taiXe.TongPhiCongTy(giaCuoc);

            Console.WriteLine("===== HÓA ĐƠN CHUYẾN ĐI =====");
            Console.WriteLine($"Tài xế      : {TaiXe.TenTX} ({TaiXe.HinhThuc.LoaiXe})");
            Console.WriteLine($"Khách hàng  : {KhachHang.Username} ({KhachHang.Loai})");
            Console.WriteLine($"Địa chỉ đón : {diaChiDon}");
            Console.WriteLine($"Địa chỉ đến : {diaChiDen}");
            Console.WriteLine($"Khoảng cách : {khoangCach} km");
            Console.WriteLine($"Ngày đi     : {NgayDi:dd/MM/yyyy}");
            Console.WriteLine($"Giờ đón : {gioDon:hh\\:mm}");
            Console.WriteLine($"Thành tiền  : {giaCuoc:N0} VNĐ");
            Console.WriteLine($"Phí trả cty : {phi:N0} VNĐ");
        }
    }
}
