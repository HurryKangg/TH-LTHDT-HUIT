using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public static class TienIch
    {
        public static void NganCach()
        {
            Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
            Console.ReadKey();
            Console.Clear();
        }
        public static void TieuDeMH()
        {
            Console.WriteLine("{0,-8} {1,-25} {2,-10} {3,-8} {4,-15} {5,-10} {6,-15}",
                "Mã MH", "Tên MH", "Điểm TX", "Điểm GK", "Điểm CK", "Tổng Kết", "Kết Quả");
            Console.WriteLine(new string('-', 97));

        }
        public static void TieuDeHS()
        {
            Console.WriteLine("{0,-8} {1,-25}", "Mã HS", "Tên HS");
            Console.WriteLine(new string('-', 97));
        }
        public static int NhapSo(string tb)
        {
            while (true)
            {
                Console.Write(tb);
                if(int.TryParse(Console.ReadLine(), out int n))
                {
                    return n;
                }
                Console.WriteLine("Vui lòng nhập số phải lớn 0!!!");
            }
        }
        public static float NhapDiem(string tb)
        {
            float diem;
            while (true)
            {
                Console.Write(tb);
                if (string.IsNullOrWhiteSpace(tb))
                {
                    return 0;
                }
                else if (float.TryParse(Console.ReadLine(), out diem) && diem > 0)
                {
                    return diem;
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập lại điểm > 0");
                }

            }
        }
    }
}
