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
            Console.OutputEncoding =    Encoding.UTF8;
            TrungTamCNTT tt = new TrungTamCNTT();
            tt.DocFileDanhSach(@"..\..\TrungTam.xml");
            tt.XuatDanhSach();
            Console.WriteLine();

            Console.WriteLine("SẮP XẾP TRUNG BÌNH GIẢM DẦN");
            tt.SapXepDiemTrungBinh();
            Console.WriteLine();

            Console.WriteLine("SẮP XẾP HỌ TÊN TĂNG DẦN");
            tt.SapXepHoTen();
            Console.WriteLine();

            Console.WriteLine("DANH SÁCH ĐẬU");
            tt.DanhSachDau();
            Console.WriteLine();


            Console.WriteLine("ĐẾM THÍ SINH");
            tt.DemThiSinhDau();



        }
    }
}
