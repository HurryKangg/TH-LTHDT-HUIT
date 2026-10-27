using Bai4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    public class XeGanMay : TaiKhoanTaiXe
    {

        
        public XeGanMay():base()
        {
            
        }
        public XeGanMay(string user, string pass, string phone,bool trthai
                    ,string ma, string ten): 
            base(user,pass,phone,trthai, ma,ten, new GanMay())
        {

        }

        public override double Phi()
        {
            return 0.05;
        }

        public override double TinhTienChuyenDi(double khoangCach, DateTime time)
        {
            double gia = 0;
            if (khoangCach <= 2)
                gia = khoangCach * 8000;
            else 
                gia = 2 * 8000 + (khoangCach - 2) * 5000;
            if(time.Hour >= 22 || time.Hour < 5)
            {
                gia += khoangCach * 3000;
            }
            return gia;
        }
    }
}
