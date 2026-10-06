using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai5_BTVN
{
    public class CongTy
    {
        private string tenCongTy;
        private string diaChi;
        private string sdt;
        private List<NhanVien> listNV;

        public string TenCongTy
        {
            get { return tenCongTy; }
            set { tenCongTy = value; }
        }
        public string DiaChi { get { return diaChi; } set { diaChi = value; } }
        public string SDT { get { return sdt; } set { sdt = value; } }

        public List<NhanVien> ListNV { get { return listNV; } set { listNV = value; } }

        public CongTy()
        {
            listNV = new List<NhanVien>();
        }

        public void DocFileDanhSach(string file)
        {
            if (file == null)
            {
                Console.WriteLine("ĐỌC FILE {0} KHÔNG THÀNH CÔNG!!", file);
                return;
            }
            XmlDocument read = new XmlDocument();
            read.Load(file);

            XmlNode root = read.SelectSingleNode("/CongTy");

            TenCongTy = root["TenCongTy"]?.InnerText.Trim();
            DiaChi = root["DiaChi"]?.InnerText.Trim();
            SDT = root["SDT"]?.InnerText.Trim();

            XmlNodeList ds = root.SelectNodes("DSNhanVien/NhanVien");
            foreach (XmlNode node in ds)
            {
                NhanVien nv = new NhanVien();

                nv.MaNV = node.Attributes["Ma"].Value;

                nv.TenNV = node["Ten"]?.InnerText.Trim();
                nv.PhongBan = node["Phong"]?.InnerText.Trim();
                nv.ChucVu = node["ChucVu"]?.InnerText.Trim();
                nv.HeSoLuong = double.Parse(node["HeSoLuong"].InnerText);
                nv.ThamNienCongTac = int.Parse(node["ThamNienCongTac"].InnerText);
                nv.SoNgayLamViec = int.Parse(node["SoNgayLamViecTheoThang"].InnerText);

                listNV.Add(nv);
            }
        }

        public void XuatDanhSach()
        {
            Console.WriteLine($"Tên Công Ty: {tenCongTy}");
            Console.WriteLine($"Địa chỉ: {diaChi} ");
            Console.WriteLine($"Số điện thoại: {sdt}");

            if(listNV.Count == 0)
            {
                Console.WriteLine("DANH SÁCH NHÂN VIÊN ĐANG RỖNG!!!");
                return;
            }

            Console.WriteLine(new string('-', 140));
            Console.WriteLine("\t\t\t\t\t\t\tDANH SÁCH NHÂN VIÊN");
            Console.WriteLine(new string('-', 140));
            TienIch.TieuDe();
            foreach (NhanVien nv in listNV)
            {
                nv.Xuat();
            }
        }        
        public double TinhTongLuong()
        {
            return listNV.Sum(t => t.Luong());
        }

        public void DanhSachLanhDao()
        {
            if (listNV.Count == 0)
            {
                Console.WriteLine("DANH SÁCH NHÂN VIÊN ĐANG RỖNG!!!");
                return;
            }

            foreach(NhanVien nv in listNV.Where(t => t.ChucVu == "Lãnh đạo"))
            {
                nv.Xuat();
            }
        }
        public void LocDanhSachX()
        {
            if (listNV.Count == 0)
            {
                Console.WriteLine("DANH SÁCH NHÂN VIÊN ĐANG RỖNG!!!");
                return;
            }

            
            Console.Write("NHẬP PHÒNG X: ");
            string x = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(x))
            {
                Console.WriteLine("Tên phòng không được để trống!");
                return;
            }
            
            foreach (NhanVien nv in listNV.Where(t => t.PhongBan.Equals(x, StringComparison.OrdinalIgnoreCase)))
            {
                nv.Xuat();
            }
        }

        public void XoaCacNhanVienSoNgayLamViec()
        {
            if (listNV.Count == 0)
            {
                Console.WriteLine("DANH SÁCH NHÂN VIÊN ĐANG RỖNG!!!");
                return;
            }
            int xoa = listNV.RemoveAll(t => t.SoNgayLamViec < 10);
            
            if (xoa == 0)
                Console.WriteLine("XÓA KHÔNG THÀNH CÔNG!!!");
            else
                Console.WriteLine($"ĐÃ XÓA {xoa} NHÂN VIÊN CÒN LẠI {listNV.Count} NHÂN VIÊN");
                NhanVien nvXoa = new NhanVien();
                nvXoa.Xuat();

            Console.WriteLine();
            Console.WriteLine("SỐ NHÂN VIÊN CÒN LẠI TRONG DANH SÁCH");
            foreach(NhanVien nv in listNV)
            {
                nv.Xuat();
            }
        }

        public void LocDanhSachKhongLanhDaoLonHon22()
        {
            if (listNV.Count == 0)
            {
                Console.WriteLine("DANH SÁCH NHÂN VIÊN ĐANG RỖNG!!!");
                return;
            }

            foreach (NhanVien nv in listNV.Where(t => !t.ChucVu.Equals("Lãnh đạo", StringComparison.OrdinalIgnoreCase) && t.SoNgayLamViec > 22))
            {
                nv.Xuat();
            }

        }

        public void SapXepLuong()
        {
            if (listNV.Count == 0)
            {
                Console.WriteLine("DANH SÁCH NHÂN VIÊN ĐANG RỖNG!!!");
                return;
            }

            listNV = listNV.OrderByDescending(t => t.Luong()).ToList();

        }

        public void SapXepNhanVien()
        {
            if (listNV.Count == 0)
            {
                Console.WriteLine("DANH SÁCH NHÂN VIÊN ĐANG RỖNG!!!");
                return;
            }

            listNV = listNV.OrderByDescending(t => t.Luong()).ThenBy(g => g.TenNV).ToList();

        }
        
    }
}
