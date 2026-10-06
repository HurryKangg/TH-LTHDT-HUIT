using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class PhanSo
    {
        private int tuSo;
        private int mauSo;
        public double GiaTriThua
        {
            get
            {
                return (double)tuSo / mauSo;
            }
        }
        public int TuSo
        {
            get { return tuSo; }
            set
            {
                    tuSo = value;
            }
        }
        public int MauSo
        {
            get { return mauSo; }
            set
            {
                if (value == 0)
                    throw new Exception("Mẫu số phải khác 0!");
                mauSo = value;

            }
        }
        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }
        public PhanSo(int tu, int mau)
        {
            this.TuSo = tu;
            this.MauSo = mau;
            ToiGianPS();
        }
        public PhanSo(PhanSo ps)
        {
            this.TuSo = ps.tuSo;
            this.MauSo = ps.mauSo;
            ToiGianPS();
        }
        public int NhapPhanSo(string tb)
        {
            while (true)
            {
                Console.Write(tb);
                if(int.TryParse(Console.ReadLine(), out int n))
                {
                    return n;
                }
                Console.WriteLine("Vui lòng nhập lại tử số!!!");
            }
        }
        public void Nhap()
        {
            TuSo = NhapPhanSo("Nhập tử số: ");

            while(true)
            {
                try
                {
                    MauSo = NhapPhanSo("Nhập mẫu số: ");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message} Vui lòng nhập lại!");
                }
            }
        }
        
        public void ToiGianPS()
        {
            int ucln = TienIch.UCLN(tuSo, mauSo);
            tuSo /= ucln;
            mauSo /= ucln;
            if(mauSo < 0)
            {
                tuSo *= -1;
                mauSo *= -1;
            }
        }
        public void Xuat()
        {
            if(mauSo == 1)
                Console.WriteLine(this.tuSo);
            else
                Console.WriteLine($"{this.tuSo} / {this.mauSo}");
        }
        public PhanSo CongPS(PhanSo ps)
        {   
            PhanSo ps1 = new PhanSo();
            ps1.tuSo = (this.tuSo * ps.mauSo) + (ps.tuSo * this.mauSo);
            ps1.mauSo = (this.mauSo * ps.mauSo);
            ps1.ToiGianPS();
            return ps1;
        }
        public PhanSo NhanPS(PhanSo ps)
        {
            PhanSo ps1 = new PhanSo();
            ps1.tuSo= (this.tuSo * ps.tuSo);
            ps1.mauSo = (this.mauSo * ps.mauSo);
            ps1.ToiGianPS();
            return ps1;
        }
    }
}
