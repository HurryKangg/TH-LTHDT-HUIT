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
            SanPhamDienTu sp1 = new SanPhamDienTu();
            sp1.Xuat();

            SanPhamDienTu sp2 = new SanPhamDienTu("SamSung", "S123", "Galaxy S25", 20, "Dien thoai di dong");
            sp2.Xuat();

            SanPhamDienTu sp3 = new SanPhamDienTu();
            sp3.Nhap();
            sp3.Xuat();
        }
    }
}
