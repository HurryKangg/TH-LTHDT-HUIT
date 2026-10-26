using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public abstract class CongTyABC
    {
        protected string maKH;
        protected string tenKH;
        protected int soLuong;
        protected double donGia;

        public static double VAT = 0.1;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set
            {
                if (value > 0)
                    soLuong = value;
                else
                    soLuong = 0;
            }
        }

        public double DonGia
        {
            get { return donGia; }
            set
            {
                if (value > 0)
                    donGia = value;
                else
                    donGia = 0;
            }
        }

        public CongTyABC()
        {
            MaKH = "KH000";
            TenKH = "No Name";
            SoLuong = 0;
            DonGia = 0;
        }

        public CongTyABC(string ma, string ten, int sl,  double donGia)
        {
            this.MaKH = ma;
            this.TenKH = ten;
            this.SoLuong = sl;
            this.DonGia = donGia;
        }

        public double ThueVAT()
        {
            return CongTyABC.VAT * soLuong * donGia;
        }

        public abstract double ChietKhau();

        public virtual double ThanhTien()
        {
            return soLuong * donGia - ChietKhau() + ThueVAT();
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"{maKH} - {tenKH} - {soLuong} - {donGia:N0}");
            
            Console.WriteLine($"Chiet khau: {ChietKhau():N0}");
            Console.WriteLine($"Thanh tien: {ThanhTien():N0}");
        }
    }
}
