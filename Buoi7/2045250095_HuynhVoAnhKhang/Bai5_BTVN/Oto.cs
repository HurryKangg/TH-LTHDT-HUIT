using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    public class Oto : Vehicle
    {
        protected int seats;
        public int Seats { get { return seats; } set { seats = value; } }
        public Oto() : base()
        {

        }

        public Oto(int s, string maXe, string bienSo) : base(maXe, bienSo, "O-to")
        {
            this.Seats = s;
        }
    }
}
