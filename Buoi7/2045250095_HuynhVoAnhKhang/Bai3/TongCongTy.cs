using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai3
{
    public class TongCongTy
    {
        List<CongTyABC> dsCTABC;
        List<CongTyBCD> dsCTBCD;
        public List<CongTyABC> DsCTABC
        {
            get {  return dsCTABC; }
            set { dsCTABC = value; }
        }
        public List<CongTyBCD> DsCTBCD
        {
            get { return dsCTBCD; }
            set { dsCTBCD = value; }
        }
        public TongCongTy()
        {
            dsCTABC = new List<CongTyABC>();
            dsCTBCD = new List<CongTyBCD>();
        }

        public void DocFile(string filename)
        {
            XmlDocument read = new XmlDocument();
            read.Load(filename);

            XmlNode dsABC = read.SelectSingleNode("TongCongTy/CongTyABC");
            XmlNode dsBCD = read.SelectSingleNode("TongCongTy/CongTyBCD");

            if (dsABC != null)
            {
                foreach (XmlNode node in dsABC.ChildNodes)
                {
                    if (node.NodeType != XmlNodeType.Element) continue;

                    string Loai = node.Attributes["loai"]?.Value??"";

                    string ma = node["MaNV"].InnerText;
                    string ten = node["TenNV"].InnerText;

                    int namSinh = int.Parse(node["NamSinh"].InnerText);
                    string gt = node["GioiTinh"].InnerText;
                    double hsl = double.Parse(node["HeSoLuong"].InnerText);
                    int namVL = int.Parse(node["NamVaoLam"].InnerText);

                    if (Loai == "1")
                    {
                        int ngay = int.Parse(node["SoNgayNghi"].InnerText);
                        dsCTABC.Add(new NhanVienSanXuat(ma, ten, namSinh, gt, hsl, namVL, ngay));
                    }
                    else if (Loai == "2")
                    {
                        double toiThieu = double.Parse(node["DoanhSoToiThieu"].InnerText);
                        double soThang = double.Parse(node["DoanhSoThang"].InnerText);
                        dsCTABC.Add(new NhanVienKinhDoanh(ma, ten, namSinh, gt, hsl, namVL, toiThieu, soThang));
                    }
                    else if (Loai == "3")
                    {
                        string cv = node["ChucVu"].InnerText;
                        double hscv = double.Parse(node["HeSoChucVu"].InnerText);
                        dsCTABC.Add(new CanBoQuanLy(ma, ten, namSinh, gt, hsl, namVL, cv, hscv));
                    }

                }
            }
            if (dsBCD != null)
            {
                foreach (XmlNode node in dsBCD.ChildNodes)
                {
                    if (node.NodeType != XmlNodeType.Element) continue;
                    string ma = node["MaNV"].InnerText;
                    string ten = node["TenNV"].InnerText;
                    double tien = double.Parse(node["SoTienTaoRa"].InnerText);
                    dsCTBCD.Add(new CongTyBCD(ma, ten, tien));
                }
            }
            
        }

        public void XuatDS()
        {
            Console.WriteLine("\n-------CÔNG TY ABC-------");
            foreach(CongTyABC ds in dsCTABC)
            {
                ds.Xuat();
                Console.WriteLine();
            }

            Console.WriteLine("\n-------CÔNG TY BCD-------");
            foreach (CongTyBCD ds in dsCTBCD)
            {
                ds.Xuat();
                Console.WriteLine();
            }
        }
        public void DemSoLuongCongTyCon()
        {
            Console.WriteLine($"Công ty ABC: {dsCTABC.Count()}");
            Console.WriteLine($"Công ty BCD: {dsCTBCD.Count()}");
        }

        public void NangLucTot()
        {
            Console.WriteLine($"Nhân vien năng lực tốt công ty ABC");
            foreach (CongTyABC ds in dsCTABC.Where(t => t.NangLucNhanVien().Equals("Năng lực tốt", StringComparison.OrdinalIgnoreCase)))
            {
                ds.Xuat();
                Console.WriteLine();
            }
            Console.WriteLine($"Nhân vien năng lực tốt công ty BCD");
            foreach (CongTyBCD ds in dsCTBCD.Where(t => t.NangLucNhanVien().Equals("Năng lực tốt", StringComparison.OrdinalIgnoreCase)))
            {
                ds.Xuat();
                Console.WriteLine();
            }
        }

        public void ChuaXetThiDua()
        {
            Console.WriteLine($"Nhân vien chưa xét thi đua");
            foreach (CongTyBCD ds in dsCTBCD)
            {
                ds.XuatChuaXet();
                Console.WriteLine();
            }
        }

        public void XuatThongTinLaoDongTienTienABC()
        {
            Console.WriteLine($"Nhân vien lao động tiên tiến công ty ABC");
            foreach (CongTyABC ds in dsCTABC.Where(t => t.XepLoaiDanhHieu().Equals("Lao động tiên tiến", StringComparison.OrdinalIgnoreCase)))
            {
                ds.Xuat();
                Console.WriteLine();
            }
        }

    }
}
