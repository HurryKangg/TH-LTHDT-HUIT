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
            Console.OutputEncoding = Encoding.UTF8;
            BDS ds = new BDS();
            ds.DocFile(@"..\..\BDS.xml");
            ds.XuatDS();

            Console.WriteLine("TỔNG GIÁ BÁN: {0:N0}", ds.TongGiaBan());
            Console.WriteLine();

            Console.WriteLine("TỔNG KINH DOANH: {0:N0}", ds.TongKinhDoanh());
            Console.WriteLine();
        }
    }
}
