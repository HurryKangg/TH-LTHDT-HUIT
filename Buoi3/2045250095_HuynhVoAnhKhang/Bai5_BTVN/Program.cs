using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            CongTy ct = new CongTy();
            ct.DocFileDanhSach(@"..\..\DSNhanVien.xml");
            ct.XuatDanhSach();
            Console.WriteLine();

            Console.WriteLine("TỔNG LƯƠNG NHÂN VIÊN: {0:N0}", ct.TinhTongLuong());
            Console.WriteLine();

            Console.WriteLine("DANH SÁCH LÃNH ĐẠO");
            ct.DanhSachLanhDao();
            Console.WriteLine();

            Console.WriteLine("LỌC RA DANH SÁCH PHÒNG X");
            ct.LocDanhSachX();
            Console.WriteLine();

            Console.WriteLine("XÓA CÁC NGÀY < 10");
            ct.XoaCacNhanVienSoNgayLamViec();
            Console.WriteLine();

            Console.WriteLine("LỌC DANH SÁCH SỐ NGÀY LỚN HƠN 22");
            ct.LocDanhSachKhongLanhDaoLonHon22();
            Console.WriteLine();

            Console.WriteLine("SẮP XẾP LƯƠNG");
            ct.SapXepLuong();
            ct.XuatDanhSach();
            Console.WriteLine();

            Console.WriteLine("SẮP XẾP NHÂN VIÊN THEO HỌ TÊN TĂNG DẦN");
            ct.SapXepNhanVien();
            ct.XuatDanhSach();
            Console.WriteLine();
        }
    }
}
