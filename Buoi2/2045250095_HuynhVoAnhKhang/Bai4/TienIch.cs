using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public static class TienIch
    {
        public static int NhapSo(string tb)
        {
            while (true)
            {
                Console.Write(tb);
                if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
                {
                    return n;
                }
                Console.WriteLine("Vui lòng nhập lại số !!!");
            }
        }
        public static float NhapDiem(string tb)
        {
            while (true)
            {
                Console.Write(tb);
                if (float.TryParse(Console.ReadLine(), out float f) && f >= 0 && f <= 10)
                {
                    return f;
                }
                Console.WriteLine("Vui lòng nhập lại điểm!!!");
            }
        }
    }
}
