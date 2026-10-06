using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    public class NhanVien
    {
        private string maNV;
        private string tenNV;
        private string phongBan;
        private string chucVu;
        private double heSoLuong;
        private int thamNienCongTac;
        private int soNgayLamViec;

        public static double luongCB = 2340000;

        public string MaNV
        {
            get { return maNV; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 5)
                    maNV = value;
                else
                    maNV = "NV000";
            }
        }
        public string TenNV
        {
            get { return tenNV; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tenNV = value;
                else
                    tenNV = "Nguyễn Văn A";
            }
        }

        public string PhongBan
        {
            get { return phongBan; }
            set { phongBan = value; }
        }
        public string ChucVu
        {
            get { return chucVu; }
            set
            {
                if (value == "Lãnh đạo" || value == "Nhân Viên")
                    chucVu = value;
                else
                    chucVu = "Nhân Viên";
            }
        }

        public double HeSoLuong
        {
            get { return heSoLuong; }
            set
            {
                if (value >= 0)
                    heSoLuong = value;
                else
                    heSoLuong = 0;
            }
        }

        public int ThamNienCongTac
        {
            get { return thamNienCongTac; }
            set
            {
                if (value >= 0)
                    thamNienCongTac = value;
                else
                    thamNienCongTac = 0;
            }
        }
        public int SoNgayLamViec
        {
            get { return soNgayLamViec; }
            set
            {
                if (value >= 0)
                    soNgayLamViec = value;
                else
                    soNgayLamViec = 0;
            }
        }

        public NhanVien()
        {
            MaNV = "NV000";
            TenNV = "Nguyễn Văn A";
            PhongBan = "ABC";
            ChucVu = "Nhân Viên";
            HeSoLuong = 0;
            ThamNienCongTac = 0;
            SoNgayLamViec = 0;
        }

        public NhanVien(string ma, string ten, string phong, string cv, double heso, int thamnien, int so)
        {
            MaNV = ma;
            TenNV = ten;
            PhongBan = phong;
            ChucVu = cv;
            HeSoLuong = heso;
            ThamNienCongTac = thamnien;
            SoNgayLamViec = so;
        }

        public double Luong()
        {
            return heSoLuong * luongCB * HeSoThiDua() + 1100000 + PhuCap();
        }

        public double HeSoThiDua()
        {
            if (chucVu.Equals("Lãnh Đạo", StringComparison.OrdinalIgnoreCase))
                return 1.0;
            else if (chucVu.Equals("Nhân Viên", StringComparison.OrdinalIgnoreCase))
                if (soNgayLamViec > 22)
                    return 1.0;
                else if (soNgayLamViec > 20)
                    return 0.8;
                else
                    return 0.6;
            else
                return 0;
        }

        public double PhuCap()
        {
            if (chucVu.Equals("Lãnh Đạo", StringComparison.OrdinalIgnoreCase))
                return 1350000;
            else
                return 0;
        }

        public void Xuat()
        {
            Console.WriteLine(
    $"{maNV,-10} {tenNV,-25} {phongBan,-12} {chucVu,-12} " +
    $"{heSoLuong,-10} {thamNienCongTac,-10} {soNgayLamViec,-10} " +
    $"{luongCB,-12:N0} {HeSoThiDua(),-10} {PhuCap(),-12:N0} {Luong(),-12:N0}"
);
        }
    }
}
