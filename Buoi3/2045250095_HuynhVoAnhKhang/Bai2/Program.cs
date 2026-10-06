using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Khoa k = new Khoa();
            Khoa kq = new Khoa();
            k.DocFile(@"..\..\Khoa.xml");
            k.XuatDSKhoa();
            Console.WriteLine();
            
            Console.WriteLine("TỔNG SỐ NHÓM: {0}", k.TinhTongSoNhom());
            Console.WriteLine();
            
            Console.WriteLine("SẮP XẾP TĂNG DẦN THEO HỌ TÊN");
            k.DanhSachTangTheoHoTen();
            k.XuatDSKhoa();

            Console.WriteLine();
            Console.WriteLine("SẮP XẾP GIẢM DẦN THEO SỐ NHÓM");
            k.SapXepGiamDanTheoSoNhom();
            k.XuatDSKhoa();

            Console.WriteLine();
            Console.WriteLine("TRÍCH LỌC DANH SÁCH CÓ SỐ NHÓM LỚN HƠN 1");
            k.LocDanhSachLonHon1();
            k.XuatDSKhoa();
        }
    }
}
