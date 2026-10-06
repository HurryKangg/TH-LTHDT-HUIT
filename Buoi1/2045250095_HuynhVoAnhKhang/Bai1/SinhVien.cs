using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class SinhVien
    {
        private string maSV;
        private string hoTen;
        private double dtb;
        public string MaSV
        {
            get { return maSV; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    maSV = value;
                }
            }
        }
        public string HoTen
        {
            get { return hoTen; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    hoTen = value;
                }
            }
        }
        public double Dtb
        {
            get { return dtb; }
            set
            {
                if(value > 0)
                {
                    dtb = value;
                }
            }
        }
        public SinhVien()
        {
            MaSV = "2045250095";
            HoTen = "Huỳnh Võ Anh Khang";
            Dtb = 0;
        }
        public SinhVien(string maSV, string hoTen, double dtb)
        {
            this.MaSV = maSV;
            this.HoTen = hoTen;
            this.Dtb = dtb;
        }

        public void NhapThongTinSV()
        {
            Console.Write("Nhập mã sinh viên: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhập tên sinh viên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập điểm trung bình: ");
            Dtb = double.Parse(Console.ReadLine());
        }

        public string XepLoai()
        {
            if (Dtb >= 8)
                return "Giỏi";
            else if (Dtb >= 6.5 && Dtb < 8)
                return "Khá";
            else if (Dtb >= 5 && Dtb < 6.5)
                return "Trung bình";
            else
                return "Yếu kém";
        }
        public void Xuat()
        {
            Console.WriteLine($"Mã Sinh Viên: {maSV} - Họ Tên: {hoTen} - ĐTB: {dtb:0.00} - Xếp Loại: {XepLoai()}");
        }
    }
}
