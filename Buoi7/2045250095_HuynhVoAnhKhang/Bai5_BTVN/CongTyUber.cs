using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    public class CongTyUber
    {
        protected string ganMay;
        protected string oTo;
        protected string otoTai;

        public string GanMay
        {
            get { return ganMay; }
            set { ganMay = value; }
        }
        public string OTo
        {
            get { return oTo; }
            set { otoTai = value; }
        }
        public string OtoTai
        {
            get { return otoTai; }
            set { otoTai = value; }
        }

        public CongTyUber()
        {
            GanMay = "HONDA";
            OTo = "VINFAST";
            OtoTai = "CONTAINER";
        }

        public CongTyUber(string may, string o, string tai)
        {
            this.ganMay = may;
            this.oTo = o;
            this.otoTai = tai;
        }

    }
}
