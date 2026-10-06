using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKT2
{
    public class SinhVien
    {
        private string maSV;
        private string hoTen;
        private double dtb;
        private int soTC;
        private string khoa;
        public string MaSV
        {
            get { return maSV; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 8 && value.StartsWith("SV"))
                    maSV = value;
                else
                    maSV = "SV000000";
            }
        }

        public string HoTen
        {
            get { return hoTen; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    hoTen = value;
                else
                    hoTen = "NO NAME";
            }
        }

        public double Dtb
        {
            get { return dtb; }
            set
            {
                if (value >= 0)
                    dtb = value;
                else
                    dtb = 0;
            }
        }
        public int SoTC
        {
            get { return soTC; }
            set
            {
                if(value >= 0)
                    soTC = value;
                else
                    soTC = 0;
            }
        }

        public string Khoa
        {
            get { return khoa; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    khoa = value;
                else
                    khoa = "UNKNOWN";
            }
        }

        public SinhVien()
        {
            MaSV = "SV000000";
            HoTen = "NO NAME";
            Dtb = 0;
            SoTC = 0;
            Khoa = "UNKNOWN";
        }

        public SinhVien(string ma, string ten, double dtb, int so, string khoa)
        {
            MaSV = ma;
            HoTen = ten;
            Dtb = dtb;
            SoTC = so;
            Khoa = khoa;
        }

        public SinhVien(SinhVien obj)
        {
            MaSV = obj.MaSV;
            HoTen = obj.HoTen;
            Dtb = obj.Dtb;
            SoTC = obj.SoTC;
            Khoa = obj.Khoa;
        }

        public virtual string XepLoai()
        {
            if (dtb >= 9)
                return "Xuất Sắc";
            else if (dtb >= 8)
                return "Giỏi";
            else if (dtb >= 6.5)
                return "Khá";
            else if (dtb >= 5)
                return "Trung Bình";
            else
                return "Yếu";
        }

         public virtual void Xuat()
        {
            Console.WriteLine($"{maSV,-12} {hoTen,-25} {dtb,-15:F2} {soTC,-15} {khoa,-20} {XepLoai(),-13}");
        }

    }
}
