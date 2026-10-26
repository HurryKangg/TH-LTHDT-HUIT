using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public abstract class CongTyT
    {
        protected string maNV;
        protected string tenNV;
        public string MaNV
        {
            get { return maNV; }
            set
            {
                if (!string.IsNullOrEmpty(value) &&
                    value.Length == 5 &&
                    value.StartsWith("NV") &&
                    value.Substring(2).All(char.IsDigit))
                    maNV = value;
                else
                    maNV = "NV000";
            }
        }

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        public CongTyT()
        {
            MaNV = "NV000";
            TenNV = "NO NAME";
        }
        public CongTyT(string ma, string ten)
        {
            this.MaNV = ma;
            this.TenNV = ten;
        }
        public abstract double Luong();
        public virtual void Xuat()
        {
            Console.WriteLine($"Mã nhân viên: {maNV} - Tên nhân viên: {tenNV}");
        }
        
    }
}
