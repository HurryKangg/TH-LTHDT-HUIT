using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class NhanVien
    {
        private string maNV;
        private string tenNV;
        private double heSoLuong;
        private int namVaoLam;

        public static double MLTT = 2340000;

        public string MaNV
        {
            get { return maNV; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 5 
                    && value.StartsWith("NV") && 
                    value.Substring(2).All(char.IsDigit))
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
                if(!string.IsNullOrEmpty(value))
                    tenNV = value;
            }
        }

        public double HeSoLuong
        {
            get { return  heSoLuong; }
            set
            {
                if (value > 0)
                    heSoLuong = value;
                else
                    heSoLuong = 1;
            }
        }
        public int NamVaoLam
        {
            get { return  namVaoLam; }
            set
            {
                int namHT = DateTime.Now.Year;
                if (value >= 1900 && value <= namHT)
                   namVaoLam = value;
                else
                    namVaoLam = namHT;
            }
        }

        public NhanVien()
        {
            MaNV = "NV000";
            TenNV = "Chưa Xác Định";
            HeSoLuong = 1;
            NamVaoLam = DateTime.Now.Year;
        }

        public NhanVien(string ma, string ten, double luong, int nam)
        {
            this.MaNV = ma;
            this.TenNV = ten;
            this.HeSoLuong = luong;
            this.NamVaoLam = nam;
        }

        public NhanVien(NhanVien obj)
        {
            this.MaNV = obj.MaNV;
            this.TenNV = obj.TenNV;
            this.HeSoLuong = obj.HeSoLuong;
            this.NamVaoLam = obj.NamVaoLam;
        }
        
        public double LuongNhanVien()
        {
            return LuongCoBan() * (1 + HSPCTN());
        }

        public double LuongCoBan()
        {
            return HeSoLuong * MLTT;
        }
        public double HSPCTN()
        {
            int namHT = DateTime.Now.Year;
            return (namHT - NamVaoLam) * 0.01;
        }
        public double NhapLuong(string tb)
        {
            while (true)
            {
                Console.Write(tb);
                if(double.TryParse(Console.ReadLine(), out double luong) && luong > 0)
                {
                    return luong;
                }
                Console.WriteLine("Vui lòng nhập số lương > 0!");
            }
        }
        public void NhapNV()
        {
            Console.Write("Nhập mã NV: ");
            MaNV = Console.ReadLine();
            Console.Write("Nhập tên NV: ");
            TenNV = Console.ReadLine();
            Console.Write("Nhập hệ số lương: ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                HeSoLuong = 1;
            }
            else if (double.TryParse(input, out double luong) && luong > 0)
            {
                HeSoLuong = luong;
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số lương > 0!");
            }

            Console.Write("Nhập vào năm vào làm: ");
            string tb = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(tb))
            {
                NamVaoLam = DateTime.Now.Year;
            }
            else if (int.TryParse(tb, out int nam))
            {
                NamVaoLam = nam;
            }
            else
            {
                Console.WriteLine($"Vui lòng nhập năm từ 1900 đến {DateTime.Now.Year}!");
            }
        }

        public void Xuat()
        {
            Console.WriteLine($"{maNV,-8} {tenNV,-25} {heSoLuong,-10} {namVaoLam,-8} " +
                              $"{LuongCoBan(),-15:N0} {HSPCTN(),-10:P2} {LuongNhanVien(),-15:N0}");
        }
    }
}
