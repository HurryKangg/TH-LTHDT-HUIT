using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2045250095_HuynhVoAnhKhang
{
    public class SanPham
    {
        private string maSP;
        private string tenSP;
        private int soLuong;
        private double donGia;
        private int soNgayBaoQuan;

        public static double DonGiaBaoQuan = 5000;
        public string MaSP
        {

            get { return maSP; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 5 &&
                    value.StartsWith("SP"))
                    maSP = value;
                else
                    maSP = "SP001";
            }
        }

        public string TenSP
        {
            get { return tenSP; }
            set
            {
                if (!string.IsNullOrEmpty(value) &&
                    value.Length == 50)
                    tenSP = value;
                else
                    tenSP = "Laptop Dell";
            }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set
            {
                if (value > 0)
                    soLuong = value;
                else
                    soLuong = 1;
            }
        }
        public double DonGia
        {
            get { return donGia; }
            set
            {
                if (value >= 10000)
                    donGia = value;
                else
                    donGia = 10000;
            }
        }
        public int SoNgayBaoQuan
        {
            get { return soNgayBaoQuan; }
            set
            {
                if (value > 0)
                    soNgayBaoQuan = value;
                else
                    soNgayBaoQuan = 1;
            }
        }

        public SanPham()
        {
            MaSP = "SP001";
            TenSP = "Laptop Dell";
            SoLuong = 5;
            DonGia = 15000000;
            SoNgayBaoQuan = 10;
        }
        public SanPham(string maSP, string tenSP, int soLuong, double donGia, int soNgayBaoQuan)
        {
            MaSP = maSP;
            TenSP = tenSP;
            SoLuong = soLuong;
            DonGia = donGia;
            SoNgayBaoQuan = soNgayBaoQuan;
        }

        public double TinhTongGiaTri()
        {
            return soLuong * donGia + PhiBaoQuan();
        }

        public double PhiBaoQuan()
        {
            return soLuong * soNgayBaoQuan * SanPham.DonGiaBaoQuan;
        }
        public void XuatThongTin()
        {
            Console.WriteLine($"Mã sản phẩm: {maSP}");
            Console.WriteLine($"Tên sản phẩm: {tenSP}");
            Console.WriteLine($"Số luọng: {soLuong}");
            Console.WriteLine($"Đơn giá: {donGia:N0}");
            Console.WriteLine($"Số ngày bảo quản: {soNgayBaoQuan}");
            Console.WriteLine($"Tổng giá trị: {TinhTongGiaTri():N0}");
            Console.WriteLine();
        }


    }
}
