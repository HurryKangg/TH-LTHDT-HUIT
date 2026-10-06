using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKT1
{
    public class DienThoai
    {
        private string maMay;
        private string tenMay;
        private double gia;
        private int soLuongTon;
        private string hang;

        public string MaMay
        {
            get { return maMay; } 
            set
            {
                if (value.Length == 5 && value.StartsWith("DT"))
                    maMay = value;
                else
                    maMay = "DT000";
            }
        }

        public string TenMay
        {
            get { return tenMay; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tenMay = value;
                else
                    tenMay = "Khong Xac Dinh";
            }
        }

        public double Gia
        {
            get { return gia; }
            set
            {
                if (value >= 0)
                    gia = value;
                else
                    gia = 0;
            }
        }

        public int SoLuongTon
        {
            get { return soLuongTon; }
            set
            {
                if (value >= 0)
                    soLuongTon = value;
                else 
                    soLuongTon = 0;
            }
        }

        public string Hang
        {
            get { return hang; }
            set
            {
                if (value == "Apple" || value == "Samsung")
                    hang = value;
                else
                    hang = "Apple";
            }
        }

        public DienThoai()
        {
            MaMay = "DT000";
            TenMay = "Khong Xac Dinh";
            Gia = 0;
            SoLuongTon = 0;
            Hang = "Apple";
        }

        public DienThoai(string ma, string ten, double gia, int sl, string hang)
        {
            MaMay = ma;
            TenMay = ten;
            Gia = gia;
            SoLuongTon = sl;
            Hang = hang;
        }

        public DienThoai(DienThoai obj)
        {
            MaMay = obj.MaMay;
            TenMay = obj.TenMay;
            Gia =obj.Gia;
            SoLuongTon = obj.SoLuongTon;
            Hang = obj.Hang;
        }

        public void Xuat()
        {
            Console.WriteLine($"{maMay,-12} {tenMay,-25} {gia,-14:N0} " +
                $"{soLuongTon,-12} {hang,-12} {ThanhTien(),-14:N0}"); ;
        }

        public double ThanhTien()
        {
            double tongtien = gia * soLuongTon;
            if (tongtien > 10000000)
                return tongtien * (1 - 0.05);
            return tongtien;
        }



    }
}
