using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class ListHocSinh
    {

        private List<HocSinh> listHS;

        public List<HocSinh> ListHS { get { return listHS; } set { listHS = value; } }

        public ListHocSinh()
        {
            listHS = new List<HocSinh>();
        }

        public void NhapDanhSachHS()
        {
            int n = TienIch.NhapSo("Nhập số lượng học sinh: ");

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"HỌC SINH THỨ {i + 1}");
                HocSinh dsHS = new HocSinh();
                dsHS.NhapThongTin();
                listHS.Add( dsHS );
            }
            Console.WriteLine("\nĐã nhập xong danh sách học sinh!");
        }
        public void XuatDanhSachHS()
        {
            if(listHS.Count == 0)
            {
                Console.WriteLine("DANH SÁCH HỌC SINH ĐAN RỖNG VUI LÒNG THÊM");
                return;
            }
            Console.WriteLine("\n================ DANH SÁCH HỌC SINH ================");
            TienIch.TieuDeHS();
            foreach(HocSinh dsHS in listHS)
            {
                dsHS.XuatThongTin();
            }
        }
        public void TinhTatCaTrungBinhHS()
        {
            if(listHS.Count == 0)
            {
                Console.WriteLine("Danh sách học sinh trống!");
                return;
            }
            Console.WriteLine("\n================ ĐIỂM TRUNG BÌNH HỌC KỲ ================");
            foreach(HocSinh dsHS in listHS)
            {
                Console.WriteLine($"{dsHS.MaHS} - {dsHS.TenHS}: {dsHS.DTB():F2}");
            }
        }
        public void XepLoaiTatCa()
        {
            if (listHS.Count == 0)
            {
                Console.WriteLine("Danh sách học sinh trống!");
                return;
            }
            Console.WriteLine("\n================ XẾP LOẠI HỌC SINH ================");
            foreach(HocSinh dsHS in listHS)
            {
                Console.WriteLine($"{dsHS.MaHS} - {dsHS.TenHS}: {dsHS.XepLoai()}");
            }
        }

        public void XetKetQua()
        {
            if(listHS.Count == 0)
            {
                Console.WriteLine("DANH SÁCH HỌC SINH RỖNG");
                return;
            }

            Console.WriteLine("\n================ KẾT QUẢ HỌC TẬP ================");
            foreach(HocSinh dsHS in listHS)
            {
                Console.WriteLine($"{dsHS.MaHS} - {dsHS.TenHS}: {dsHS.KetQuaHocTapHocSinh()}");
            }
        }

        public void InKetQuaDat()
        {
            if(listHS.Count == 0)
            {
                Console.WriteLine("DANH SÁCH KẾT QUẢ HỌC SINH ĐẠT RỖNG");
                return;
            }

            Console.Write("Nhập mã học sinh đã đạt môn: ");
            string ma = Console.ReadLine();

            bool timThay  = false;
            foreach(HocSinh dsHS in listHS)
            {
                if(dsHS.MaHS.Equals(ma, StringComparison.OrdinalIgnoreCase))
                {
                    dsHS.DanhSachMonDat();
                    timThay = true;
                    break;
                }
            }
            if (!timThay)
                Console.WriteLine("Không tìm thấy học sinh có mã vừa nhập.");
        }
        public void ThemHocSinh()
        {
            Console.WriteLine("\n========== THÊM HỌC SINH MỚI ==========");
            HocSinh hs = new HocSinh();
            hs.NhapThongTin();
            listHS.Add(hs);
            Console.WriteLine("Đã thêm học sinh vào danh sách....");
        }
        public void TimTheoMaHS(){
            if(listHS.Count == 0)
            {
                Console.WriteLine("Dach sách học sinh bị rỗng");
                return;
            }
            Console.Write("Tìm mã học sinh: ");
            string ma = Console.ReadLine();
            bool timThay = false;
            foreach(HocSinh hs in listHS)
            {
                if(hs.MaHS.Equals(ma, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n--- Thông tin học sinh ---");
                    TienIch.TieuDeHS();
                    hs.XuatThongTin();
                    Console.WriteLine($"Điểm trung bình: {hs.DTB():F2}");
                    Console.WriteLine($"Xếp loại: {hs.XepLoai()}");
                    Console.WriteLine($"Kết quả: {hs.KetQuaHocTapHocSinh()}");
                    timThay = true;
                    break;
                }
            }
            if (!timThay)
                Console.WriteLine("Không tìm thấy học sinh có mã vừa nhập.");
        }

    }
}
