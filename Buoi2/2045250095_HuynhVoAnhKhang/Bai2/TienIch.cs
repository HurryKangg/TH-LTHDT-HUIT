using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public static class TienIch
    {
        public static void NganCach()
        {
            Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
            Console.ReadKey();
            Console.Clear();
        }
        public static void TieuDe()
        {
            Console.WriteLine("{0,-8} {1,-25} {2,-10} {3,-8} {4,-15} {5,-10} {6,-15}",
                "Mã NV", "Tên NV", "Hệ Số", "Năm Vào", "Lương CB", "HSCTN", "Lương NV");
            Console.WriteLine(new string('-', 97));
        }
        public static int NhapSoLuong(string tb)
        {
            while (true)
            {
                Console.Write(tb);
                if (int.TryParse(Console.ReadLine(), out int sl) && sl > 0)
                {
                    return sl;
                }
                Console.WriteLine("Vui lòng nhập lại số lượng không âm và không phải chữ!!");
            }
        }
        public static int NhapSoNguyen(string tb)
        {
            while (true) 
            {
                Console.Write(tb);
                if (int.TryParse(Console.ReadLine(), out int sl) && sl > 0)
                {
                    return sl;
                }
                Console.WriteLine("Vui lòng nhập lại số lượng không âm và không phải chữ!!");
            }
        }
    }
}
