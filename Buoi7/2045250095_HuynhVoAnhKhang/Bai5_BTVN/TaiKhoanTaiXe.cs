using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    public abstract class TaiKhoanTaiXe : TaiKhoan
    {
        protected string maSo;
        protected string tenTX;
        protected Vehicle hinhThuc;

        protected double doanhThuTrongNgay = 0;

        public double DoanhThuTrongNgay
        {
            get { return doanhThuTrongNgay; }
            set { doanhThuTrongNgay = value; }
        }

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
        public Vehicle HinhThuc
        {
            get { return hinhThuc; }
            set {  hinhThuc = value; }
        }
        public TaiKhoanTaiXe(): base()
        {
            MaSo = "TX000";
            TenTX = "Trần Minh Thông";
            
        }
        public TaiKhoanTaiXe(string user, string pass, string phone, bool IsLog, string ma, string ten, Vehicle ht) :
            base(user, pass, phone, IsLog)
        {
            MaSo = ma;
            TenTX = ten;
            HinhThuc = ht;
        }

        public abstract double TinhTienChuyenDi(double khoangCach, DateTime hour);
        public abstract double Phi();
        public double TongPhiCongTy(double giaCuoc)
        {
            return giaCuoc * Phi();
        }
        public double ThemDoanhThu(double giaCuoc)
        {
            return DoanhThuTrongNgay += giaCuoc;
        }

        public void TinhHieuNhanCuocGoiXe(int diaChiKH)
        {
            Console.WriteLine($"Tài xế {TenTX} nhận cuộc gọi. Vị trí khách: {diaChiKH}");
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Mã số: {maSo}");
            Console.WriteLine($"Tên TX: {tenTX}");
            Console.WriteLine($"Hình thức: {hinhThuc.LoaiXe}");
        }
    }
}
