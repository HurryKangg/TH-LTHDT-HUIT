using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_BTVN
{
    public class NhanVien
    {
        private string maNV;
        private string tenNV;
        private double heSoLuong;
        public static double LuongCoBan = 2340000;
        public string MaNV
        {
            get {  return maNV; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 5 &&
                    value.StartsWith("NV") && value.Substring(2).All(char.IsDigit))
                    maNV = value;
                else
                    maNV = "NV001";
            }
        }
        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        public double HeSoLuong
        {
            get { return heSoLuong; }
            set
            {
                if(value >= 0)
                    heSoLuong = value;
                else
                    heSoLuong = 0;
            }
        }

        public NhanVien()
        {
            MaNV = "NV001";
            TenNV = "No Name";
            HeSoLuong = 2.34;
        }

        public NhanVien(string ma, string ten, double heSL)
        {
            this.MaNV = ma;
            this.TenNV = ten;
            this.HeSoLuong= heSL;
        }

        public virtual double TinhThuNhap()
        {
            return heSoLuong * NhanVien.LuongCoBan;
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Ma nhan vien: {maNV}");
            Console.WriteLine($"Ten nhan vien: {tenNV}");
            Console.WriteLine($"He so luong: {heSoLuong}");
            Console.WriteLine($"Thu nhap: {TinhThuNhap():N0}");
        }

    }
}
