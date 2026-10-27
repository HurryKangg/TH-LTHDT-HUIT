using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    public class Tai: Vehicle
    {
        double ton;
        public double Ton
        {
            get { return ton; }
            set { ton = value; }
        }

        public Tai():base()
        {
            
        }

        public Tai(string maXe, string bienSo, double t) : base(maXe, bienSo, "Xe tai")
        {
            this.ton = t;
        }
    }
}
