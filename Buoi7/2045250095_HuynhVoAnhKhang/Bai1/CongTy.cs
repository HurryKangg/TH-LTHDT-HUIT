using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai1
{
    internal class CongTy
    {
        List<CongTyABC> dsCT;
        string congTy;
        string sdt;
        string diaChi;
        public List<CongTyABC> DsCT
        {
            get { return dsCT; }
            set {  dsCT = value; }
        }

        public CongTy()
        {
            dsCT = new List<CongTyABC>();
        }

        public void DocFile(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNode root = read.SelectSingleNode("/CongTy");
            congTy = root["TenCongTy"].InnerText;
            sdt = root["DienThoai"].InnerText;
            diaChi = root["DiaChi"].InnerText;
            XmlNodeList ds = root.SelectNodes("HoaDons/*");
            foreach (XmlNode node in ds)
            {
                string loai = node.Attributes["loai"].Value;

                string ma = node["MaKH"].InnerText;
                string ten = node["TenKH"].InnerText;
                int sl = int.Parse(node["SoLuong"].InnerText);
                double dongia = double.Parse(node["GiaBan"].InnerText);

                if (loai  == "1")
                {
                    int kc = int.Parse(node["KhoangCach"].InnerText);
                    dsCT.Add(new KHCaNhan(ma,ten,sl,dongia,kc));
                } else if(loai == "2")
                {
                    int namHT = int.Parse(node["NamHopTac"].InnerText);
                    dsCT.Add(new DaiLyCap1(ma, ten, sl, dongia, namHT));
                                                                       
                } else if(loai == "3")
                {
                    int slNV = int.Parse(node["SoNhanVien"].InnerText);
                    dsCT.Add(new KHCongTy(ma,ten,sl,dongia,slNV));
                }

            }
        }
        public void XuatDS()
        {
            Console.WriteLine($"Cong ty: {congTy}");
            Console.WriteLine($"So dien thoai: {sdt}");
            Console.WriteLine($"Dia chi: {diaChi}");
            Console.WriteLine();
            foreach (CongTyABC ds in dsCT)
            {
                ds.Xuat();
                Console.WriteLine();
            }
        }

        public double TongTien()
        {
            return dsCT.Sum(t => t.ThanhTien());
        }

        public double TienTroGia()
        {
            return dsCT.OfType<ITroGia>().Sum(t => t.hoTro());
        }

        public CongTyABC XuatSoLuongMuaNhieu()
        {
            int max = dsCT.Max(t => t.SoLuong);
            return dsCT.FirstOrDefault(g=> g.SoLuong == max); 
        }

        public CongTyABC XuatThanhTienCao()
        {
            double max = dsCT.Max(t => t.ThanhTien());
            return dsCT.FirstOrDefault(g => g.ThanhTien() == max);
        }

        public double TongSoTienKHCongTyChietKhau()
        {
            return dsCT.OfType<KHCongTy>().Sum(t => t.ChietKhau());
        }

        public void SapXep()
        {
            dsCT = dsCT.OrderBy(t=> t.SoLuong).ThenByDescending(g => g.ThanhTien()).ToList();
        }

        public void XuatDanhSachDaiLy()
        {
            Console.WriteLine($"So luong dai ly cap 1: {dsCT.OfType<DaiLyCap1>().Count()}");
            Console.WriteLine();

            foreach (CongTyABC dsDL in dsCT.OfType<DaiLyCap1>())
            {
                dsDL.Xuat();
                Console.WriteLine();

            }
        }

    }
}
