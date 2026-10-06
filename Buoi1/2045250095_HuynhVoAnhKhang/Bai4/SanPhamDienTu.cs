using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class SanPhamDienTu
    {
        private string hangSX;
        private string soSeri;
        private string tenSP;
        private double gia;
        private string loaiSP;
        public static double VAT = 0.1;
        public string HangSX
        {
            get { return hangSX; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    hangSX = value;
                else
                    hangSX = "Chưa xác định";
            }
        }
        public string SoSeri
        {
            get { return soSeri; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.StartsWith("S"))
                    soSeri = value;
                else
                    soSeri = "S000";
            }
        }
        public string TenSP
        {
            get { return tenSP; }
            set
            {
                if (!string.IsNullOrEmpty(value)) 
                    tenSP = value;
            }
        }
        public double Gia
        {
            get { return gia; }
            set
            {
                if (value > 4)
                    gia = value;
                else 
                    throw new ArgumentException("Nhập sai vui lòng nhập lại vì giá > 4");
            }
        }
        public string LoaiSP
        {
            get { return loaiSP; }
            set
            {
                if (value == "May tinh de ban" || value == "May tinh xach tay" || value == "Dien thoai di dong")
                    loaiSP = value;
                else
                    loaiSP = "Dien thoai di dong";
            }
        }
        public SanPhamDienTu()
        {
            hangSX = "Chua xac dinh";
            soSeri = "S000";
            tenSP = "San pham";
            gia = 5;
            loaiSP = "Dien thoai di dong";
        }
        public SanPhamDienTu(string hangSX, string soSeri, string tenSP, double gia, string loaiSP)
        {
            this.HangSX = hangSX;
            this.SoSeri = soSeri;
            this.TenSP = tenSP;
            this.Gia = gia;
            this.LoaiSP = loaiSP;
        }
        public SanPhamDienTu(SanPhamDienTu sp)
        {
            this.HangSX = sp.hangSX;
            this.SoSeri = sp.soSeri;
            this.TenSP = sp.tenSP;
            this.Gia = sp.gia;
            this.LoaiSP = sp.loaiSP;
        }
        public double PhiBaoHanh()
        {
            double phi = 0;
            if (LoaiSP == "May tinh de ban")
                phi = 0.08 * Gia;
            else if (LoaiSP == "May tinh xach tay")
                phi = 0.05 * Gia;
            else if (LoaiSP == "Dien thoai di dong")
                phi = Math.Min(0.1 * Gia, 2);
            return phi;
        }
        public double UuDai()
        {
            if (LoaiSP == "Dien thoai di dong" && HangSX.ToLower() == "samsung")
            {
                return 0.5;
            }
            return 0;
        } 
        public double Thue()
        {
            return Gia * VAT;
        }

        public double ThanhTien()
        {
            return Gia + PhiBaoHanh() - UuDai() + Thue();
        }
        public string KTNhapTen(string tb)
        {
            while (true)
            {
                Console.Write(tb);
                string nhapTen = Console.ReadLine();
                if (!string.IsNullOrEmpty(nhapTen))
                {
                    return nhapTen;
                }
                Console.WriteLine("Vui lòng nhập lại: nhập tên chứ không nhập số!!");
            }
        }
        public double KTNhapGia(string tb)
        {
            while (true)
            {
                Console.Write(tb);
                string nhapGia = Console.ReadLine();
                if(double.TryParse(nhapGia, out double gia) && gia > 0)
                {
                    return gia;
                }
                Console.WriteLine("Vui lòng nhập lại: giá phải là dương !!! ");
            }
        }
        public void Nhap()
        {
            while (true)
            {
                Console.Write("Nhập hãng sản xuất (1. Samsung / 2. Iphone): ");
                string ktHang = Console.ReadLine();
                if (ktHang == "1" || ktHang.Equals("Samsung", StringComparison.OrdinalIgnoreCase))
                {
                    HangSX = "SamSung";
                    break;
                }
                else if (ktHang == "2" || ktHang.Equals("Iphone", StringComparison.OrdinalIgnoreCase))
                {
                    HangSX = "Iphone";
                    break;
                }
                else
                {
                    HangSX = ktHang;
                    break;
                }
            }
            Console.Write("Nhập số seri: ");
            SoSeri = Console.ReadLine();
            
            TenSP = KTNhapTen("Nhập tên sản phẩm: ");

            Gia = KTNhapGia("Nhập giá: ");
            
            while (true)
            {
                Console.Write("Nhập loại sản phẩm(1. May tinh de ban / 2. May tinh xach tay / 3. Dien thoai di dong): ");
                string ktLoai = Console.ReadLine();
                if (ktLoai == "1" || ktLoai.Equals("May tinh de ban", StringComparison.OrdinalIgnoreCase))
                {
                    LoaiSP = "May tinh de ban";
                    break;
                }
                else if (ktLoai == "2" || ktLoai.Equals("May tinh xach tay", StringComparison.OrdinalIgnoreCase))
                {
                    LoaiSP = "May tinh xach tay";
                    break;
                }
                else if (ktLoai == "3" || ktLoai.Equals("Dien thoai di dong", StringComparison.OrdinalIgnoreCase))
                {
                    LoaiSP = "Dien thoai di dong";
                    break;
                }
                else
                {
                    LoaiSP = ktLoai;
                    break;
                }
            }
              
        }
        public void Xuat()
        {
            Console.WriteLine($"Hãng sản xuất: {hangSX}");
            Console.WriteLine($"Số seri: {soSeri}");
            Console.WriteLine($"Tên sản phẩm: {tenSP}");
            Console.WriteLine($"Giá: {gia:0.00}");
            Console.WriteLine($"Loại sản phẩm: {loaiSP}");
            Console.WriteLine($"Thành tiền: {ThanhTien():0.00}");
            Console.WriteLine();
        }
    }
}
