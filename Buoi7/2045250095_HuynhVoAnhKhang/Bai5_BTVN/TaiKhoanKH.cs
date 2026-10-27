using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    public class TaiKhoanKH : TaiKhoan, IAccount
    {
        protected string loai;   
        public string Loai
        {
            get { return loai; }
            set
            {
                if (value == "VIP")
                    loai = value;
                else
                    loai = "Normal";
            }
        }
        

        public TaiKhoanKH() : base()
        {
            loai = "Normal";
        }

        public TaiKhoanKH(string user, string pass, string phone, bool IsLog, string loai) :
            base(user, pass, phone, IsLog)
        {
            this.Loai = loai;
        }

        public void GoiXe(string loaiXe, string diaChi)
        {
                if (!TrangThai)
                {
                    Console.WriteLine("Bạn cần đăng nhập trước khi gọi xe!");
                    return;
                }
                Console.WriteLine($"Khách {Username} gọi {loaiXe} tại {diaChi}");
           
        }   
        public bool IsVIP()
        {
            if(loai.Equals("VIP", StringComparison.OrdinalIgnoreCase))
                return true;
            else return false;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Loại: {loai}");
        }
    }
}
