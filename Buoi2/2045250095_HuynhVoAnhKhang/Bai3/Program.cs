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
            
            ListHocSinh ds = new ListHocSinh();

            while (true)
            {
                Console.InputEncoding = Encoding.UTF8;
                Console.OutputEncoding = Encoding.UTF8;

                Console.WriteLine("\n================ MENU QUẢN LÝ HỌC SINH ================");
                Console.WriteLine("1. Nhập danh sách học sinh");
                Console.WriteLine("2. Xuất danh sách học sinh");
                Console.WriteLine("3. Tính điểm trung bình học kỳ của tất cả học sinh");
                Console.WriteLine("4. Xếp loại tất cả học sinh");
                Console.WriteLine("5. Xét kết quả học tập của tất cả học sinh");
                Console.WriteLine("6. In danh sách môn Đạt theo mã học sinh");
                Console.WriteLine("7. Thêm một học sinh mới");
                Console.WriteLine("8. Tìm kiếm học sinh theo mã");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("=======================================================");

                int chon = TienIch.NhapSo("Chọn chức năng: ");

                switch (chon)
                {
                    case 1:
                        ds.NhapDanhSachHS();
                        break;
                    case 2:
                        ds.XuatDanhSachHS();
                        break;
                    case 3:
                        ds.TinhTatCaTrungBinhHS();
                        break;
                    case 4:
                        ds.XepLoaiTatCa();
                        break;
                    case 5:
                        ds.XetKetQua();
                        break;
                    case 6:
                        ds.InKetQuaDat();
                        break;
                    case 7:
                        ds.ThemHocSinh();
                        break;
                    case 8:
                        ds.TimTheoMaHS();
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
