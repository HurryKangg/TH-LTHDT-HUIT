using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public abstract class KhachHang
    {
        protected string maKH;
        protected string tenKH;
        protected int sl;
        protected double gia;

        public static double VAT = 0.1;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        public int Sl
        {
            get { return sl; }
            set { sl = value; }
        }
        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        public KhachHang()
        {
            MaKH = "KH001";
            TenKH = "No Name";
            Sl = 0;
            Gia = 0;
            
        }
        public KhachHang(string ma, string ten, int sl, double gia)
        {
            this.MaKH = ma;
            this.TenKH = ten;
            this.Sl = sl;
            this.Gia = gia;
        }

        public abstract double ChietKhau();
        public double ThanhTien()
        {
            return (sl * gia) - ChietKhau() + (VAT * (sl * gia));
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"Ma khach hang: {maKH}");
            Console.WriteLine($"Ten khach hang: {tenKH}");
            Console.WriteLine($"So luong: {sl}");
            Console.WriteLine($"Gia: {gia:N0}");
        }
    }
}
