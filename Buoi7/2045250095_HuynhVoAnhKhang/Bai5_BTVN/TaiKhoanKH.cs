using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    public class TaiKhoanKH : TaiKhoan
    {
        protected string loai;
        CongTyUber xe;
        public string Loai
        {
            get { return loai; }
            set
            {
                if (value == "VIP" || value == "Normal")
                    loai = value;
                else
                    loai = "Normal";
            }
        }
        

        public TaiKhoanKH() : base()
        {
            loai = "Normal";
            xe = new CongTyUber();
        }

        public TaiKhoanKH(string user, string pass, string phone, bool IsLog, string loai, CongTyUber ct) :
            base(user, pass, phone, IsLog)
        {
            this.Loai = loai;
            this.xe = ct;
        }

        public void GoiXe(string loaiXe, string diaChi)
        {
            if (TrangThai)
            {
                Console.WriteLine("Tiến hành gọi xe...");
            }
            if (loaiXe.Equals(xe.GanMay, StringComparison.OrdinalIgnoreCase))
            {
                loaiXe = xe.GanMay;
            } else if(loaiXe.Equals(xe.OTo, StringComparison.OrdinalIgnoreCase))
            {
                loaiXe = xe.OTo;
            }else if(loaiXe.Equals(xe.OtoTai, StringComparison.OrdinalIgnoreCase))
            {
                loaiXe = xe.OtoTai;
            } else
            {
                Console.WriteLine("Không có những loại xe trên...");
                return;
            }

            Console.WriteLine($"Loại xe: {loaiXe} - địa chỉ: {diaChi}");
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Loại: {loai}");
        }
    }
}
