using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public abstract class NhanVienABC
    {
        protected string maNV;
        protected string tenNV;
        protected int namSinh;
        protected string gioiTinh;
        protected double heSoLuong;
        protected int namVaoLam;
        public static double LuongCoBan = 2340000;
        public string MaNV
        {
            get { return maNV; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    maNV = value;
                else
                    maNV = "NV001";
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
                    tenNV = "No Name";
            }
        }

        public int NamSinh
        {
            get { return  namSinh; }
            set
            {
                if (value >= 1990 && value <= DateTime.Now.Year)
                    namSinh = value;
                else
                    namSinh = DateTime.Now.Year;
            }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public double HeSoLuong
        {
            get { return  heSoLuong; }
            set
            {
                if (value > 0)
                    heSoLuong = value;
                else
                    heSoLuong = 1.0;
            }
        }

        public int NamVaoLam
        {
            get { return namVaoLam; }
            set
            {
                if (value >= 1990 && value <= DateTime.Now.Year)
                    namVaoLam = value;
                else
                    namVaoLam = DateTime.Now.Year;
            }
        }
        public NhanVienABC()
        {
            MaNV = "NV001";
            TenNV = "No Name";
            NamSinh = DateTime.Now.Year;
            GioiTinh = "ABC";
            HeSoLuong = 1.0;
            NamVaoLam = DateTime.Now.Year;
        }
        public NhanVienABC(string ma, string ten, int namSinh, string gt, double he, int namVL)
        {
            this.MaNV = ma;
            this.TenNV = ten;
            this.NamSinh = namSinh;
            this.GioiTinh = gt;
            this.HeSoLuong = he;
            this.NamVaoLam = namVL;
        }
        public abstract char XepLoai();
        public abstract double Luong();
        public double TinhThuNhap()
        {
            if (XepLoai() == 'A')
                return Luong() + PhuCapThamNien();
            else
            if (XepLoai() == 'B')
                return Luong() * 0.75 + PhuCapThamNien();
            else
            if (XepLoai() == 'C')
                return Luong() * 0.5 + PhuCapThamNien();
            else
            if (XepLoai() == 'D')
                return Luong() * 0 + PhuCapThamNien();
            return 0;
        }
        public double PhuCapThamNien()
        {
            return (namVaoLam * 0.01) * NhanVienABC.LuongCoBan;
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Ma nhan vien: {maNV}");
            Console.WriteLine($"Ten nhan vien: {tenNV}");
            Console.WriteLine($"Nam sinh: {namSinh}");
            Console.WriteLine($"Gioi tinh: {gioiTinh}");
            Console.WriteLine($"He so luong: {heSoLuong}");
            Console.WriteLine($"Nam vao lam: {namVaoLam}");
            Console.WriteLine($"Phu cap tham nien: {PhuCapThamNien():N0}");
            Console.WriteLine($"Tinh thu nhap: {TinhThuNhap():N0}");

        }

    }
}
