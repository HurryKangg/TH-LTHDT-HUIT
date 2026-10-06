using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class NhanVien
    {
        private string maSo;
        private string hoTen;
        private int ngayCong;
        public static long LuongNgay = 200000;

        public string MaSo
        {
            get { return maSo; }
            set
            {
                if(!string.IsNullOrEmpty(value) && value.Length == 5 
                    && value.StartsWith("NV") && value.Substring(2).All(char.IsDigit)){
                    maSo = value;
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
        public int NgayCong
        {
            get { return ngayCong; }
            set
            {
                if (value >= 0)
                    ngayCong = value;

            }
        }
        public char XepLoai
        {
            get {                 
                if (NgayCong >= 26)
                {
                    return 'A';
                }
                else if (NgayCong >= 22 && NgayCong <= 26)
                {
                    return 'B';
                }
                else
                {
                    return 'C';
                }
            }
        }
        public NhanVien()
        {
            MaSo = "NV0001";
            HoTen = "NGUYỄN VĂN A";
            NgayCong = 0;
        }
        public NhanVien(string maSo, string hoTen, int ngayCong)
        {
            this.MaSo = maSo;
            this.HoTen = hoTen;
            this.NgayCong = ngayCong;
        }
        public NhanVien(NhanVien nv)
        {
            this.MaSo = nv.maSo;
            this.HoTen = nv.hoTen;
            this.NgayCong = nv.ngayCong;
        }
        public void NhapThongTinNV()
        {
            Console.Write("Nhập mã số nhân viên: ");
            MaSo = Console.ReadLine();
            Console.Write("Nhập họ tên nhân viên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập số ngày công: ");
            NgayCong = Int32.Parse(Console.ReadLine());
        }
        public double Luong()
        {
            return NgayCong * LuongNgay;
        }
        public double TinhThuong()
        {
            if (XepLoai == 'A')
                return 0.05 * Luong();
            else if (XepLoai == 'B')
                return 0.02 * Luong();
            else
                return 0;
        }
        public void Xuat()
        {
            Console.WriteLine($"Mã số: {maSo} - Họ tên: {hoTen} - Số ngày công: {ngayCong} - Xếp loại: {XepLoai} - Lương: {Luong()} - Thưởng: {TinhThuong()} - ");
        }
    }
}
