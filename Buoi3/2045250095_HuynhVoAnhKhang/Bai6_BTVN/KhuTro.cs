using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai6_BTVN
{
    public class KhuTro
    {
        private string ten;
        private string diaChi;
        private List<Phong> listPT;

        public string Ten
        {
            get { return ten; }
            set
            {
                ten = value;
            }
        }

        public string DiaChi { get { return diaChi; } set {  diaChi = value; }  }
    
        public List<Phong> ListPT { get { return listPT; } set { listPT = value; } }

        public KhuTro()
        {
            listPT = new List<Phong>();
        }

        public void DocFileDanhSach(string file)
        {
            if(file == null)
            {
                Console.WriteLine($"KHÔNG ĐỌC DƯỢC file {file}");
                return;
            }
            XmlDocument read = new XmlDocument();
            read.Load(file);

            XmlNode root = read.SelectSingleNode("/KhuTro");

            Ten = root["Ten"]?.InnerText.Trim();
            DiaChi = root["DiaChi"]?.InnerText.Trim();

            XmlNodeList ds = root.SelectNodes("DsPhong/Phong");
            foreach (XmlNode node in ds)
            {
                Phong p = new Phong();
                p.Loai = int.Parse(node["Loai"].InnerText);
                p.MaPhong = node["MaP"].InnerText.Trim();
                p.SoKhach = int.Parse(node["SoLuong"].InnerText);
                p.SoDien= int.Parse(node["SoDien"].InnerText);
                p.GiaThue = double.Parse(node["Gia"].InnerText);
                
                listPT.Add(p);
            }
        }

        public void XuatDanhSach()
        {
            if (listPT.Count == 0)
            {
                Console.WriteLine("DANH SÁCH PHÒNG TRỌ RỖNG!");
                return;
            }

            Console.WriteLine($"Tên khu trọ: {ten}");
            Console.WriteLine($"Địa Chỉ khu trọ: {diaChi}");

            TienIch.TieuDe();
            foreach (Phong phong in listPT)
            {
                phong.Xuat();
                Console.WriteLine();
            }
        }

        public double TinhTongTien()
        {
            return listPT.Sum(t => t.TienPhong());
        }

        public void SapXep()
        {
            listPT = listPT.OrderByDescending(t => t.SoKhach).ThenBy(t => t.TienPhong()).ToList();
        } 
        public Phong XuatThongPhongSuDungNhieuDien()
        {
            int max = listPT.Max(t => t.SoDien);
            return listPT.FirstOrDefault(t => t.SoDien == max);        
        }
    }

}
