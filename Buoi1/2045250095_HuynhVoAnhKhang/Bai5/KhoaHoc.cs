using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai5
{
    public class KhoaHoc
    {
        public static double GiaHocPhi1Buoi = 100000;
        public static double GiangDay1Buoi = 500000;
        private string maKH;
        private string tenKH;
        private int soBuoi;
        private string gioHoc;
        private int soLuongHV;
        private string giangVien;
        public string MaKH
        {
            get { return maKH; }
            set
            {
                //string regex = "^KH[123]\\d{2}$";
                if (value != null && value.Length == 5 && value.StartsWith("KH") 
                    && (value[2] == '1' || value[2] == '2' || value[2] == '3')
                    && value.Substring(2).All(char.IsDigit))
                {
                    maKH = value;
                }
                else
                {
                    maKH = "KH100";
                }
            }
        }
        public string TenKH
        {
            get { return tenKH; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tenKH = value;
            }
        }

        public int SoBuoi
        {
            get { return soBuoi; }
            set
            {
                if (value > 0)
                    soBuoi = value;
            }
        }
        public string GioHoc
        {
            get { return gioHoc; }
            set
            {
                if (value == "2,4,6" || value == "3,5,7" || value == "7, CN")
                    gioHoc = value;
            }
        }
        public int SoLuongHV
        {
            get { return soLuongHV; }
            set
            {
                if (value >= 10 && value <= 20)
                    soLuongHV = value;
            }
        }
        public string GiangVien
        {
            get { return giangVien; }
            set
            {
                if (value != null)
                    giangVien = value;
            }

        }
        public KhoaHoc()
        {
            MaKH = "KH100";
            TenKH = "Lap Trinh Huong Doi Tuong";
            SoBuoi = 1;
            GioHoc = "2,4,6";
            SoLuongHV = 10;
            GiangVien = "Luong Thai Hien";
        }
        public KhoaHoc(string ma, string ten, int buoi, string gio, int sl, string gv)
        {
            this.MaKH = ma;
            this.TenKH = ten;
            this.SoBuoi = buoi;
            this.GioHoc = gio;
            this.SoLuongHV = sl;
            this.GiangVien = gv;
        }
        public double HocPhi()
        {
            if (gioHoc == "2,4,6" || gioHoc == "3,5,7")
                return soBuoi * GiaHocPhi1Buoi;
            return soBuoi * GiaHocPhi1Buoi * 1.2;
        }
        public double ThanhToanChoGV()
        {
            double thuLao = soBuoi * GiangDay1Buoi;
            if (soLuongHV >= 15)
            {
                thuLao += soBuoi * soLuongHV * 10000;
            }
            return thuLao;
            
        }
        // 5. Phương thức nhập thông tin khóa học
        public void NhapThongTin()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhập mã khóa học (VD: KH101): ");
                    MaKH = Console.ReadLine();
                    break;
                }
                catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhập tên khóa học: ");
                    TenKH = Console.ReadLine();
                    break;
                }
                catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhập số buổi: ");
                    SoBuoi = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex) { Console.WriteLine("Lỗi: " + ex.Message); }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhập giờ học ('2, 4, 6' / '3, 5, 7' / '7, CN'): ");
                    string input = Console.ReadLine();
                    // Nếu để trống thì dùng mặc định
                    if (string.IsNullOrWhiteSpace(input))
                        GioHoc = "2, 4, 6";
                    else
                        GioHoc = input;
                    break;
                }
                catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhập số lượng học viên (10-20): ");
                    SoLuongHV = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex) { Console.WriteLine("Lỗi: " + ex.Message); }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhập giáo viên giảng dạy: ");
                    GiangVien = Console.ReadLine();
                    break;
                }
                catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
            }
        }

        // 6. Phương thức xuất thông tin khóa học
        public void XuatThongTin()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Mã khóa học        : " + MaKH);
            Console.WriteLine("Tên khóa học       : " + TenKH);
            Console.WriteLine("Số buổi            : " + SoBuoi);
            Console.WriteLine("Giờ học            : " + GioHoc);
            Console.WriteLine("Số lượng học viên  : " + SoLuongHV);
            Console.WriteLine("Giáo viên giảng dạy: " + GiangVien);
            Console.WriteLine($"Giá học phí 1 buổi : {GiaHocPhi1Buoi:#,##0} (nghìn đồng)");
            Console.WriteLine($"Học phí khóa học   : {HocPhi():#,##0} (nghìn đồng)");
            Console.WriteLine($"Thù lao 1 buổi     : {GiangDay1Buoi:#,##0} (nghìn đồng)");
            Console.WriteLine($"Số tiền giáo viên nhận: {ThanhToanChoGV():#,##0} (nghìn đồng)");
            Console.WriteLine("========================================");
        }
    }

}
