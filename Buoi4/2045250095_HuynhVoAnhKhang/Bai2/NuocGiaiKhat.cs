using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class NuocGiaiKhat: HangHoa
    {
        string donVi;
        int soLuong;
        double donGia;

        public static double TiLeChietKhau = 0.05;
        public string DonVi
        {
            get { return donVi; }
            set
            {
                if (value == "Ket" || value == "Thung" || value == "Chai" ||
                    value == "Lon")
                    donVi = value;
                else
                    donVi = "Ket";
            }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set
            {
                if (value >= 0)
                    soLuong = value;
            }
        }
        public double DonGia
        {
            get { return donGia; }
            set
            {
                if (value >= 0)
                    donGia = value;
            }
        }
        public NuocGiaiKhat(): base()
        {
            DonVi = "Ket";
            SoLuong = 0;
            DonGia = 0;
        }

        public NuocGiaiKhat(string ma, string ten, string dv,int so,double gia):
            base(ma, ten)
        {
            DonVi = dv;
            SoLuong = so;
            DonGia = gia;
        }
        public override void Nhap()
        {
            base.Nhap();
            while (true)
            {
                Console.Write("Nhap don vi (1: Ket, 2: Thung, 3: Chai, 4: Lon): ");
                string ip = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ip))
                {
                    donVi = "Ket";
                }
                else
                {
                    if (ip == "1" || ip.Equals("Ket", StringComparison.OrdinalIgnoreCase))
                    {
                        donVi = "Ket";
                    }
                    else if (ip == "2" || ip.Equals("Thung", StringComparison.OrdinalIgnoreCase))
                    {
                        donVi = "Thung";
                    }
                    else if (ip == "3" || ip.Equals("Chai", StringComparison.OrdinalIgnoreCase))
                    {
                        donVi = "Chai";
                    }
                    else if (ip == "4" || ip.Equals("Lon", StringComparison.OrdinalIgnoreCase))
                    {
                        donVi = "Lon";
                    }
                    else
                    {
                        break;
                    }
                }
            }

            SoLuong = TienIch.NhapSo("Nhap so luong: "); 
            DonGia = TienIch.NhapGia("Nhap gia: ");

        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Don vi: {donVi}");
            Console.WriteLine($"So luong: {soLuong}");
            Console.WriteLine($"Don gia: {donGia:N0}");
            Console.WriteLine($"Tong tien: {TinhTong():N0}");
        }

        public double TinhTong()
        {
            double thanhTien = 0;
            if (donVi.Equals("Ket", StringComparison.OrdinalIgnoreCase) ||
                donVi.Equals("Thung", StringComparison.OrdinalIgnoreCase))
                thanhTien = soLuong * donGia;
            else if (donVi.Equals("Chai", StringComparison.OrdinalIgnoreCase))
                thanhTien = soLuong * donGia / 20;
            else if (donVi.Equals("Lon", StringComparison.OrdinalIgnoreCase))
                thanhTien = soLuong * donGia / 24;
            else
                thanhTien = 0;

            return thanhTien * (1 - NuocGiaiKhat.TiLeChietKhau);
        }

    }
}
