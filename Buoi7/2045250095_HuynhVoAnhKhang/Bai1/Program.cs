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
            CongTy ds = new CongTy();
            ds.DocFile(@"..\..\congty.xml");
            ds.XuatDS();
            Console.WriteLine();

            Console.WriteLine("Tổng số tiền: {0:N0}", ds.TongTien());
            Console.WriteLine();

            Console.WriteLine("Tiền tro gia: {0:N0}", ds.TienTroGia());
            Console.WriteLine();

            Console.WriteLine("SỐ LƯỢNG CAO NHẤT");
            CongTyABC kq = ds.XuatSoLuongMuaNhieu();
            kq.Xuat();
            Console.WriteLine();

            Console.WriteLine("THÀNH TIỀN CAO NHẤT");
            CongTyABC kq1 = ds.XuatThanhTienCao();
            kq1.Xuat();

            Console.WriteLine("TỔNG SỐ TIỀN CHIẾT KHẤU KHÁCH HÀNG CÔNG TY: {0:N0}", ds.TongSoTienKHCongTyChietKhau());
            Console.WriteLine();

            Console.WriteLine("SẮP XẾP");
            ds.SapXep();
            ds.XuatDS();
            Console.WriteLine();

            Console.WriteLine("DANH SÁCH CÔNG TY ĐẠI LÝ CẤP 1");
            ds.XuatDanhSachDaiLy();
        }
    }
}
