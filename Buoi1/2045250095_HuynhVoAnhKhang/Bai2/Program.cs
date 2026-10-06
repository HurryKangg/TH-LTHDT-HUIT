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
            Console.OutputEncoding = Encoding.UTF8;
            //Nhân viên thứ 1
            NhanVien nhanVien1 = new NhanVien();
            nhanVien1.Xuat();

            NhanVien nhanVien2 = new NhanVien();
            nhanVien2.NhapThongTinNV();
            nhanVien2.Xuat();

            NhanVien nhanVien3  = new NhanVien("NV003", "ĐINH THỊ HỒNG HÀ", 20);
            nhanVien3.Xuat();

            NhanVien nhanVien4 = new NhanVien("NV004", "HUỲNH VÕ ANH KHANG", 1);
            nhanVien4.Xuat();
            Console.ReadLine();
        }
    }
}
