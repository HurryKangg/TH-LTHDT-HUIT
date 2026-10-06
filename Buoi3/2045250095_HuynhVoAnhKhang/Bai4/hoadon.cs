using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai4
{
    public class hoadon
    {
        private string mahd;
        private string tenkh;

        private List<ctbh> listHD;

        public string MaHD {  get { return mahd; } set { mahd = value; } }
        public string Tenkh { get { return tenkh; } set { tenkh = value; } }
        public List<ctbh> ListHD { get { return listHD; } set { listHD = value; } }

        public hoadon()
        {
            listHD = new List<ctbh>();
        }

        public void DocFileDanhSach(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);

            XmlNode root = read.SelectSingleNode("/hoadon");

            MaHD = root["mahd"].InnerText.Trim();
            Tenkh = root["tenkh"].InnerText.Trim();

            XmlNodeList nodeList = root.SelectNodes("ctbhs/ctbh");

            foreach (XmlNode node in nodeList)
            {
                string ma = node["masp"].InnerText.Trim();
                string ten = node["tensp"].InnerText.Trim();
                double gia = double.Parse(node["gia"].InnerText);
                int sl = int.Parse(node["sl"].InnerText);

                ctbh ct = new ctbh(ma, ten, gia, sl);
                listHD.Add(ct);
            }
        }


        public double TongThanhTien()
        {
            return listHD.Sum(t => t.ThanhTien());
        }
        public void XuatDanhSachHoaDon()
        {
            if (listHD.Count == 0)
            {
                Console.WriteLine("DANH SÁCH RỖNG !!");
                return;
            }

            Console.WriteLine($"{mahd,-10} {tenkh,-25}");
            TienIch.TieuDe();
            foreach(ctbh ct in listHD)
            {
                ct.Xuat();
            }
        }
        public void SapXepBanHang()
        {
            if(listHD.Count ==0)
            {
                Console.WriteLine("DANH SÁCH RỖNG !!");
                return;
            }
            
            listHD = listHD.OrderByDescending(t => t.ThanhTien()).ThenBy(g => g.Gia).ToList();

            foreach(ctbh ct in listHD)
            {
                ct.Xuat();
            }
        
        }

        public void MaxThanhTienDS()
        {
            double thanhtien = listHD.Max(t => t.ThanhTien());
            listHD = listHD.Where(t => t.ThanhTien() == thanhtien).ToList();
        }
        public ctbh MaxThanhTien()
        {
            double thanhtien = listHD.Max(t => t.ThanhTien());
            return listHD.FirstOrDefault(t => t.ThanhTien() == thanhtien);
        }
    }
}
