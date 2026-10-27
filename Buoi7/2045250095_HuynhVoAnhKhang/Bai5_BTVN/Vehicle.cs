using Bai4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    public class Vehicle: IVehicle
    {
        protected string loaiXe;
        protected string maXe;
        protected string bienSo;
        public string LoaiXe
        {
            get { return loaiXe; }
            set { loaiXe = value; }
        }

        public string MaXe{
            get{return maXe;}
            set{maXe = value;}
        }

        public string BienSo{
            get{return bienSo;}
            set{bienSo = value;}
        }

        public Vehicle()
        {
            LoaiXe = "NO NAME";
        }

        public Vehicle(string ma, string bienSo, string loai)
        {
            this.MaXe = ma;
            this.BienSo = bienSo;
            this.LoaiXe = loai;
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"Loại: {loaiXe}");
        }
     
    }
}
