using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class NhanVien
    {
        private string maNV;
        private string tenNV;
        private int namVaoLam;
        private double heSoLuong;
        private int soNgayNghi;

        public static double LuongCoBan = 2340000; 

        public string MaNV
        {

            get { return maNV; }
            set { maNV = value; }
        }
        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        public int NamVaoLam
        {
            get { return namVaoLam; }
            set
            {
                if(value >= 1900 && value <= DateTime.Now.Year)
                    namVaoLam = value;
                else
                    namVaoLam = DateTime.Now.Year;
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

        public int SoNgayNghi
        {
            get { return soNgayNghi; }
            set
            {
                if (value >= 0)
                    soNgayNghi = value;
                else
                    soNgayNghi = 0;
            }
        }

        public NhanVien()
        {
            MaNV = "NV01";
            TenNV = "Anh Khang";
            NamVaoLam = DateTime.Now.Year;
            HeSoLuong = 1.0;
            SoNgayNghi = 0;
        }
        public NhanVien(string ma, string ten, int nam, double hesoluong)
        {
            MaNV = ma;
            TenNV = ten;
            NamVaoLam = nam;
            HeSoLuong = hesoluong;
            SoNgayNghi = 0;
        }
        public NhanVien(string ma, string ten, int nam, double hesoluong, int soNgayNghi)
        {
            MaNV = ma;
            TenNV = ten;
            NamVaoLam = nam;
            HeSoLuong = hesoluong;
            SoNgayNghi = soNgayNghi;
        }

        public double PhuCapThamNien()
        {
            int thamNinen = DateTime.Now.Year - namVaoLam;
            if (thamNinen >= 5)
                return thamNinen * NhanVien.LuongCoBan / 100.0;
            return 0;
        }

        public virtual char XepLoaiThiDua()
        {
            if (soNgayNghi <= 1) return 'A';
            else if(soNgayNghi <= 3) return 'B';
            else return 'C';
        }

        public virtual double TinhLuong()
        {
            return LuongCoBan * HeSoLuong * HeSoThiDua() + PhuCapThamNien();
        }

        public double HeSoThiDua()
        {
            if (XepLoaiThiDua() == 'A') return 1.0;
            else if (XepLoaiThiDua() == 'B') return 0.75;
            else return 0.5;
        }

        public virtual void XuatThongTin()
        {
            Console.WriteLine($"Ma: {maNV} | Ten: {tenNV} | Nam vao lam: {namVaoLam} | He so luong: {heSoLuong} | So ngay nghi: {soNgayNghi}");
            Console.WriteLine($"| Phu cap tham nien: {PhuCapThamNien():N0} | Xep loai thi đua: {XepLoaiThiDua()} | He so thi đua: {HeSoThiDua()} | Luong: {TinhLuong():N0}");
        }




    }
}
