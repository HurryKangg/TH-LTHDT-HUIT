using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class SinhVien: Nguoi
    {
        string maSV;
        string heDT;
        int soTC;

        public string MaSV
        {
            get {  return maSV; }
            set { maSV = value; }
        }

        public string HeDT
        {
            get { return heDT; }
            set
            {
                if (value == "Cao dang" || value == "Dai hoc" || value == "Cao dang nghe")
                    heDT = value;
                else
                    heDT = "Dai hoc";
            }
        }

        public int SoTC
        {
            get { return soTC; }
            set
            {
                if(value >= 0)
                    soTC = value;
                else
                    soTC = 0;
            }
        }

        public SinhVien(): base()
        {
            MaSV = "SV000";
            HeDT = "Dai hoc";
            SoTC = 0;
        }

        public SinhVien(string ten, DateTime ngay, string gt, string ma, string heDT) : base(ten, ngay, gt)
        {
            MaSV = ma;
            HeDT = heDT;
            if (this.heDT == "Dai hoc")
                this.soTC = 150;
            else if (this.heDT == "Cao dang")
                this.soTC = 100;
            else
                this.soTC = 130;
        }


        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Ma sinh vien: {maSV}");
            Console.WriteLine($"He dao tao: {heDT}");
            Console.WriteLine($"Tong so tin chi: {soTC}");
            Console.WriteLine($"Tong hoc phi tin chi: {HocPhiTinChi():N0}");
            Console.WriteLine($"Tong hoc phi: {TongHocPhi():N0}");
        }

        public double TongHocPhi()
        {
            return SoTC * HocPhiTinChi();
        }

        public double HocPhiTinChi()
        {
            if (heDT.Equals("Dai hoc", StringComparison.OrdinalIgnoreCase))
                return 200000;
            else if (heDT.Equals("Cao dang", StringComparison.OrdinalIgnoreCase))
                return 150000;
            else if (heDT.Equals("Cao dang nghe", StringComparison.OrdinalIgnoreCase))
                return 120000;
            return 0;
        }


    }
}
