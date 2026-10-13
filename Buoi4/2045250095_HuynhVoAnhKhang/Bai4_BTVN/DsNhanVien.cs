using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai4_BTVN
{
    public class DsNhanVien
    {
        List<NhanVien> dsNV;
        public List<NhanVien> DsNV
        {
            get {  return dsNV; }
            set { dsNV = value; }
        }

        public DsNhanVien()
        {
            dsNV = new List<NhanVien>();
        }

        public void DocFileDanhSach(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);

            XmlNodeList root = read.SelectNodes("DanhSachNhanVien/NhanVien");
            foreach (XmlNode node in root)
            {
                string loai = node.Attributes["loai"].Value;

                string ma = node["MaNV"].InnerText;
                string ten = node["TenNV"].InnerText;
                double luong = double.Parse(node["HeSoLuong"].InnerText);
                if(loai.Equals("1"))
                {
                    dsNV.Add(new NhanVien(ma,ten,luong));
                } else if(loai.Equals("2"))
                {
                    string cv = node["ChucVu"].InnerText;
                    int nam = int.Parse(node["ThamNienQuanLy"].InnerText);
                    dsNV.Add(new CanBo(ma, ten, luong, cv,nam));
                }
            }
        }
        public void XuatDanhSach()
        {
            foreach(NhanVien nv in dsNV)
            {
                nv.Xuat();
                Console.WriteLine();
            }
        }

        public double TongThuNhap()
        {
            return dsNV.Sum(t => t.TinhThuNhap());
        }

        public void DanhSachCanBo()
        {
            foreach(NhanVien nv in dsNV.OfType<CanBo>())
            {
                nv.Xuat();
                Console.WriteLine();

            }
        }

        public void SapXep()
        {
            dsNV = dsNV.OrderByDescending(t => t.HeSoLuong).ToList();
        }
    }
}
