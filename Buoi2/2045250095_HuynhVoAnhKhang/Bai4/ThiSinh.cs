using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class ThiSinh
    {
        private string maThiSinh;
        private string hoTen;
        private string gioiTinh;
        private float diemLT;
        private float diemTH;

        public string MaThiSinh { get { return maThiSinh; } set { maThiSinh = value; } }
        public string HoTen { get { return hoTen; } set { hoTen = value; } }
        public string GioiTinh { get { return gioiTinh; } set { gioiTinh = value; } }
        public float DiemLT
        {
            get { return diemLT; }
            set
            {
                if (value >= 0 && value <= 10)
                    diemLT = value;
                else
                    Console.WriteLine("Điểm phải lớn 0 và nhỏ hoặc bằng 10");
            }        
        }
        public float DiemTH
        {
            get { return diemTH; }
            set
            {
                if (value >= 0 && value <= 10)
                    diemTH = value;
                else
                    Console.WriteLine("Điểm phải lớn 0 và nhỏ hoặc bằng 10");
            }
        }

        public ThiSinh()
        {
            MaThiSinh = "TS001";
            HoTen = "Khong xac dinh";
            GioiTinh = "Chua ro";
            DiemLT = 0.0f;
            DiemTH = 0.0f;
        }
        public ThiSinh(string ma)
        {
            this.MaThiSinh = ma;
        }
        public ThiSinh(string ma, string ten,string gt, float lt, float th)
        {
            this.MaThiSinh= ma;
            this.HoTen= ten;
            this.GioiTinh = gt;
            this.DiemLT = lt;
            this.DiemTH = th;
        }
        
        public double TinhTongKet()
        {
            return (DiemLT + DiemTH) / 2;
        }

        public string KetQua()
        {
            double kq = TinhTongKet();      
            if (kq >= 5 && DiemLT >= 5 && DiemTH >= 5)
                return "Đậu";
            return "Rớt";
        }


        public void Nhap()
        {
            Console.Write("Nhập mã thí sinh: ");
            MaThiSinh = Console.ReadLine();
            Console.Write("Nhập tên thí sinh: ");
            HoTen = Console.ReadLine();
            DiemLT = TienIch.NhapDiem("Nhập điểm lý thuyết: ");
            DiemTH = TienIch.NhapDiem("Nhập điểm thực hành: ");
        }

        public void Xuat() {
            Console.WriteLine($"{this.MaThiSinh} - {this.HoTen} - {this.DiemLT:F2} - {this.DiemTH:F2} - {TinhTongKet():F2} - {KetQua()}");
         }



    }
}
