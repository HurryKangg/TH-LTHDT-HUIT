using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai2
{
    public class DSHangHoa
    {
        List<HangHoa> dsHH;

        public List<HangHoa> DsHH
        {
            get { return dsHH; }
            set { dsHH = value; }
        }

        public DSHangHoa()
        {
            dsHH = new List<HangHoa>();
        }

        public void DocFileDanhSach(string file)
        {
            if(file == null)
            {
                Console.WriteLine("KHONG DOC DUOC FILE");
                return;
            }

            XmlDocument read =  new XmlDocument();
            read.Load(file);

            XmlNodeList ds = read.SelectNodes("DanhMucHangHoa/NuocGiaiKhat");
            foreach(XmlNode node in ds)
            {
                string ma = node["MaHang"].InnerXml;
                string ten = node["TenHang"].InnerXml;
                string dv = node["DonViTinh"].InnerXml;
                int sl = int.Parse(node["SoLuong"].InnerXml);
                double gia = double.Parse(node["DonGia"].InnerXml);
                dsHH.Add(new NuocGiaiKhat(ma, ten, dv, sl, gia));
            }
        }

        public void XuatDanhSach()
        {
            foreach(HangHoa ds in dsHH)
            {
                ds.Xuat();
                Console.WriteLine();
            }
        }

        public void XuatDanhSachLonVaChai()
        {
            foreach(HangHoa gk in dsHH.OfType<NuocGiaiKhat>().Where(t => t.DonVi.Equals("Lon", StringComparison.OrdinalIgnoreCase) 
            || t.DonVi.Equals("Chai", StringComparison.OrdinalIgnoreCase)) )
            {
                gk.Xuat();
                Console.WriteLine();
            }
        }

        public double TinhTongTienDanhMuc()
        {
            return dsHH.OfType<NuocGiaiKhat>().Sum(t => t.TinhTong());
        }

    }
}
