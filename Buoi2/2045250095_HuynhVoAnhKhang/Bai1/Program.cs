using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;



            ListPhanSo ds = new ListPhanSo();
            int chon;

            do
            {
                Console.WriteLine("\n========== MENU QUẢN LÝ PHÂN SỐ ==========");
                Console.WriteLine("1. Nhập danh sách phân số                   ");
                Console.WriteLine("2. Xuất danh sách phân số                   ");
                Console.WriteLine("3. Tối giản tất cả phân số                  ");
                Console.WriteLine("4. Tìm phân số theo giá trị                 ");
                Console.WriteLine("5. Sắp xếp danh sách tăng dần theo giá trị  ");
                Console.WriteLine("6. Liệt kê các phân số lớn hơn 1            ");
                Console.WriteLine("7. Tìm phân số lớn nhất                     ");
                Console.WriteLine("8. Top 3 phân số lớn nhất                   ");
                Console.WriteLine("9. Tính tổng tất cả phân số                 ");
                Console.WriteLine("10. Thêm 1 phân số vào danh sách            ");
                Console.WriteLine("11. Xóa 1 phân số khỏi danh sách            ");
                Console.WriteLine("12. Phân số có tham số                      ");
                Console.WriteLine("13. Nhập số nguyên và cộng phân số          ");
                Console.WriteLine("0. Thoát                                    ");
                Console.WriteLine("============================================");

                chon = TienIch.NhapSoNguyen("Mời bạn chọn: ");

                switch (chon)
                {
                    case 1:
                        ds.NhapDanhSachPS();
                        break;

                    case 2:
                        Console.WriteLine("--- DANH SÁCH PHÂN SỐ ---");
                        ds.XuatDanhSach();
                        break;

                    case 3:
                        ds.ToiGianPS();
                        Console.WriteLine("Đã tối giản tất cả phân số!");
                        break;

                    case 4:
                        
                            if (ds.ListPS.Count == 0)
                            {
                                Console.WriteLine("Danh sách rỗng!");
                                break;
                            }
                            PhanSo p = new PhanSo();
                            p.Nhap();
                            if (ds.SearchPS(p))
                                Console.WriteLine("Có phân số này trong danh sách.");
                            else
                                Console.WriteLine("Không tìm thấy phân số này.");
                            break;
                       

                    case 5:
                            if (ds.ListPS.Count == 0)
                            {
                                Console.WriteLine("Danh sách rỗng!");
                                break;
                            }
                            
                            Console.WriteLine("--- DANH SÁCH SAU KHI SẮP XẾP TĂNG DẦN ---");  
                            ds.SortGiaTri();
                            ds.XuatDanhSach();
                            break;
                 

                    case 6:
                            
                            Console.WriteLine("--- CÁC PHÂN SỐ LỚN HƠN 1 ---");
                            ListPhanSo dslonhon1 = ds.TimThoaLonHon1();
                            dslonhon1.XuatDanhSach();
                            break;

                    case 7:
                            PhanSo max = ds.MaxPS();
                            if (max == null)
                                Console.WriteLine("Danh sách rỗng!");
                            else
                            {
                                Console.Write("Phân số lớn nhất: ");
                                max.Xuat();
                            }
                            break;

                    case 8:
                            
                            Console.WriteLine("--- TOP 3 PHÂN SỐ LỚN NHẤT ---");        
                            ds.Top3PS();
                            ds.XuatDanhSach();
                            break;

                    case 9:
                            PhanSo tong = ds.TongPS();
                            Console.Write("Tổng tất cả phân số: ");
                            tong.Xuat();
                            break;

                    case 10:
                      
                            PhanSo ps = new PhanSo();
                            ps.Nhap();
                            ds.ListPS.Add(ps);
                            Console.WriteLine("Đã thêm phân số vào danh sách!");
                            break;

                    case 11:
                        if (ds.ListPS.Count == 0)
                        {
                            Console.WriteLine("⚠️ Danh sách rỗng!");
                            break;
                        }
                        PhanSo p1 = new PhanSo();
                        p1.Nhap();
                        bool check = ds.XoaPS(p1);
                        Console.WriteLine(check ? "Đã xóa phân số khỏi danh sách...." : "Không tìm thấy phần tử để xóa trong danh sách...");
                        break;

                    case 12:
                        ds.AddPhanSo(new PhanSo(0,1));
                        ds.AddPhanSo(new PhanSo(3,6));
                        ds.AddPhanSo(new PhanSo(5,7));
                        ds.XuatDanhSach();
                        break;
                    case 13:
                        PhanSo ps2 = new PhanSo();
                        int n = TienIch.NhapSoNguyen("Nhập số nguyên: ");
                        ps2.Nhap();
                        PhanSo ketQua = ps2.CongPS(new PhanSo(n, 1));
                        Console.Write("Kết quả: ");
                        ketQua.Xuat();
                        break;
                    case 0:
                        Console.WriteLine("TẠM BIỆT!!!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại!");
                        break;
                }

            } while (chon != 0);

            Console.ReadLine();
        }


    }
}