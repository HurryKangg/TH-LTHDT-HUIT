using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class MonHoc
    {
        private string maMH;
        private string tenMH;
        private float diemTX;
        private float diemGK;
        private float diemCK;

        public string MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }
        public string TenMH
        {
            get { return tenMH; }
            set { tenMH = value; }
        }
        public float DiemTX
        {
            get { return diemTX; }
            set
            {
                if (value >= 0 && value <= 10)
                    diemTX = value;
                else
                    diemTX = 0;
            } 
                
        }
        public float DiemGK
        {
            get { return diemGK; }
            set
            {
                if (value >= 0 && value <= 10)
                    diemGK = value;
                else 
                    diemGK = 0;
            }
        }
        public float DiemCK
        {
            get { return diemCK; }
            set
            {
                if(value >= 0 && value <= 10)
                    diemCK = value;
                else  
                    diemCK = 0;
            }
        }
        public MonHoc()
        {
            MaMH = "MH000";
            TenMH = "Không xác định";
            DiemTX = 0;
            DiemGK = 0;
            DiemCK = 0;
        }
        public MonHoc(string ma, string ten)
        {
            this.MaMH = ma;
            this.TenMH = ten;
            DiemTX = 0;
            DiemGK = 0;
            DiemCK = 0;
        }
        public MonHoc(string ma, string ten, float tx, float gK, float ck)
        {
            this.MaMH = ma;
            this.TenMH = ten;
            this.DiemTX = tx;
            this.DiemGK = gK;
            this.DiemCK = ck;
        }
        public double TongKet()
        {
            return (DiemTX * 1.0 + DiemGK * 2.0 + DiemCK * 3.0) / 6;
        }
        public string KetQua()
        {
            double diemTong = TongKet();
            if (diemTong >= 5)
                return "Đạt";
            else
                return "Không đạt";
        }
        
        public void NhapMH()
        {
            Console.Write("Nhập mã môn: ");
            MaMH = Console.ReadLine();
            Console.Write("Nhập tên môn: ");
            TenMH = Console.ReadLine();
            DiemTX = TienIch.NhapDiem("Nhập điểm thường xuyên: ");
            DiemGK = TienIch.NhapDiem("Nhập điểm giữa kỳ: ");
            DiemCK = TienIch.NhapDiem("Nhập điểm cuối kỳ: ");
        }
        public void Xuat()
        {
            Console.WriteLine($"{MaMH,-8} {TenMH,-25} {diemTX,-10:F1} {diemGK,-8:F1} " +
                              $"{diemCK,-15:F1} {TongKet(),-10:F1} {KetQua(),-15}");
        }

    }
}
