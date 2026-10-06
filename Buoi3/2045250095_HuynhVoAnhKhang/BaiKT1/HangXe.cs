using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BaiKT1
{
    public class HangXe
    {
        private string diaChi;
        private string maSoThue;
        private List<Alpha> listHX;

        public string DiaChi {  get { return diaChi; } set { diaChi = value; }}
        public string MaSoThue { get { return maSoThue; } set { maSoThue = value; }}
        public List<Alpha> ListHX { get { return listHX; } set { listHX = value; }}
        public HangXe()
        {
            listHX = new List<Alpha>();
        }

        public void DocFileDanhSach(string file)
        {
            if(file == null)
            {
                Console.WriteLine($"ĐỌC FILE {file} KHÔNG THÀNH CÔNG");
                return;
            }

            XmlDocument read = new XmlDocument();
            read.Load(file);

            XmlNode root = read.SelectSingleNode("/Alpha");
            DiaChi = root["DiaChi"].InnerText.Trim();
            MaSoThue = root["MaSoThue"].InnerText.Trim();

            XmlNodeList ds = root.SelectNodes("CacXe/Xe");
            foreach(XmlNode node in ds)
            {
                Alpha ap = new Alpha();
                ap.SoKhung = node["SoKhung"].InnerText.Trim();
                ap.SoMay = node["SoMay"].InnerText.Trim();
                ap.SoCho = int.Parse(node["SoChoNgoi"].InnerText);
                ap.DongCo = int.Parse(node["DongCoDien"].InnerText);
                ap.CongSuat = int.Parse(node["CongSuatCucDai"].InnerText);

                listHX.Add(ap);
            }
        }

        public void XuatDanhSachHangXe()
        {
            if(listHX.Count == 0)
            {
                Console.WriteLine("DANH SÁCH HÃNG XE RỖNG");
                return;
            }
            Tienich.TieuDe();
            foreach(Alpha ap in listHX)
            {
                ap.Xuat();
            }
        }

        public void DemSoDongCoDien()
        {
            int dongCo = listHX.Count(t => t.DongCo == 1);
            Console.WriteLine($"Số lượng động cơ điện: {dongCo}");
        }

        public void SapXeHangXe()
        {
            if (listHX.Count == 0)
            {
                Console.WriteLine("DANH SÁCH HÃNG XE RỖNG");
                return;
            }

            listHX = listHX.OrderByDescending(t => t.CongSuat).ThenBy(g => g.SoCho).ToList();
        }

        public Alpha CongSuatCucDai()
        {
            int max = listHX.Max(t => t.CongSuat);
            return listHX.FirstOrDefault(g => g.CongSuat == max);
        }

        public void CongSuatCucDaiDS()
        {
            int max = listHX.Max(t => t.CongSuat);
            listHX = listHX.Where(g => g.CongSuat  == max).ToList();
        }
    }
}
