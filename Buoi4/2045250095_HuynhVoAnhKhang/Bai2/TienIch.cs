using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public static class TienIch
    {
        public static double NhapGia(string tb)
        {
            while (true)
            {
                Console.Write(tb);
                if(double.TryParse(Console.ReadLine(), out double so) && so >= 0)
                {
                    return so;
                }
                Console.WriteLine("VUI LONG NHAP LAI SO");               
            }
        }

        public static int NhapSo(string tb)
        {
            while (true)
            {
                Console.Write(tb);
                if (int.TryParse(Console.ReadLine(), out int so) && so >= 0)
                {
                    return so;
                }
                Console.WriteLine("VUI LONG NHAP LAI SO");
            }
        }
    }
}
