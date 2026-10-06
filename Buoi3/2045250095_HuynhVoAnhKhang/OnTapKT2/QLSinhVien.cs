using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OnTapKT2
{
    public class QLSinhVien
    {
        private List<SinhVien> listSV;
        public List<SinhVien> ListSV
        {
            get { return listSV; }
            set { listSV = value; }
        }

        public QLSinhVien()
        {
            listSV = new List<SinhVien>();
        }
        public void AddSinhVien(SinhVien sinhVien)
        {
            listSV.Add(sinhVien);
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

            XmlNodeList ds = read.SelectNodes("QuanLySinhVien/SinhVien");
            foreach(XmlNode node in ds)
            {
                string ma = node.Attributes["MaSV"].InnerText;

                string ten = node["HoTen"].InnerText.Trim();
                double gpa = double.Parse(node["GPA"].InnerText);
                int sotc = int.Parse(node["SoTinChi"].InnerText);
                string khoa = node["Khoa"].InnerText;

                if(ma == "SV000001")
                {
                        listSV.Add(new SinhVien(ma, ten, gpa, sotc, khoa));
                } else if(ma == "SV000002")
                {
                    string phai = node["Phai"].InnerText;
                    string nganh = node["Nganh"].InnerText;

                    listSV.Add(new SinhVienThuocNganh(ma, ten, gpa, sotc, khoa, phai, nganh));
                }
            }
        }

        public void XuatDanhSach()
        {
            foreach(SinhVien sv in listSV)
            {
                sv.Xuat();
                Console.WriteLine();
            }
        }
        public void DemSoLuongSinhVienGioi()
        {
            int dem = listSV.Count(t => t.XepLoai() == "Giỏi" || t.XepLoai() == "Xuất Sắc");

            Console.WriteLine($"SỐ LƯỢNG GIỎI TRỞ LÊN: {dem}");
        }

        public void SapXep()
        {
            listSV = listSV.OrderByDescending(t => t.Dtb).ThenBy(g => g.HoTen).ToList();
        }

        public SinhVien MaxGPA()
        {
            double max = listSV.Max(t => t.Dtb);
            return listSV.FirstOrDefault(g => g.Dtb == max);
        }
    }
}
