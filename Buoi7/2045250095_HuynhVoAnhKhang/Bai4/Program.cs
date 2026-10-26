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
            Console.OutputEncoding = Encoding.UTF8;
            DSHoaDon ds = new DSHoaDon();
            ds.DocFile(@"..\..\DSHoaDon.xml");
            ds.XuatDS();
            Console.WriteLine();

            Console.WriteLine($"TỔNG THÀNH TIỀN: {ds.TongTinhThanhTien():N0}");
            Console.WriteLine();

            HoaDon kq = ds.TongThanhTienLonNhat();
            kq.Xuat();
            Console.WriteLine();

            ds.DemSoKhachHangVIP();
            Console.WriteLine();

            Console.WriteLine($"TỔNG TẠM ỨNG: {ds.TongTamUng():N0}");
            Console.WriteLine();

            ds.SapXep();
            ds.XuatDS();
            Console.WriteLine();

        }
    }
}
