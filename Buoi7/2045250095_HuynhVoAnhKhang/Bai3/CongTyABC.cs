using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public abstract class CongTyABC: CongTyT, IDanhHieu
    {
        protected int namSinh;
        protected string gioiTinh;
        protected double heSoLuong;
        protected int namVaoLam;

        public static double LuongCoBan = 2340000;
       

        public int NamSinh
        {
            get { return namSinh; }
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                    namSinh = value;
                else
                    namSinh = DateTime.Now.Year;
            }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public double HeSoLuong
        {
            get { return heSoLuong; }
            set
            {
                if (value > 0)
                    heSoLuong = value;
                else
                    heSoLuong = 0;
            }
        }

        public int NamVaoLam
        {
            get
            {
                return namVaoLam;
            }
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                    namVaoLam = value;
                else
                    namVaoLam = DateTime.Now.Year;
            }
        }
        public CongTyABC(): base()
        {
            NamSinh = DateTime.Now.Year;
            GioiTinh = "NULL";
            HeSoLuong = 0;
            NamVaoLam = DateTime.Now.Year;
        }

        public CongTyABC(string ma, string ten, int namSinh, string gt, double luong, int namVaoLam)
            :base(ma,ten)
        {
            NamSinh = namSinh;
            GioiTinh = gt;
            HeSoLuong = luong;
            NamVaoLam = namVaoLam;
        }

        public abstract char XepLoai();

        public double PhuCapThamNien()
        {
            int soNamViecLam = DateTime.Now.Year - NamVaoLam;
            
            return (soNamViecLam >= 5) ? soNamViecLam * CongTyABC.LuongCoBan * 0.01 : 0;
        }

        public string XepLoaiDanhHieu()
        {
            if (Luong() > 20000)
                return "Chiến sĩ thi đua";
            else if (Luong() > 10000)
                return "Lao động tiên tiến";
            else
                return "Không";
        }
        public string NangLucNhanVien()
        {
            string dh = XepLoaiDanhHieu();
            if (dh.Equals("Chiến sĩ thi đua", StringComparison.OrdinalIgnoreCase))
                return "Năng lực tốt";
            else if (dh.Equals("Lao động tiên tiến", StringComparison.OrdinalIgnoreCase))
                return "Có năng lực";
            else
                return "Không quan tâm";
        }
        public double ThuNhap()
        {
            if (XepLoai() == 'A')
                return Luong() + PhuCapThamNien();
            else if (XepLoai() == 'B')
                return 0.75 * Luong() + PhuCapThamNien();
            else if (XepLoai() == 'C')
                return 0.5 * Luong() + PhuCapThamNien();
            else
                return 0 * Luong() + PhuCapThamNien();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($" Năm sinh: {namSinh} - Giới Tính: {gioiTinh} - " +
                               $" Hệ số lương: {heSoLuong:F2} - Năm vào làm: {namVaoLam}");
            Console.WriteLine($"Phụ cấp thâm niên: {PhuCapThamNien():N0}");
            Console.WriteLine($"Thu nhập: {ThuNhap():N0}");
            Console.WriteLine($"Xếp loại danh hiệu: {XepLoaiDanhHieu()}");
            Console.WriteLine($"Năng lực nhân viên: {NangLucNhanVien()}");
        }


    }
}
