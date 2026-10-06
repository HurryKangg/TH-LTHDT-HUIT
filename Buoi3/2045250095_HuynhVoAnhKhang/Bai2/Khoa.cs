using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai1
{
    public class Khoa
    {
        private string tenKhoa;
        private string viTri;
        private string soDienThoai;
        private int soNganhKhoaQL;

        public string TenKhoa
        {
            get { return tenKhoa; }
            set { tenKhoa = value; }
        }
        public string ViTri
        {
            get { return viTri; }
            set { viTri = value; }
        }
        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
        public int SoNganhKhoaQL
        {
            get { return soNganhKhoaQL;}
            set { soNganhKhoaQL = value; }
        }

        private List<GiangVien> listGV;
        public List<GiangVien> ListGV
        {
            get { return listGV; }
            set { listGV = value; }
        }

        public Khoa()
        {
            TenKhoa = "NO NAME";
            ViTri = "LE TRONG TAN";
            SoDienThoai = "0000";
            SoNganhKhoaQL = 0;
            listGV = new List<GiangVien>();
        }
        public Khoa(List<GiangVien> ds)
        {
            listGV = ds;
        }
        public Khoa(string ten, string vt, string sdt, int so, List<GiangVien> lst)
        {
            TenKhoa = ten;
            ViTri = vt;
            SoDienThoai = sdt;
            SoNganhKhoaQL = so;
            ListGV = lst;
        }
        public void DocFile(string file)
        {
            XmlDocument docFile = new XmlDocument();
            docFile.Load(file);
            
            

            tenKhoa = docFile.SelectSingleNode("/Khoa/TenKhoa")?.InnerText.Trim();
            viTri = docFile.SelectSingleNode("/Khoa/ViTri")?.InnerText.Trim();
            soDienThoai = docFile.SelectSingleNode("/Khoa/SoDienThoai")?.InnerText.Trim();
            soNganhKhoaQL = int.Parse(docFile.SelectSingleNode("/Khoa/SoNganhKhoaQL").InnerText);

            XmlNodeList nodeList = docFile.SelectNodes("/Khoa/DSGiangVien/GiangVien");

            foreach (XmlNode node in nodeList)
            {     
                GiangVien gv = new GiangVien();
                gv.HoTenGV = node["HoTenGV"].InnerText;
                gv.SoNhomHD = int.Parse(node["SoNhomHD"].InnerText);
                

                //string ten = node["HoTenGV"].InnerText;
                //int so = int.Parse(node["SoNhomHD"].InnerText);
                //GiangVien gv = new GiangVien(ten, so);
                listGV.Add(gv);
            }
        }

        public int TinhTongSoNhom()
        {
            return listGV.Sum(t => t.SoNhomHD);
        }

        public void DanhSachTangTheoHoTen()
        {
            listGV = listGV.OrderBy(g => g.HoTenGV).ToList();
        }

        public void SapXepGiamDanTheoSoNhom()
        {
            listGV = listGV.OrderByDescending(t => t.SoNhomHD).ToList();
        }

        public void LocDanhSachLonHon1()
        {
            listGV = listGV.Where(t => t.SoNhomHD > 1).ToList();
        }

        public void XuatDSKhoa()
        {
            Console.WriteLine($"\nTên Khoa: {this.TenKhoa}");
            Console.WriteLine($"Vị Trí: {this.ViTri}");
            Console.WriteLine($"Số Điện Thoại {this.SoDienThoai}");
            Console.WriteLine($"Số ngành khoa quản lý {this.SoNganhKhoaQL}\n");

            foreach (GiangVien giangVien in listGV)
            {
                giangVien.XuatGV();
            }
        }
    }
}
