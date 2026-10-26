using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai4
{
    public class DSHoaDon
    {
        List<HoaDon> dsHD;
     
        public List<HoaDon> DsHD
        {
            get { return dsHD; }
            set { dsHD = value; }
        }
        public DSHoaDon()
        {
            dsHD = new List<HoaDon>();
        }

        public void DocFile(string filename)
        {
            XmlDocument read = new XmlDocument();
            read.Load(filename);

            XmlNodeList ds = read.SelectNodes("DanhSachHoaDon/HoaDon");

            foreach (XmlNode node in ds)
            {
                string loai = node.Attributes["Loai"].Value;

                string ma = node["MaSo"].InnerText;
                string ten = node["HoTenKhach"].InnerText;
                DateTime ngay = DateTime.Parse(node["NgayLap"].InnerText);
                string maH = node["MaHang"]?.InnerText ?? "";
                string tenH = node["TenHang"]?.InnerText ?? "";
                double dgS = double.Parse(node["DonGia"].InnerText);
                HangHoa mh = new HangHoa(maH, tenH, dgS);
                int sl = int.Parse(node["SoLuong"].InnerText);
                if (loai == "VIP")
                {
                    dsHD.Add(new KhachHangVIP(ma,ten,ngay,sl,mh));                    
                }
                else if (loai == "ThanThiet")
                {
                    dsHD.Add(new KhachHangThanThiet(ma, ten, ngay, sl, mh));
                }
                else if (loai == "VangLai")
                {
                    dsHD.Add(new KhachHangVang(ma, null, ngay, sl, mh));
                }
            }
        }
        public void XuatDS()
        {
            foreach(HoaDon ds in dsHD)
            {
                ds.Xuat();
                Console.WriteLine();
            }
        }

        public void XuatDanhSachVangLai()
        {
            foreach(HoaDon ds in dsHD.OfType<KhachHangVang>())
            {
                ds.Xuat();
            }
        }

        public double TongTinhThanhTien()
        {
            return dsHD.Sum(t => t.TongThanhTien());
        }

        public HoaDon TongThanhTienLonNhat()
        {
            double max = dsHD.Max(t => t.TongThanhTien());

            return dsHD.FirstOrDefault(g => g.TongThanhTien() == max);
        }

        public void DemSoKhachHangVIP()
        {
            Console.WriteLine($"Đếm số lượng khách hàng VIP: {dsHD.OfType<KhachHangVIP>().Count()}");
        }

        public double TongTamUng()
        {
            return dsHD
                       .Where(t => string.Equals(t.TenKH, "Nguyễn Văn a", StringComparison.OrdinalIgnoreCase))
                       .OfType<ILaiSuat>()
                       .Sum(t => t.ThanhToanTamUng());
        } 

        public void SapXep()
        {
            dsHD = dsHD.OrderBy(t => t.TongThanhTien()).ThenByDescending(g => g.MaKH).ToList();
        }



    }
}
