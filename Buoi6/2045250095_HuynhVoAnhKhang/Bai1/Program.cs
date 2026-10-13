using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNhanVien ds = new ListNhanVien();
            ds.DocFileXML(@"..\..\ListNhanVien.xml");
            ds.XuatDS();
            Console.WriteLine();

            Console.WriteLine($"TONG LUONG NHAN VIEN: {ds.TinhTongLuongNV():N0}");
            Console.WriteLine();


            Console.WriteLine($"TONG THU NHAP NHAN VIEN: {ds.TinhTongThuNhap():N0}");
            Console.WriteLine();

        }
    }
}
