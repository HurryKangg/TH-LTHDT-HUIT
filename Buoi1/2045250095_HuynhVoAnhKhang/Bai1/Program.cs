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
            SinhVien sv1 = new SinhVien();
            sv1.Xuat();

            SinhVien sv2 = new SinhVien("2045250099", "ANH KHANG", 9);
            sv2.Xuat();

            SinhVien sv3 = new SinhVien();
            sv3.NhapThongTinSV();
            sv3.Xuat();

            Console.ReadKey();
        }
    }
}
