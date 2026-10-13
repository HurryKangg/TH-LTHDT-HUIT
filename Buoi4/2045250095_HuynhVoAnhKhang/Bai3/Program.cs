using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DsSinhVien ds = new DsSinhVien();
            ds.DocFileDanhSach(@"..\..\SinhVien.xml");
            ds.XuatDanhSach();
            Console.WriteLine();

            Console.WriteLine("DANH SACH DAI HOC");
            ds.XuatHeDaiHoc();
            Console.WriteLine();

            Console.WriteLine("TONG HOC PHI: {0:N0}", ds.TongHocPhiAll());
        }
    }
}
