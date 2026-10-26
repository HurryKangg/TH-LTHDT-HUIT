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
            Console.OutputEncoding = Encoding.UTF8;
            TongCongTy ds = new TongCongTy();
            ds.DocFile(@"..\..\TongCongTy.xml");
            ds.XuatDS();
            Console.WriteLine();

            ds.DemSoLuongCongTyCon();
            Console.WriteLine();

            ds.NangLucTot();
            Console.WriteLine();

            ds.ChuaXetThiDua();
            Console.WriteLine();

            ds.XuatThongTinLaoDongTienTienABC();
            Console.WriteLine();
        }
    }
}
