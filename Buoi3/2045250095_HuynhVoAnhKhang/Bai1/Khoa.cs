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
        private List<GiangVien> listGV;
        public List<GiangVien> ListGV
        {
            get { return listGV; }
            set { listGV = value; }
        }

        public Khoa()
        {
            listGV = new List<GiangVien>();
        }

        public void DocFile(string file)
        {
            XmlDocument docFile = new XmlDocument();
            docFile.Load(file);
            XmlNodeList nodeList = docFile.SelectNodes("/Khoa/GiangVien");
            foreach (XmlNode node in nodeList)
            {
                GiangVien gv = new GiangVien();
                gv.HoTenGV = node["HoTenGV"].InnerText.Trim();
                gv.SoNhomHD = int.Parse(node["SoNhomHD"].InnerText);
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
            foreach(GiangVien giangVien in listGV)
            {
                giangVien.XuatGV();
            }
        }
    }
}
