using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class HangHoa
    {
        private string maHH;
        private string tenHH;

        public string MaHH
        {
            get { return maHH; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 5 &&
                    value.StartsWith("HH") && value.Substring(2).All(char.IsDigit))
                    maHH = value;
                else
                    maHH = "HH001";
            }
        }

        public string TenHH { get { return tenHH; } set { tenHH = value; } }

        public HangHoa()
        {
            MaHH = "HH001";
            TenHH = "NO NAME";
        }
        public HangHoa(string ma)
        {
            MaHH = ma;
            TenHH = "NO NAME";
        }

        public HangHoa(string ma, string ten)
        {
            MaHH = ma;
            TenHH = ten;
        }

        public virtual void Nhap()
        {
            while (true)
            {
                Console.Write("Nhap ma hang hoa: ");
                string inputMa = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputMa))
                {
                    maHH = "HH001";
                    break;
                }
                else
                {
                    maHH = inputMa;
                }
            }

            while (true)
            {
                Console.Write("Nhap ten hang hoa: ");
                string inputTen = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputTen))
                {
                    maHH = "NO NAME";
                    break;
                }
                else
                {
                    maHH = inputTen;
                }
            }
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Ma: {maHH}");
            Console.WriteLine($"Ten: {tenHH}");
        }
    }
}
