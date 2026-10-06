using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public static class TienIch
    {
        public static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 || b == 0) return a + b;
            else
            {
                while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
            }
            return a;
        }

        public static int NhapSoNguyen(string tb)
        {
            while (true)
            {
                Console.Write(tb);
                if (int.TryParse(Console.ReadLine(), out int n))
                    return n;
                Console.WriteLine("Vui lòng nhập số nguyên!");
            }
        }
    }
}
