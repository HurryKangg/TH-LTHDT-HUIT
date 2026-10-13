using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_BTVN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DsNhanVien ds = new DsNhanVien();
            ds.DocFileDanhSach(@"..\..\DsNhanVien.xml");
            ds.XuatDanhSach();
            Console.WriteLine();

            Console.WriteLine($"TONG THU NHAP: {ds.TongThuNhap():N0}");
            Console.WriteLine();

            Console.WriteLine("DANH SACH CAN BO");
            ds.DanhSachCanBo();
            Console.WriteLine();

            Console.WriteLine("SAP XEP");
            ds.SapXep();
            ds.XuatDanhSach();
        }
    }
}
