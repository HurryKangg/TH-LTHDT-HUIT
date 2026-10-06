using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            CuaHang ch = new CuaHang();
            ch.DocFileDanhSach(@"..\..\CuaHang.xml");
            ch.XuatDanhSach();
            Console.WriteLine();

            Console.WriteLine("SẮP XÉP GIẢM DẦN THÀNH TIỀN");
            ch.SapXep();
            ch.XuatDanhSach();
            Console.WriteLine();

            Console.WriteLine("MAX GIÁ ĐIỆN THOẠI");
            DienThoai MAX = ch.MaxDT();
            MAX.Xuat();
        }
    }
}
