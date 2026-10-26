using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    public abstract class TaiKhoanTaXe : TaiKhoan
    {
        protected string maSo;
        protected string tenTX;
        CongTyUber hinhThuc;
        TaiKhoanKH goiXe;

        public string MaSo
        {
            get { return maSo; }
            set { maSo = value; }
        }
        public string TenTX
        {
            get { return tenTX; }
            set { tenTX = value; }
        }
        public TaiKhoanTaXe(): base()
        {
            MaSo = "TX000";
            TenTX = "Trần Minh Thông";
            hinhThuc = new CongTyUber();
        }
        public TaiKhoanTaXe(string user, string pass, string phone, bool IsLog, string ma, string ten, CongTyUber ct) :
            base(user, pass, phone, IsLog)
        {
            MaSo = ma;
            TenTX = ten;
            hinhThuc = ct;
        }

        public abstract double TinhTienChuyenDi();
        public abstract double TraPhiLaiChoCongTy();

        public void TinhHieuNhanCuocGoiXe(string viTriXe)
        {
             
        }
    }
}
