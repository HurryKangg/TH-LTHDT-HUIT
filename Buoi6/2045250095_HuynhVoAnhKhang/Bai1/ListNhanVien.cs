using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai1
{
    public class ListNhanVien
    {
        List<NhanVienABC> listNV;
        public List<NhanVienABC> ListNV
        {
            get { return listNV; }
            set { listNV = value; }
        }

        public ListNhanVien()
        {
            listNV = new List<NhanVienABC>();
        }

        public void DocFileXML(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList ds = read.SelectNodes("DanhSachNhanVien/NhanVien");
            foreach (XmlNode node in ds)
            {
                string loai = node.Attributes["Loai"].Value;

                string ma = node["MaNhanVien"].InnerText;
                string ten = node["HoTen"].InnerText;
                int nam = int.Parse(node["NamSinh"].InnerText);
                string gt = node["GioiTinh"].InnerText;
                double hsl = double.Parse(node["HeSoLuong"].InnerText);
                int namVL = int.Parse(node["NamVaoLam"].InnerText);

                if(loai == "1")
                {
                    int soNgayNghi = int.Parse(node["SoNgayNghi"].InnerText);
                    listNV.Add(new NhanVienSX(ma,ten,nam,gt,hsl,namVL, soNgayNghi));
                } else if(loai == "2")
                {
                    int soToiThieu = int.Parse(node["DSToiThieu"].InnerText);
                    int soBanHang = int.Parse(node["DSThucTe"].InnerText);
                    listNV.Add(new NhanVienKD(ma, ten, nam, gt, hsl, namVL, soToiThieu, soBanHang));
                }
                else if(loai == "3")
                {
                    string cv = node["ChucVu"].InnerText;
                    double hscv = double.Parse(node["HeSoChucVu"].InnerText);
                    listNV.Add(new CanBoQuanLy(ma, ten, nam, gt, hsl, namVL, cv, hscv));
                }
            }
        }

        public void XuatDS()
        {
            foreach(NhanVienABC ds in listNV)
            {
                ds.Xuat();
                Console.WriteLine();
            }
        }
        public double TinhTongLuongNV()
        {
            return listNV.Sum(t => t.Luong());
        }

        public double TinhTongThuNhap()
        {
            return listNV.Sum(t => t.TinhThuNhap());
        }


    }
}
