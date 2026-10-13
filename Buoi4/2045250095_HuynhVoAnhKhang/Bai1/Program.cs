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
            Console.OutputEncoding = Encoding.UTF8;
            CongTy ct = new CongTy();
            ct.DocFileDanhSach(@"..\..\CongTy.xml");
            ct.XuatCongTy();

            Console.WriteLine("LƯƠNG CAO NHẤT: {0:N0}", ct.MaxLuong());
            Console.WriteLine();

            Console.WriteLine("NHÂN VIÊN CÓ LƯƠNG CAO NHẤT");
            NhanVien nv = ct.MaxLuongNV();
            nv.XuatThongTin();
            Console.WriteLine();

            Console.WriteLine("DANH SÁCH CÁN BỘ");
            ct.InDanhSachCanBo();
        }
    }
}
