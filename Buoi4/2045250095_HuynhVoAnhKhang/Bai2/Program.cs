using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DSHangHoa ds = new DSHangHoa();
            ds.DocFileDanhSach(@"..\..\DanhMucHangHoa.xml");
            ds.XuatDanhSach();
            Console.WriteLine();

            Console.WriteLine("DANH SACH LON HOAC CHAI");
            ds.XuatDanhSachLonVaChai();
            Console.WriteLine();

            Console.WriteLine("TONG TIEN DANH MUC: {0:N0}", ds.TinhTongTienDanhMuc());
        }
    }
}
