using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai2
{
    public class ListHoaDon
    {
        List<KhachHang> dsKH;
        string congTy;
        string sdt;
        string diaChi;
        public List<KhachHang> DsKH { get { return dsKH; } set {  dsKH = value; } }

        public ListHoaDon()
        {
            dsKH = new List<KhachHang>();
        }

        public void DocFileXML(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNode root = read.SelectSingleNode("/CongTy");
            congTy = root["TenCongTy"].InnerText;
            sdt = root["DienThoai"].InnerText;
            diaChi = root["DiaChi"].InnerText;

            XmlNodeList ds = root.SelectNodes("DanhSachHoaDon/HoaDon");
            foreach (XmlNode node in ds)
            {
                int loai = (node["LoaiKH"] != null) ? int.Parse(node["LoaiKH"].InnerText) : int.Parse(node.Attributes["LoaiKH"].Value);

                string ma = node["MaKH"].InnerText;
                string ten = node["TenKH"].InnerText;
                int sl = int.Parse(node["SoLuong"].InnerText);
                double gia = double.Parse(node["GiaBan"].InnerText);

                if(loai == 1)
                {
                    int kc = int.Parse(node["KhoangCach"].InnerText);
                    dsKH.Add(new KhachHangCN(ma,ten,sl,gia,kc));
                } else if(loai == 2)
                {
                    int tg = int.Parse(node["ThoiGianHopTac"].InnerText);
                    dsKH.Add(new DaiLyCap1(ma, ten, sl, gia, tg));
                } else if(loai == 3)
                {
                    int slNV = int.Parse(node["SoLuongNhanVien"].InnerText);
                    dsKH.Add(new KhachHangCT(ma,ten,sl, gia, slNV)); 
                }
            }
        }
        public void XuatDS()
        {
            Console.WriteLine($"Cong ty: {congTy}");
            Console.WriteLine($"So dien thoai: {sdt}");
            Console.WriteLine($"Dia chi: {diaChi}");
            Console.WriteLine();
            foreach (KhachHang kh in dsKH)
            {
                kh.Xuat();
                Console.WriteLine();
            }
        }

        public double TongThanhTien()
        {
            return dsKH.Sum(t => t.ThanhTien());
        }

        public KhachHang MaxKhachHang()
        {
            int max = dsKH.Max(t => t.Sl);
            return dsKH.FirstOrDefault(g => g.Sl == max);
        }

        public double TongChietKhau()
        {
            return dsKH.Sum(t => t.ChietKhau());
        }

        public void XuatDaiLyCap1()
        {
            Console.WriteLine($"So luong dai ly cap 1: {dsKH.OfType<DaiLyCap1>().Count()}");
            Console.WriteLine();

            foreach (KhachHang ds in dsKH.OfType<DaiLyCap1>())
            {
                ds.Xuat();
                Console.WriteLine();

            }
        }

        public void SapXep()
        {
            dsKH = dsKH.OrderBy(t => t.Sl).ThenByDescending(g => g.ThanhTien()).ToList();
        }

        public void TimKhachHang()
        {
            Console.Write("Nhap ma: ");
            string ma = Console.ReadLine();
            bool find = false;
            foreach(KhachHang kh in dsKH)
            {
                if(kh.MaKH.Equals(ma, StringComparison.OrdinalIgnoreCase))
                {
                    kh.Xuat();
                    find = true;
                    break;
                }
                
            }
            if (!find)
            {
                Console.WriteLine("Khach hang la");
            }
        }


    }
}
