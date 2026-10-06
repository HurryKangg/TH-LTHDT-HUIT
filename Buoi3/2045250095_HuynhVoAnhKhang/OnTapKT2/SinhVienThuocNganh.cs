using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKT2
{
    public class SinhVienThuocNganh: SinhVien
    {

        private string phai;
        private string nganh;
   

        public string Phai { get { return phai; } set { phai  = value; } }
        public string Nganh { get { return nganh; } set { nganh = value; } }

        public SinhVienThuocNganh() : base()
        {
            Phai = "Nam";
            Nganh = "UNKNOWN";
        }

        public SinhVienThuocNganh(string ma, string ten, double dtb, int so, string khoa, string phai, string nganh)
            : base(ma, ten, dtb, so, khoa)
        {
            Phai = phai;
            Nganh = nganh;
        }

        public SinhVienThuocNganh(SinhVienThuocNganh obj)
        {
            Phai = obj.Phai;
            Nganh = obj.Nganh;
        }

        public override string XepLoai()
        {
            return base.XepLoai();
        }

         public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Phái: {phai}");
            Console.WriteLine($"Ngành: {nganh}");
        }

    }
}
