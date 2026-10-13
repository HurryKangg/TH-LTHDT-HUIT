using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class CanBo: NhanVien
    {
        string chucVu;
        double heSoPhuCapChucVu;
        string phongBan;
        public string ChucVu
        {

            get { return chucVu; }
            set
            {
                if(value == "Giam doc" || value == "Pho giam doc" || value =="Truong phong" || value == "Pho truong phong")
                    chucVu = value;
                else
                    chucVu = value;
            }
        }
        public double HeSoPhuCapChucVu
        {
            get { return heSoPhuCapChucVu; }
            set
            {
                if (value >= 0)
                    heSoPhuCapChucVu = value;
                else
                    heSoPhuCapChucVu = 0;
            }
        }

        public string PhongBan
        {
            get { return phongBan; }
            set { phongBan = value; }
        }

        public CanBo(): base()
        {
            ChucVu = "Truong phong";
            HeSoPhuCapChucVu = 5.0;
            PhongBan = "Hanh chinh";
        }

        public CanBo(string ma, string ten, double heSoLuong, string chucVu, double heSoPhuCapChucVu)
        {
            MaNV = ma;
            TenNV = ten;
            HeSoLuong = heSoLuong;
            ChucVu = chucVu;
            NamVaoLam = DateTime.Now.Year;
            HeSoPhuCapChucVu = heSoPhuCapChucVu;
            SoNgayNghi = 1;
            PhongBan = "Hanh chinh";
        }

        public CanBo(string ma, string ten, int nam, double heSoLuong, int soNgayNghi, string chucVu, double heSoPhuCap, string phongBan):
            base(ma, ten, nam, heSoLuong, soNgayNghi)
        {
            ChucVu = chucVu;
            HeSoPhuCapChucVu = heSoPhuCap;
            PhongBan = phongBan;
        }

        public override char XepLoaiThiDua()
        {
            return 'A';
        }

        public double PhuCapLanhDao()
        {
            return heSoPhuCapChucVu * NhanVien.LuongCoBan;
        }

        public override double TinhLuong()
        {
            return base.TinhLuong() + PhuCapLanhDao();
        }

        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"Chuc vu: {chucVu} | He so phu cap chuc vu: {heSoPhuCapChucVu} | Phong ban: {phongBan}" +
                $"Xep loai: {XepLoaiThiDua()} | Phu cap lanh dao: {PhuCapLanhDao():N0} | Luong: {TinhLuong():N0}");

        }





    }
}
