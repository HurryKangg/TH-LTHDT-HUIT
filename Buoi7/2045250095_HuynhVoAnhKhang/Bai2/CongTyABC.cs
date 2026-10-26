using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public abstract class CongTyABC
    {
        protected string maSo;
        protected double chieuDai;
        protected double chieuRong;

        public string MaSo
        {
            get { return maSo; }
            set { maSo = value; }
        }
        public double ChieuDai
        {
            get { return chieuDai; }
            set {  chieuDai = value; }
        }
        public double ChieuRong
        {
            get { return chieuRong; }
            set { chieuRong = value; }
        }
        public CongTyABC()
        {
            MaSo = "CT000";
            ChieuDai = 0;
            ChieuRong = 0;
        }

        public CongTyABC(string ma, double dai, double rong)
        {
            MaSo = ma;
            ChieuDai = dai;
            ChieuRong = rong;
        }

        public abstract double GiaBan();
        public double DienTich()
        {
            return ChieuDai * ChieuRong;
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Mã số: {maSo} - Chiều dài: {ChieuDai} - Chiều rộng: {chieuRong} -" +
                                $" Diện tích: {DienTich():F2}");
        }

    }
}
