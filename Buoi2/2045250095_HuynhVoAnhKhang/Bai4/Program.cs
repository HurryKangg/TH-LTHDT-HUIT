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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DSThiSinh ds = new DSThiSinh();

            while (true)
            {
                Console.WriteLine("\n================ MENU QUẢN LÝ THÍ SINH ================");
                Console.WriteLine("1. Nhập danh sách thí sinh");
                Console.WriteLine("2. In danh sách thí sinh");
                Console.WriteLine("3. In danh sách thí sinh ĐẬU");
                Console.WriteLine("4. Thống kê số ĐẬU / RỚT");
                Console.WriteLine("5. Tìm thí sinh theo mã");
                Console.WriteLine("6. Sắp xếp danh sách giảm dần theo điểm tổng kết");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("========================================================");

                int chon = TienIch.NhapSo("Chọn chức năng: ");

                switch (chon)
                {
                    case 1:
                        ds.NhapDanhSach();
                        break;
                    case 2:
                        ds.XuatDS();
                        break;
                    case 3:
                        ds.XuatDanhSachThiSinhDau();
                        break;
                    case 4:
                        ds.TinhTongSoThiSinh();
                        break;
                    case 5:
                        ds.TimMaThiSinh();
                        break;
                    case 6:
                        
                        ds.Sort();
                        ds.XuatDS();
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình. Tạm biệt!");
                        return;
                    default:
                        Console.WriteLine("Chức năng không hợp lệ!");
                        break;
                }
            }
        }
    }
}
