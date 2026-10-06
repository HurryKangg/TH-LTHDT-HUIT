using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OnTapKT1
{
    public class CuaHang
    {
        private string tenCuaHang;
        private string diaChi;
        private List<DienThoai> listDT;
        public string TenCuaHang
        {
            get { return tenCuaHang; }
            set { tenCuaHang = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public List<DienThoai> ListDT
        {
            get { return listDT; }
            set { listDT  = value; }
        }

        public CuaHang()
        {
            listDT = new List<DienThoai>();
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

            XmlNode root = read.SelectSingleNode("/CuaHang");
            TenCuaHang = root["TenCuaHang"]?.InnerText.Trim();
            DiaChi = root["DiaChi"]?.InnerText.Trim();

            XmlNodeList ds = root.SelectNodes("DSDienThoai/DienThoai");

            foreach(XmlNode node in ds)
            {
                string ma = node["MaMay"].InnerText;
                string ten = node["TenMay"].InnerText;
                double gia = double.Parse(node["Gia"].InnerText);
                int sl = int.Parse(node["SoLuongTon"].InnerText);
                string hang = node["Hang"].InnerText;

                DienThoai dt = new DienThoai(ma, ten, gia, sl, hang);
                listDT.Add(dt);
            }
        }

        public void XuatDanhSach()
        {
            Console.WriteLine($"Tên cửa hàng: {tenCuaHang}");
            Console.WriteLine($"Địa chỉ: {diaChi}");
            foreach (DienThoai dt in listDT)
            {
                dt.Xuat();
            }
        }

        public void SapXep()
        {
            listDT = listDT.OrderByDescending(t => t.ThanhTien()).ToList();
        }

        public DienThoai MaxDT()
        {
            double max = listDT.Max(t => t.Gia);
            return listDT.FirstOrDefault(g => g.Gia == max);

        }
    }
}
