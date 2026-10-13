using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai1
{
    public class CongTy
    {
        string tenCT;
        string diaChi;
        string dt;
        List<NhanVien> listNV;
        public string TenCT {  get { return tenCT; } set { tenCT = value; } }
        public string DiaChi { get { return diaChi; } set { diaChi = value; } }
        public string DT { get { return dt; } set { dt = value; } }
        public List<NhanVien> ListNV { get { return listNV; } set { listNV = value; } }
        public CongTy()
        {
            listNV = new List<NhanVien>();
        }

        public void DocFileDanhSach(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNode root = read.SelectSingleNode("/CongTy");
            TenCT = root["TenCty"].InnerText;
            DiaChi= root["DiaChi"].InnerText;
            DT = root["DT"].InnerText;

            XmlNodeList ds = root.SelectNodes("DSNV/NV");
            foreach (XmlNode node in ds)
            {
                string loai = node.Attributes["loai"].Value;

                string ma = node["ma"].InnerText.Trim();
                string ten = node["ten"].InnerText.Trim();
                int nvl = int.Parse(node["nvl"].InnerText);
                double hsl = double.Parse(node["hsl"].InnerText);
                int snn = int.Parse(node["snn"].InnerText);
                if(loai == "1")
                {
                    listNV.Add(new NhanVien(ma, ten, nvl, hsl, snn));
                }else if(loai == "2")
                {
                    string cv = node["cv"].InnerText.Trim();
                    double hsphspccv = double.Parse(node["hspccv"].InnerText);
                    string pb = node["phongban"].InnerText.Trim();

                    listNV.Add(new CanBo(ma, ten, nvl, hsl, snn, cv, hsphspccv, pb)); 
                }
            }
        }
        public void XuatCongTy()
        {
            Console.WriteLine($"Ten cong ty: {tenCT}");
            Console.WriteLine($"Dia chi: {diaChi}");
            Console.WriteLine($"DT: {dt}");

            foreach(NhanVien nhanVien in listNV)
            {
                nhanVien.XuatThongTin();
                Console.WriteLine();
            }
        }

        public double MaxLuong()
        {
            return  listNV.Max(t => t.TinhLuong());
        }

        public NhanVien MaxLuongNV()
        {
            double max = listNV.Max(t => t.TinhLuong());
            return listNV.FirstOrDefault(g => g.TinhLuong()  == max);
        }

        public void InDanhSachCanBo()
        {
           foreach(NhanVien nv in listNV.OfType<CanBo>())
            {
                    nv.XuatThongTin();
            }
        }

    }
}
