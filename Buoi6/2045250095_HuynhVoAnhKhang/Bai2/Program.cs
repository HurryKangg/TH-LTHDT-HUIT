using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListHoaDon ds = new ListHoaDon();


            ds.DocFileXML(@"..\..\DSKhachHang.xml");
            ds.XuatDS();
            Console.WriteLine();

            Console.WriteLine($"TONG THANH TIEN: {ds.TongThanhTien():N0}");
            Console.WriteLine();

            Console.WriteLine($"MAX THANH TIEN");
            KhachHang kh = ds.MaxKhachHang();
            kh.Xuat();
            Console.WriteLine();

            Console.WriteLine($"TONG CHIET KHAU: {ds.TongChietKhau():N0}");
            Console.WriteLine();


            Console.WriteLine("IN SO LUONG VA DAI LY CAP 1");
            ds.XuatDaiLyCap1();
            Console.WriteLine();

            Console.WriteLine("SAP XEP");
            ds.SapXep();
            ds.XuatDS();
            Console.WriteLine();


            Console.WriteLine("IN MAN HINH KHACH HANG NHAP X");
            ds.TimKhachHang();

        }
    }
}
