using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_BTVN
{
    public class Phong
    {
        private string maPhong;
        private int soLuongKhachTro;
        private double giaThue;
        private int soDien;
        private int loai;

        public static double GiaDien = 3500;

        public string MaPhong
        {
            get { return maPhong; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 4
                    && value.StartsWith("PT"))
                    maPhong = value;
                else
                    maPhong = "PT00";
            }
        }

        public int SoKhach
        {
            get { return soLuongKhachTro; }
            set
            {
                if (value >= 0)
                    soLuongKhachTro = value;
                else
                    soLuongKhachTro = 0;
            }
        }

        public double GiaThue
        {
            get { return giaThue; }
            set
            {
                if(value >= 0)
                    giaThue = value;
                else
                    giaThue = 0;
            }
        }

        public int SoDien
        {
            get { return soDien; }
            set
            {
                if (value >= 0)
                    soDien = value;
                else
                    soDien = 0;
            }
        }

        public int Loai
        {
            get { return loai; }
            set
            {
                if (value == 1 || value == 0)
                    loai = value;
                else
                    loai = 0;

            }
        }

        public Phong()
        {
            MaPhong = "PT00";
            SoKhach = 3;
            SoDien = 0;
            Loai = 1;
            GiaThue = 1500000;
        }

        public Phong(string ma, int khach, double gia, int coMayLanh, int dien)
        {
            this.MaPhong = ma;
            this.SoKhach = khach;
            this.GiaThue = gia;
            this.Loai = coMayLanh;
            this.SoDien = dien;
        }

        public Phong(Phong obj)
        {
            this.MaPhong = obj.maPhong;
            this.SoKhach = obj.soLuongKhachTro;
            this.GiaThue = obj.giaThue;
            this.SoDien = obj.soDien;
            this.Loai = obj.loai;
        }

        public double TienPhong()
        {
            return giaThue + (soDien * Phong.GiaDien) + PhiMayLanh();
        }

        public double PhiMayLanh()
        {
            if (loai == 1)
                return soLuongKhachTro * 50000;
            return 0;
        }

        public void Xuat()
        {
            string mayLanh = (Loai == 1) ? "Có" : "Không";
            Console.WriteLine(
                $"{MaPhong,-10} {SoKhach,-10} {GiaThue,-15:N0} {SoDien,-10} " +
                $"{mayLanh,-10} {TienPhong(),-15:N0}"
            );
        }
    }
}
