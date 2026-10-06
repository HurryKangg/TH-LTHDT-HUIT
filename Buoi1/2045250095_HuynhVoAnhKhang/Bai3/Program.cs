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
            HinhTron hinhTron1 = new HinhTron();
            hinhTron1.Xuat();

            HinhTron hinhTron2 = new HinhTron();
            hinhTron2.Nhap();
            hinhTron2.Xuat();
        }
    }
}
