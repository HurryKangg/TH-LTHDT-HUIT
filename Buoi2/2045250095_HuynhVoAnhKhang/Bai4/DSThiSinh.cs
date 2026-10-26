using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class DSThiSinh
    {
        private List<ThiSinh> listTS;
        public List<ThiSinh> ListTS { get { return listTS; } set { listTS = value; } }

        public DSThiSinh()
        {
            listTS = new List<ThiSinh>();
        }

        public void NhapDanhSach()
        {
            int n = TienIch.NhapSo("Nhập số lượng thí sinh: ");

            for(int  i = 0; i < n; i++)
            {
                Console.WriteLine($"THÍ SINH THỨ: {i + 1}");
                ThiSinh dsTS = new ThiSinh();
                dsTS.Nhap();
                listTS.Add( dsTS );
            }
        }

        public void XuatDS()
        {
            if(listTS.Count == 0)
            {
                Console.WriteLine("DANH SÁCH THÍ SINH RỖNG!!!");
                return;
            }
            
            else
            {   
                Console.WriteLine("====== DANH SÁCH THÍ SINH ======");
                foreach (ThiSinh ts in listTS)
                {
                    ts.Xuat();
                    Console.WriteLine();
                }
            }
        }

        public void XuatDanhSachThiSinhDau()
        {
            if (listTS.Count == 0)
            {
                Console.WriteLine("DANH SÁCH THÍ SINH RỖNG!!!");
                return;
            }
            
            else
            {   
                Console.WriteLine("====== DANH SÁCH THÍ SINH ĐẬU ======");
                bool dau = false;
                foreach (ThiSinh ts in listTS.Where(ts => ts.KetQua() == "Đậu"))
                {
                    ts.Xuat();
                    Console.WriteLine();
                    dau = true;
                }
                if (!dau)
                {
                    Console.WriteLine("DANH SÁCH KHÔNG CÓ THÍ SINH NÀO ĐẬU");
                }
            }
        }
        public void TinhTongSoThiSinh()
        {
            int tongThiSinhDau = listTS.Count(t => t.KetQua() == "Đậu");
            int tongThiSinhRot = listTS.Count - tongThiSinhDau;

            Console.WriteLine($"TỔNG SỐ THÍ SINH:  {listTS.Count}");
            Console.WriteLine($"TỔNG SỐ THÍ SINH ĐẬU: {tongThiSinhDau}");
            Console.WriteLine($"TỔNG SỐ THÍ SINH RỚT: {tongThiSinhRot}");
        }

        public void TimMaSinhVien()
        {
            if (listTS.Count == 0)
            {
                Console.WriteLine("DANH SÁCH THÍ SINH RỖNG!!!");
                return;
            }
            Console.Write("Tìm mã thí sinh: ");
            string ma = Console.ReadLine();         
            if(string.IsNullOrWhiteSpace(ma))
            {
                Console.WriteLine("Mã thí sinh không hợp lệ.");
                return;
            }
            foreach(ThiSinh ts in listTS.Where(t => t.MaThiSinh.Equals(ma, StringComparison.OrdinalIgnoreCase)))
            {
                ts.Xuat();
            }
            Console.WriteLine("Không tìm thấy thí sinh!");
        }

        public void Sort()
        {
            if (listTS.Count == 0)
            {
                Console.WriteLine("DANH SÁCH THÍ SINH RỖNG!!!");
                return;
            }
            listTS = listTS.OrderByDescending(t => t.TinhTongKet()).ToList();
        }
    }
}
