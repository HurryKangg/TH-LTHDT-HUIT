using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai3
{
    public class DsSinhVien
    {
        List<Nguoi> dsNguoi;
        public List<Nguoi> DsNguoi
        {
            get { return dsNguoi; }
            set { dsNguoi = value; }
        }

        public DsSinhVien()
        {
            dsNguoi = new List<Nguoi>();
        }

        public void DocFileDanhSach(string file)
        {
            if(file == null)
            {
                Console.WriteLine("DOC FILE LOI");
                return;
            }
            XmlDocument read = new XmlDocument();

            read.Load(file);

            XmlNodeList ds = read.SelectNodes("DanhSachSinhVien/SinhVien");
            foreach(XmlNode node in ds)
            {
                string ten = node["HoTen"].InnerText;
                DateTime ngay = DateTime.Parse(node["NgaySinh"].InnerText);
                string gt = node["GioiTinh"].InnerText;
                string ma = node["MaSoSinhVien"].InnerText;
                string heDT = node["HeDaoTao"].InnerText;

                dsNguoi.Add(new SinhVien(ten, ngay, gt, ma, heDT));
            }
        }

        public void XuatDanhSach()
        {
            foreach(Nguoi ng in dsNguoi)
            {
                ng.Xuat();
                Console.WriteLine();
            }
        }

        public void XuatHeDaiHoc()
        {
            foreach(Nguoi ng in dsNguoi.OfType<SinhVien>().Where(t=> t.HeDT.Equals("Dai hoc", StringComparison.OrdinalIgnoreCase)))
            {
                ng.Xuat();
                Console.WriteLine();
            }
        }

        public double TongHocPhiAll()
        {
            return dsNguoi.OfType<SinhVien>().Sum(t => t.TongHocPhi());
        }
    }
}
