using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2045250095_HuynhVoAnhKhang
{
    public class SieuThi
    {
        private string tenSieuThi;
        private string diaChi;
        List<SanPham> dsSanPham;

        public string TenSieuThi
        {

            get { return tenSieuThi; }
            set { tenSieuThi = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public List<SanPham> DSSanPham
        {
            get { return dsSanPham; }
            set { dsSanPham = value; }
        }
        public SieuThi()
        {
            dsSanPham = new List<SanPham>();
        }
        public void NhapSanPham()
        {
            Console.Write("Nhập số lượng sản phẩm: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"SẢN PHẨM THỨ {i + 1}");
                SanPham sp = new SanPham();

                Console.Write("Nhập mã sản phẩm: ");
                sp.MaSP = Console.ReadLine();

                Console.Write("Nhập tên sản phẩm: ");
                sp.TenSP = Console.ReadLine();

                Console.Write("Nhập số lượng sản phẩm: ");
                sp.SoLuong = int.Parse(Console.ReadLine());

                Console.Write("Nhập đơn giá sản phẩm: ");
                sp.DonGia = double.Parse(Console.ReadLine());

                Console.Write("Nhập số ngày bảo quản sản phẩm: ");
                sp.SoNgayBaoQuan =int.Parse(Console.ReadLine());

                dsSanPham.Add(sp);
                Console.WriteLine();

            }
        }
        public void DocFileDanhSach(string file)
        {
            if(file == null)
            {
                Console.WriteLine($"Doc file {file} khong thanh cong");
                return;
            }

            XmlDocument read = new XmlDocument();
            read.Load(file);

            XmlNode root = read.SelectSingleNode("/sieuThi");
            TenSieuThi = root["tensieuthi"].InnerText.Trim();
            DiaChi = root["diachi"].InnerText.Trim();

            XmlNodeList ds = root.SelectNodes("dssanpham/sanpham");
            
            foreach(XmlNode node in ds)
            {
                SanPham sp = new SanPham();
                sp.MaSP = node["ma"].InnerText;
                sp.TenSP = node["ten"].InnerText;
                sp.SoLuong = int.Parse(node["soluong"].InnerText);
                sp.DonGia = double.Parse(node["dongia"].InnerText);
                sp.SoNgayBaoQuan = int.Parse(node["songaybaoquan"].InnerText);
                dsSanPham.Add(sp);
            }
        }

        public void XuatSieuThi()
        {
            if (dsSanPham.Count == 0)
            {

                Console.WriteLine("DANH SACH RONG");
                return;
            }
            foreach (SanPham sp in dsSanPham)
            {
                sp.XuatThongTin();
            }
        }

        public double TinhTongGiaTriTatCaSanPham()
        {
            return dsSanPham.Sum(t => t.TinhTongGiaTri());
        }

        public void SapXepSanPham()
        {
            dsSanPham = dsSanPham.OrderBy(t => t.SoNgayBaoQuan).ThenByDescending(g => g.DonGia).ToList();
        }

        public void DanhSachTongLonNhat()
        {
            double max = dsSanPham.Max(t => t.TinhTongGiaTri());
            dsSanPham = dsSanPham.Where(g => g.TinhTongGiaTri() == max).ToList();
        }
    }
}
