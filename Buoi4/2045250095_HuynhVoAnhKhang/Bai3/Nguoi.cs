using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class Nguoi
    {
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set
            {
                if (value == "Nam" || value == "Nu")
                    gioiTinh = value;
                else
                    gioiTinh = "Nam";
            }
        }

        public Nguoi()
        {
            HoTen = "No Name";
            NgaySinh = DateTime.Now;
            GioiTinh = "Nam";
        }

        public Nguoi(string ten, DateTime ngay, string gt)
        {
            HoTen = ten;
            NgaySinh = ngay;
            GioiTinh = gt;
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Ho ten: {hoTen}");
            Console.WriteLine($"Ngay sinh: {ngaySinh}");
            Console.WriteLine($"Gioi tinh: {gioiTinh}");
        }
    }
}
