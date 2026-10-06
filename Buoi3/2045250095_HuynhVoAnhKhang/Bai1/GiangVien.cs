using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class GiangVien
    {
        private string hoTenGV;
        private int soNhomHD;
        
        public string HoTenGV
        {
            get {  return hoTenGV; }
            set { hoTenGV = value; }
        }
        public int SoNhomHD
        {
            get { return soNhomHD; }
            set { soNhomHD = value; }
        }

        public GiangVien()
        {
            HoTenGV = "No Name";
            SoNhomHD = 0;
        }

        public GiangVien(string ten, int so)
        {
            HoTenGV = ten;
            SoNhomHD = so;
        }

        public void XuatGV()
        {
            Console.WriteLine($"{hoTenGV, -20} {soNhomHD, -25} ");
        }
    }
}
