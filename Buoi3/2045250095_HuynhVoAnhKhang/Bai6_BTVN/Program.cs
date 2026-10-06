using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_BTVN
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            KhuTro kt = new KhuTro();
            kt.DocFileDanhSach(@"..\..\DSPhong.xml");
            kt.XuatDanhSach();

            Console.WriteLine("TỔNG TIỀN: {0:N0}", kt.TinhTongTien());
            Console.WriteLine();

            Console.WriteLine("SẮP XẾP");
            kt.SapXep();
            kt.XuatDanhSach();
            Console.WriteLine();

            Console.WriteLine("PHÒNG SỬ DỤNG NHIỀU ĐIỆN NHẤT");
            Phong p = kt.XuatThongPhongSuDungNhieuDien();
            p.Xuat();
            Console.WriteLine();    
        }
    }
}
