using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    public class NuocGiaiKhat
    {
        private string tenHang;
        private string donVi;
        private int soLuong;
        private double donGia;
        public static double VAT = 0.1;

        public string TenHang
        {
            get {  return tenHang; } 
            set { tenHang = value; }
        }
        public string DonVi
        {
            get { return donVi; }
            set
            {
                if (value == "Ket" || value == "Thung" || value == "Chai" || value == "Lon")
                {
                    donVi = value;
                }
                donVi = "Ket";
            }
        }
        public double DonGia
        {
            get { return donGia; }
            set
            {
                if(value > 0)
                {
                    donGia = value;
                }
            }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set
            {
                if (value > 0)
                    soLuong = value;
            }
        }
        public NuocGiaiKhat()
        {
            TenHang = "O Long";
            DonVi = "Ket";
            SoLuong = 0;
            DonGia = 0;
            
        }
        public NuocGiaiKhat(string tenHang, string donVi, int soLuong, double donGia)
        {
            this.TenHang = tenHang;
            this.DonVi = donVi;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
        }
        public NuocGiaiKhat(NuocGiaiKhat obj)
        {
            this.TenHang = obj.TenHang;
            this.DonVi = obj.DonVi;
            this.SoLuong = obj.SoLuong;
            this.DonGia = obj.DonGia;
        }
        public double ThanhTien()
        {
            if (donVi.Equals("Ket", StringComparison.OrdinalIgnoreCase) ||
                    donVi.Equals("Thung", StringComparison.OrdinalIgnoreCase))
                return soLuong * donGia * (1 + VAT);
            else if (donVi.Equals("Chai", StringComparison.OrdinalIgnoreCase))
                return soLuong * (donGia / 20) * (1 + VAT);
            else
                return soLuong * (donGia / 24) * (1 + VAT);
        }

        public void nhap()
        {
            Console.Write("Nhap ten hang: ");
            TenHang = Console.ReadLine();
            Console.Write("Nhap don vi tinh (Thung, Chai, Lon, Ket): ");
            DonVi = Console.ReadLine();
            Console.Write("Nhap so luong: ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap don gia: ");
            DonGia = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("Ten hang: " + TenHang);
            Console.WriteLine("Don vi tinh: " + DonVi);
            Console.WriteLine("So luong: " + SoLuong);
            Console.WriteLine("Don gia: " + DonGia);
            Console.WriteLine("Thanh tien: " + ThanhTien());
        }
    }
}
