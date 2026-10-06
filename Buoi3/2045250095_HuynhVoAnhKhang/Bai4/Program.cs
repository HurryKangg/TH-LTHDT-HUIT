using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            hoadon hd = new hoadon();
            hd.DocFileDanhSach(@"..\..\hoadon.xml");
            hd.XuatDanhSachHoaDon();
            Console.WriteLine();

            Console.WriteLine("TỔNG THÀNH TIỀN: {0:N0}", hd.TongThanhTien());
            Console.WriteLine();

            Console.WriteLine("SẮP XẾP GIẢM DẦN !!!");
            hd.SapXepBanHang();
            Console.WriteLine();

            Console.WriteLine("MAX THÀNH TIỀN");
            ctbh bh = hd.MaxThanhTien();
            bh.Xuat();
        }
    }
}
