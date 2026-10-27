using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    public class XeTaiOto : TaiKhoanTaiXe, ITraPhi
    {
        public XeTaiOto(string user, string pass, string phone, bool trThai,
                        string ma, string ten, double ton):base(user,pass,phone,trThai,ma,ten,new Tai(ton))
        {
            tai = (Tai)HinhThuc;

        }
        public override double Phi()
        {
            return 0.15;
        }

        public override double TinhTienChuyenDi(double khoangCach, DateTime hour)
        {
            double gia = 0;
            if(tai.Ton <= 3)
            {
                if (khoangCach <= 5) gia = khoangCach * 60000;
                else if (khoangCach <= 10) gia = 5*60000 + (khoangCach - 5)*50000;
                else gia = 5 * 60000 + 5 * 50000 + (khoangCach-10) * 30000;
            }
            else
            {
                if (khoangCach <= 5) gia = khoangCach * 70000;
                else if (khoangCach <= 10) gia = (khoangCach - 5) * 60000 + 70000 * 5;
                else gia = 5 * 70000 + 5 * 60000 + (khoangCach - 10) * 40000;
            }

            gia += khoangCach * 5000;
            return gia;
        }

        public double TraPhiLaiChoCongTy()
        {
            return DoanhThuTrongNgay > 3000000 ? 300000 : 0;
        }
    }
}
