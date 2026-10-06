using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai3
{
    public class TrungTamCNTT
    {
        private List<ThiSinh> listTS;
        public List<ThiSinh> ListTS
        {
            get {  return listTS; }
            set {  listTS = value; }
        }

        public TrungTamCNTT()
        {
            listTS = new List<ThiSinh>();
        }

        public void NhapDanhSachTS()
        {
            Console.WriteLine("Nhập số lượng thí sinh: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0;i<n;i++)
            {
                Console.WriteLine($"TÊN THÍ SINH THỨ {i + 1}");
                ThiSinh dsTS = new ThiSinh();
                dsTS.NhapTS();
                listTS.Add(dsTS);
            }
        }

        public void DocFileDanhSach(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);

            XmlNodeList nodeList = read.SelectNodes("/TrungTam/ThiSinh");

            foreach (XmlNode node in nodeList)
            {
                ThiSinh ts = new ThiSinh();
                ts.SoBaoDanh = node.Attributes["SoBaoDanh"].Value;

                ts.TenThiSinh = node["TenThiSinh"].InnerText;
                ts.NamSinh= int.Parse(node["NamSinh"].InnerText);
                ts.DiemThiLT = double.Parse(node["DiemThiLT"].InnerText);
                ts.DiemThucHanh1 = double.Parse(node["DiemThucHanh1"].InnerText);
                ts.DiemThucHanh2 = double.Parse(node["DiemThucHanh2"].InnerText);

                listTS.Add(ts);
            }
        }

        public void XuatDanhSach()
        {
            foreach(ThiSinh ts in listTS)
            {
                ts.XuatThiSinh();
            }
        }

        public void SapXepDiemTrungBinh()
        {
            if (listTS.Count == 0)
            {
                Console.WriteLine("DANH SÁCH RỖNG");
                return;
            }

            ListTS = ListTS.OrderByDescending(t => t.DiemTrungBinh()).ToList();

            foreach (ThiSinh ts in listTS)
            {
                ts.XuatThiSinh();
            }
        }

        public void SapXepHoTen()
        {
            if (listTS.Count == 0)
            {
                Console.WriteLine("DANH SÁCH RỖNG");
                return;
            }

            ListTS = ListTS.OrderBy(t => t.TenThiSinh).ThenBy(t => t.XetKetQua() == "Đậu" ? 0 : 1).ToList();

            foreach(ThiSinh ts in listTS)
            {
                ts.XuatThiSinh();
            }
        }

        public void DanhSachDau()
        {
            if(listTS.Count == 0)
            {
                Console.WriteLine("DANH SÁCH RỖNG");
                return;
            }

            foreach(ThiSinh ts in listTS.Where(t => t.XetKetQua() == "Đậu"))
            {
                ts.XuatThiSinh();
            }
        }

        public void DemThiSinhDau()
        {
            int demDau = ListTS.Count(t => t.XetKetQua() == "Đậu");
            int demRot = listTS.Count - demDau;

            Console.WriteLine($"TỔNG SỐ THÍ SINH: {listTS.Count}");
            Console.WriteLine($"TỔNG SỐ THÍ SINH ĐẬu: {demDau}");
            Console.WriteLine($"TỔNG SỐ THÍ SINH RỚT: {demRot}");
        }
    }
}
