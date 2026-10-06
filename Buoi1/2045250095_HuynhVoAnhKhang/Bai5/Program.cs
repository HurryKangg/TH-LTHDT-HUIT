using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Test với constructor không tham số
            KhoaHoc kh3 = new KhoaHoc();
            kh3.XuatThongTin();
            // Test với constructor đầy đủ tham số
            KhoaHoc kh1 = new KhoaHoc("KH101", "Tiếng Anh Giao Tiếp", 30, "3,5,7", 10, "Nguyễn Văn A");
            kh1.XuatThongTin();

            // Test với constructor không tham số + nhập
            KhoaHoc kh2 = new KhoaHoc();
            kh2.NhapThongTin();
            kh2.XuatThongTin();

            Console.ReadLine();
        }
    }
}
