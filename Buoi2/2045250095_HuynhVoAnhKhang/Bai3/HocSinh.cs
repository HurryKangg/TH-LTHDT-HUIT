using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{

    public class HocSinh
    {

        private string maHS;
        private string tenHS;
        private List<MonHoc> listMH;
        public string MaHS
        {
            get { return maHS; }
            set { maHS = value; }
        }
        public string TenHS
        {
            get { return tenHS; }
            set { tenHS = value; }
        }
        public List<MonHoc> ListMH
        {
            get { return listMH; }
            set { listMH = value; }
        }
        public HocSinh()
        {
            maHS = "SV000";
            TenHS = "Chưa xác định";
            listMH = new List<MonHoc>();
        }
        public HocSinh(string ma, string ten)
        {
            this.MaHS = ma;
            this.TenHS = ten;
            listMH = new List<MonHoc>();
        }
        public HocSinh(string ma, string ten, List<MonHoc> listMH)
        {
            this.MaHS = ma;
            this.TenHS = ten;
            this.ListMH = listMH;
        }
        public void NhapThongTin()
        {
            Console.Write("Nhập mã sinh viên: ");
            MaHS = Console.ReadLine();
            Console.Write("Nhập tên sinh viên: ");
            TenHS = Console.ReadLine();

            int n = TienIch.NhapSo("Nhập số lượng: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Môn học thứ {i + 1}");
                MonHoc dsMH = new MonHoc();
                dsMH.NhapMH();
                listMH.Add(dsMH);
            }
        }
        public void XuatThongTin()
        {
            Console.WriteLine($"{maHS,-8} {tenHS,-25}");
            
            if(listMH.Count == 0)
            {
                Console.WriteLine("DANH SÁCH MÔN HỌC ĐANG RỖNG");
                return;
            }

            Console.WriteLine("\n================ DANH SÁCH MÔN HỌC =================");
            TienIch.TieuDeMH();
            foreach (MonHoc mh in listMH)
            {
                mh.Xuat();
              
            }
            Console.WriteLine("=====================================================");
        }
        public double DTB()
        {
            if (listMH.Count == 0) return 0;
            return listMH.Average(r => r.TongKet());
        }
        public string XepLoai()
        {
            double dtb = DTB();
            double diemThapNhat = listMH.Count > 0 ? listMH.Min(t => t.TongKet()) : 0;
            if (dtb >= 8 && diemThapNhat >= 6.5)
                return "Giỏi";
            else if (dtb >= 6.5 && diemThapNhat >= 5.0)
                return "Khá";
            else if (dtb >= 5 && diemThapNhat >= 3.5)
                return "Trung bình";
            else if (dtb >= 3.5 && diemThapNhat >= 2.0)
                return "Yếu";
            else
                return "Kém";
        }
        public string KetQuaHocTapHocSinh()
        {
            string xepLoai = XepLoai();
            if (xepLoai.Equals("Giỏi", StringComparison.OrdinalIgnoreCase) ||
               xepLoai.Equals("Khá", StringComparison.OrdinalIgnoreCase) ||
               xepLoai.Equals("Trung bình", StringComparison.OrdinalIgnoreCase))
                return "Được lên lớp";
            else if (xepLoai.Equals("Yếu", StringComparison.OrdinalIgnoreCase))
                return "Thi lại";
            else
                return "Ở lại lớp";
        }
        public void DanhSachMonDat()
        {
            if(listMH.Count == 0)
            {
                Console.WriteLine("DANH SÁCH MÔN HỌC RỖNG");
                return;
            }
            else
            {
                Console.WriteLine($"\nDanh sách môn Đạt của sinh viên {tenHS} (Mã: {maHS}):");
                bool coMonDat = false;
                foreach (MonHoc mh in listMH.Where(t => t.KetQua() == "Đạt"))
                {
                    Console.WriteLine($"- {mh.TenMH} (Mã: {mh.MaMH}) - Điểm tổng kết: {mh.TongKet():F1}");
                    coMonDat = true;
                    if (!coMonDat)
                    {
                        Console.WriteLine($"Môn: {mh.TenMH} chưa đạt");
                    }

                }  
                
            }
        }
    }
}
