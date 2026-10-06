using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class ListPhanSo
    {
        List<PhanSo> listPS;
        public List<PhanSo> ListPS { get {  return listPS; } set {  listPS = value; } }
        public ListPhanSo()
        {
            ListPS = new List<PhanSo>(); 
        }
        public int NhapSoLuong(string tb)
        {
            while (true)
            {
                Console.Write(tb);
                if(int.TryParse(Console.ReadLine(), out int n))
                {
                    return n;
                }
                Console.WriteLine("Vui Lòng Nhập Lại Số Lượng!!!");
            }
        }
        public void AddPhanSo(PhanSo ps)
        {
            listPS.Add(ps);
        }
        //a nhập danh sách phân số
        public void NhapDanhSachPS()
        {
            int n = NhapSoLuong("Nhập số phần tử: ");
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine($"Phân số thứ {i + 1}: ");
                PhanSo dsPS = new PhanSo();
                dsPS.Nhap();
                listPS.Add(dsPS);
            }
        }
        //b Xuất danh sách phân số
        public void XuatDanhSach()
        {
            if(listPS.Count == 0)
            {
                Console.WriteLine("DANH SÁCH PHÂN SỐ RỖNG!!!");
                return;
            }
            else
            {
                foreach(PhanSo dsPS in listPS)
                {
                    dsPS.Xuat();
                }
            }
        }
        //c tối giản phân số
        public void ToiGianPS()
        {
            foreach(PhanSo dsPS in listPS)
            {
                dsPS.ToiGianPS();
            }
        } 
        //d tìm phân số
        public bool SearchPS(PhanSo p)
        {
            PhanSo k = ListPS.Find(t => t.GiaTriThua == p.GiaTriThua);

            if (k == null)
                return false;
            return true;
        }
        //e sắp xếp tăng dần
        public void SortGiaTri()
        {
            ListPS = ListPS.OrderBy(t => t.GiaTriThua).ToList();
        }
        //f tìm số lớn hơn 1
        public ListPhanSo TimThoaLonHon1()
        {
            ListPhanSo ds = new ListPhanSo();
            ds.ListPS = ListPS.Where(t => t.TuSo > t.MauSo).ToList();
            return ds;
        }
        //g tìm max
        public PhanSo MaxPS()
        {
            double max = ListPS.Max(t => t.GiaTriThua);
            return ListPS.FirstOrDefault(x => x.GiaTriThua == max);
        }
        //h tìm top 3 phân số
        public void Top3PS()
        {
            listPS = ListPS.OrderByDescending(t => t.GiaTriThua).Take(3).ToList();
        }

        public PhanSo TongPS()
        {
            PhanSo tong = new PhanSo();
            foreach(PhanSo t in listPS)
            {
                tong = tong.CongPS(t);
            }
            return tong;
        }

        public bool XoaPS(PhanSo ps)
        { 
            PhanSo xoa = ListPS.Find(t => t.GiaTriThua == ps.GiaTriThua);
            return (xoa == null) ? false : listPS.Remove(xoa);
        }

    }
}
