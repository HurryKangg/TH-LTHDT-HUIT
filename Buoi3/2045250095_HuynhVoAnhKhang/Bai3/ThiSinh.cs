using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class ThiSinh
    {
        public static double DIEMCHUAN = 5.0;

        private string soBaoDanh;
        private string tenThiSinh;

        private int namSinh;
        private double diemLT;
        private double diemTH1;
        private double diemTH2;

        public string SoBaoDanh { get { return soBaoDanh; } set { soBaoDanh = value; } }
        public string TenThiSinh { get { return tenThiSinh; } set { tenThiSinh = value; } }
        public int NamSinh
        {
            get { return namSinh; }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                    namSinh = value;
                else
                    namSinh = DateTime.Now.Year;
            }
        }
        public double DiemThiLT
        {
            get { return diemLT; }
            set
            {
                if (value > 0 && value <= 10)
                    diemLT = value;
                else
                    diemLT = 0;
            }
        }
        public double DiemThucHanh1
        {
            get { return diemTH1; }
            set
            {
                if (value > 0 && value <= 10)
                    diemTH1 = value;
                else
                    diemTH1 = 0;
            }
        }
        public double DiemThucHanh2
        {
            get { return diemTH2; }
            set
            {
                if (value > 0 && value <= 10)
                    diemTH2 = value;
                else
                    diemTH2 = 0;
            }

        }

        public ThiSinh()
        {
            SoBaoDanh = "BD001";
            TenThiSinh = "Chưa Xác Định";
            NamSinh = DateTime.Now.Year;
            DiemThiLT = 0;
            DiemThucHanh1 = 0;
            DiemThucHanh2 = 0;
        }
        public double DiemTrungBinh()
        {
            return (DiemThiLT + DiemThucHanh1 + DiemThucHanh2) / 3;
        }
        public string XetKetQua()
        {
            double dtb = DiemTrungBinh();

            if (dtb > DIEMCHUAN && diemLT >= 5 && diemTH1 > 0 && diemTH2 > 0)
                return "Đậu";
            return "Rớt";
        }
        public void NhapTS()
        {
            Console.Write("Nhập số báo danh: ");
            SoBaoDanh = Console.ReadLine();
            Console.Write("Nhập tên thí sinh: ");
            TenThiSinh = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm lý thuyết: ");
            DiemThiLT = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm thực hành 1: ");
            DiemThucHanh1 = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm thực hành 2: ");
            DiemThucHanh2 = double.Parse(Console.ReadLine());
        }
        public void XuatThiSinh()
        {
            Console.WriteLine($"{soBaoDanh,-8} {tenThiSinh,-25} {namSinh,-9} {diemLT,-12} " +
                $"{diemTH1,-12} {diemTH2,-12} {DiemTrungBinh(),-10:F2} {XetKetQua(), -12}");
        }
    }
}
