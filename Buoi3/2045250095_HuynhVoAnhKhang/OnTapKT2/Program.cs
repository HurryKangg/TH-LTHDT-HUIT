using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKT2
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            QLSinhVien sinhVien = new QLSinhVien();
            sinhVien.DocFileDanhSach(@"..\..\SinhVien.xml");
            sinhVien.XuatDanhSach();
            Console.WriteLine();

            Console.WriteLine("ĐẾM SỐ LƯỢNG SINH VIÊN GIỎI TRỞ LÊN");
            sinhVien.DemSoLuongSinhVienGioi();
            Console.WriteLine();

            Console.WriteLine("SẮP XẾP");
            sinhVien.SapXep();
            sinhVien.XuatDanhSach();
            Console.WriteLine();

            Console.WriteLine("IN RA SINH VIÊN ĐIỂM GPA CAO");
            SinhVien sv = sinhVien.MaxGPA();
            sv.Xuat();
        }
    }
}
