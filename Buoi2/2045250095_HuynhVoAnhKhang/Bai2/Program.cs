using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ListNhanVien ds = new ListNhanVien();
            int chon;

            do
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════════╗");
                Console.WriteLine("║   QUẢN LÝ NHÂN VIÊN                      ║");
                Console.WriteLine("╠══════════════════════════════════════════╣");
                Console.WriteLine("║  1. Nhập danh sách nhân viên             ║");
                Console.WriteLine("║  2. Xuất danh sách nhân viên             ║");
                Console.WriteLine("║  3. Thêm một nhân viên                   ║");
                Console.WriteLine("║  4. Tìm nhân viên theo mã                ║");
                Console.WriteLine("║  5. Xóa nhân viên theo mã                ║");
                Console.WriteLine("║  6. Tính tổng lương nhân viên            ║");
                Console.WriteLine("║  7. Tìm nhân viên có lương cao nhất      ║");
                Console.WriteLine("║  8. Sắp xếp theo năm vào làm             ║");
                Console.WriteLine("║  9. Nhân viên có sẵn                     ║");
                Console.WriteLine("║ 10. Tìm max lương                        ║");
                Console.WriteLine("║  0. Thoát                                ║");
                Console.WriteLine("╚══════════════════════════════════════════╝");
                Console.Write("Chọn chức năng: ");

                if (!int.TryParse(Console.ReadLine(), out chon))
                {
                    Console.WriteLine("Vui lòng nhập số!");
                    TienIch.NganCach();
                    continue;
                }

                Console.Clear();

                switch (chon)
                {
                    case 1:
                        Console.WriteLine("=== NHẬP DANH SÁCH NHÂN VIÊN ===");
                        ds.NhapDanhSach();
                        TienIch.NganCach();
                        break;

                    case 2:
                        Console.WriteLine("=== DANH SÁCH NHÂN VIÊN ===");
                        ds.XuatDanhSach();
                        TienIch.NganCach();
                        break;

                    case 3:
                        Console.WriteLine("=== THÊM MỘT NHÂN VIÊN ===");
                        NhanVien nvMoi = new NhanVien();
                        nvMoi.NhapNV();
                        if (ds.TimNhanVien(nvMoi))
                        {
                            Console.WriteLine("Mã NV đã tồn tại! Không thêm được.");
                        }
                        else
                        {
                            ds.AddNV(nvMoi);
                            Console.WriteLine("Đã thêm nhân viên thành công!");
                        }
                        TienIch.NganCach();
                        break;

                    case 4:
                        Console.WriteLine("=== TÌM NHÂN VIÊN THEO MÃ ===");
                        Console.Write("Nhập mã NV cần tìm: ");
                        string maTim = Console.ReadLine();
                        NhanVien nvTim = new NhanVien();
                        nvTim.MaNV = maTim;
                        if (ds.TimNhanVien(nvTim))
                        {
                            Console.WriteLine("Tìm thấy nhân viên:");
                            TienIch.TieuDe();
                            foreach (NhanVien nv in ds.ListNV)
                                if (nv.MaNV == nvTim.MaNV)
                                    nv.Xuat();
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy nhân viên!");
                        }
                        TienIch.NganCach();
                        break;

                    case 5:
                        Console.WriteLine("=== XÓA NHÂN VIÊN THEO MÃ ===");
                        Console.Write("Nhập mã NV cần xóa: ");
                        string maXoa = Console.ReadLine();
                        NhanVien nvXoa = new NhanVien();
                        nvXoa.MaNV = maXoa;
                        if (ds.XoaNhanVien(nvXoa))
                            Console.WriteLine("Đã xóa nhân viên thành công!");
                        else
                            Console.WriteLine("Không tìm thấy nhân viên để xóa!");
                        TienIch.NganCach();
                        break;

                    case 6:
                        Console.WriteLine("=== TỔNG LƯƠNG NHÂN VIÊN ===");
                        if (ds.ListNV.Count == 0)
                            Console.WriteLine("Danh sách rỗng!");
                        else
                            Console.WriteLine($"Tổng lương: {ds.TongLuongNhanVien():N0} VNĐ");
                        TienIch.NganCach();
                        break;

                    case 7:
                        Console.WriteLine("=== NHÂN VIÊN LƯƠNG CAO NHẤT ===");
                        if (ds.ListNV.Count == 0)
                        {
                            Console.WriteLine("Danh sách rỗng!");
                        }
                        else
                        {
                            ds.NhanVienLuongCao();
                            ds.XuatDanhSach();
                        }
                        TienIch.NganCach();
                        break;

                    case 8:
                        Console.WriteLine("=== SẮP XẾP THEO NĂM VÀO LÀM ===");
                        if (ds.ListNV.Count == 0)
                        {
                            Console.WriteLine("Danh sách rỗng!");
                        }
                        else
                        {
                            ds.Sort();
                            Console.WriteLine("Danh sách sau khi sắp xếp (tăng dần theo năm):");
                            ds.XuatDanhSach();
                        }
                        TienIch.NganCach();
                        break;
                    
                    case 9:
                        Console.WriteLine("===== DANH SÁCH CÓ SẴN ĐƯỢC THÊM VÀO DANH SÁCH ======");
                        NhanVien[] dsThamSo = new NhanVien[] {
                            new NhanVien("NV999", "Nguyễn Văn Test", 2.5, 2015),
                            new NhanVien("NV888", "Trần Thị Demo", 3.0, 2018),
                            new NhanVien("NV777", "Lê Văn Sample", 1.8, 2020),
                            new NhanVien("NV666", "Phạm Thị Data", 2.2, 2012)
                        };
                        int slThem = 0;
                        int slTrung = 0;
                        foreach (NhanVien nv in dsThamSo)
                        {
                            if (ds.TimNhanVien(nv))
                            {
                                Console.WriteLine($"Mã NV: {nv.MaNV} đã tồn tại vui lòng bỏ qua..");
                                slThem++;
                            }
                            else
                            {
                                ds.AddNV(nv);
                                slThem++;
                            }
                        }
                        if (slTrung > 0)
                        {
                            Console.WriteLine($"Bỏ qua (trùng mã): {slTrung} nhân viên.");
                        }
                        
                        ds.XuatDanhSach();     
                        
                        TienIch.NganCach();
                        break;
                    case 10:
                        NhanVien max = ds.TimMaxLuongNV();
                        Console.WriteLine("Nhân viên có lương cao nhất:");
                        max.Xuat();
                        TienIch.NganCach();

                        break;
                    case 0:
                        Console.WriteLine("Tạm biệt!");
                        break;

                    default:
                        Console.WriteLine("Chức năng không hợp lệ!");
                        TienIch.NganCach();
                        break;
                }

            } while (chon != 0);
        }
                
    }
}