using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class ListNhanVien
    {
        private List<NhanVien> listNV;
        public List<NhanVien> ListNV
        {
            get { return listNV; }
            set { listNV = value; }
        }
        public ListNhanVien()
        {
            ListNV = new List<NhanVien>();
        }
        public void AddNV(NhanVien nv)
        {
            listNV.Add(nv);
        }

        public void NhapDanhSach()
        {
            int n = TienIch.NhapSoLuong("Nhập số lượng nhân viên: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"NHÂN VIÊN THỨ {i+1}");
                NhanVien dsNV = new NhanVien();
                dsNV.NhapNV();
                listNV.Add(dsNV);
            }
        }
        public void XuatDanhSach()
        {
            if(listNV.Count == 0)
            {
                Console.WriteLine("DANH SÁCH RỖNG VUI LÒNG THÊM NHÂN VIÊN!!!");
            }
            TienIch.TieuDe();
            foreach(NhanVien nv in listNV)
            {
                nv.Xuat();
            }
        }
        public double TongLuongNhanVien()
        {
            return ListNV.Sum(t => t.LuongNhanVien());
        }
        public void NhanVienLuongCao()
        {
            double maxLuong = listNV.Max(t => t.LuongNhanVien());
            listNV = listNV.Where(t => t.LuongNhanVien() == maxLuong).ToList();
        }
        public NhanVien TimMaxLuongNV()
        {
            double maxLuong = listNV.Max(t => t.LuongNhanVien());
            return listNV.FirstOrDefault(t=> t.LuongNhanVien() == maxLuong);
        }
        public void Sort()
        {
            listNV = listNV.OrderBy(t => t.NamVaoLam).ToList();
        }
        public bool TimNhanVien(NhanVien p)
        {
            NhanVien find = listNV.Find(t => t.MaNV == p.MaNV);
            if (find != null)
            {
                return true;
            }
            return false;
        }

        public bool XoaNhanVien(NhanVien p)
        {
            NhanVien find = listNV.Find(t => t.MaNV == p.MaNV);
            return (find == null) ? false : listNV.Remove(find);
        }
    }
}
