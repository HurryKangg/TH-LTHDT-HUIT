using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    public class XeOto : TaiKhoanTaiXe
    {
        
        public XeOto(string user, string pass, string phone, bool trThai,
                        string ma, string ten, int seats):base(user, pass, phone, trThai, ma, ten, new Oto(seats))
        {
            oto = (Oto)HinhThuc;
        }
        public override double Phi()
        {
            return 0.1;
        }

        public override double TinhTienChuyenDi(double khoangCach, DateTime hour)
        {
            double gia = 0;
            if(oto.Seats == 4)
            {
                if (khoangCach <= 2) gia = khoangCach * 15000;
                else if (khoangCach <= 7) gia = (khoangCach - 2) * 12000 + 15000 * 2;
                else gia = 2 * 15000 + 5 * 12000 + (khoangCach - 7) * 8000;
            } else if(oto.Seats == 7)
            {
                if (khoangCach <= 2) gia = khoangCach * 17000;
                else if (khoangCach <= 7) gia = (khoangCach - 2) * 15000 + 17000*2;
                else gia = 2 * 17000 + 5 * 15000 + (khoangCach - 7) * 10000;
            }

            gia += khoangCach * 500;
            return gia;
        }

        public double TraPhiLaiChoCongTy()
        {
            return DoanhThuTrongNgay > 2000000 ? 200000 : 0;
        }
    }
}
