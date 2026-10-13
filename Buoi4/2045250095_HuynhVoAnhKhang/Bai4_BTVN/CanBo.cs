using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_BTVN
{
    public class CanBo: NhanVien
    {
        string chucVu;
        int thamNienQuanLy;

        public string ChucVu
        {
            get { return chucVu; }
            set
            {
                if (value == "Giam doc" || value == "Truong phong" || value == "Pho phong")
                    chucVu = value;
                else
                    chucVu = "Giam doc";
            }
        }

        public int ThamNienQuanLy
        {
            get { return thamNienQuanLy; }
            set { thamNienQuanLy = value; }
        }

        public CanBo(): base()
        {
            MaNV = "NV009";
            TenNV = "Dieu hien";
            HeSoLuong = 4.67;
            ChucVu = "Giam doc";
            ThamNienQuanLy = 10;
        }

        public CanBo(string ma, string ten, double heSL, string cv, int nam) : base(ma, ten, heSL)
        {
            ChucVu = cv;
            ThamNienQuanLy = nam;
        }

        public override double TinhThuNhap()
        {
            return base.TinhThuNhap() + (1500000 * HeSoLanhDao());
        }

        public double HeSoLanhDao()
        {
            if (chucVu == "Giam doc")
                return 7.0;
            else if (chucVu == "Truong phong")
                return 6.0;
            else
                return 1.0;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Chuc vu: {chucVu}");
            Console.WriteLine($"Tham nien: {thamNienQuanLy}");
            Console.WriteLine($"Thu nhap: {TinhThuNhap():N0}");
        }
    }
}
