using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            HangXe hx = new HangXe();
            hx.DocFileDanhSach(@"..\..\Alpha.xml");
            hx.XuatDanhSachHangXe();
            Console.WriteLine();

            hx.DemSoDongCoDien();
            Console.WriteLine();

            hx.SapXeHangXe();
            Console.WriteLine("SẮP XẾP HÃNG XE");
            hx.XuatDanhSachHangXe();
            Console.WriteLine();

            Console.WriteLine("CÔNG SUẤT LỚN NHẤT");
            Alpha cs = hx.CongSuatCucDai();
            cs.Xuat();
            Console.WriteLine();
        }
    }
}
