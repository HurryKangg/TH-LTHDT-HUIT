using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class NhanVienKD : NhanVienABC
    {
        int soToiThieu;
        int soBanHangThucTe;
        static double HoaHong = 0.15;
        public int SoToiThieu { get { return soToiThieu; } set { soToiThieu  = value; } }
        public int SoBanHangThucTe { get { return soBanHangThucTe; } set { soBanHangThucTe= value; } }
        public NhanVienKD() : base() { }
        public NhanVienKD(string ma, string ten, int namSinh, string gt, double he, int namVL, int soToiThieu,int soThucTe) : base(ma, ten, namSinh, gt, he, namVL)
        {
            SoToiThieu = soToiThieu;
            SoBanHangThucTe = soThucTe;
        }

        public override double Luong()
        {
            if (soBanHangThucTe > soToiThieu)
                return heSoLuong * NhanVienABC.LuongCoBan + NhanVienKD.HoaHong * (soBanHangThucTe - soToiThieu);
            return heSoLuong * NhanVienABC.LuongCoBan; 
        }

        public override char XepLoai()
        {
            if (soBanHangThucTe > 2.0*soToiThieu)
                return 'A';
            else if (soBanHangThucTe < 0.5*soToiThieu)
                return 'D';
            else if (soBanHangThucTe >= soToiThieu)
                return 'B';
            else
                return 'C';
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"So toi thieu: {soToiThieu}");
            Console.WriteLine($"So ban hang thuc te: {soBanHangThucTe}");
            Console.WriteLine($"Xep loai: {XepLoai()}");
            Console.WriteLine($"Luong: {Luong():N0}");
        }


    }
}
