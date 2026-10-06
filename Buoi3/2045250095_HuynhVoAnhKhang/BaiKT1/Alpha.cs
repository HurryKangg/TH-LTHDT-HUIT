using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BaiKT1
{
    public class Alpha
    {
        public static string hangXe = "Alpha";
        private string soKhung;
        private string soMay;
        private int soCho;
        private int dongCoDien;
        private int congSuat;

        public string SoKhung
        {
            get { return soKhung; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 5 && value.StartsWith("T"))
                    soKhung = value;
                else
                    soKhung = "T0000";
            }
        }

        public string SoMay
        {
            get { return soMay; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 5 && value.StartsWith("A"))
                    soMay = value;
                else
                    soMay = "A0000";
            }
        }

        public int SoCho
        {
            get { return soCho; }
            set
            {
                if(value >= 0 )
                    soCho = value;
                else
                    soCho = 0;
            }

        }

        public int DongCo
        {
            get { return dongCoDien; }
            set
            {
                dongCoDien = value;
            }
        }

        public int CongSuat
        {
            get { return congSuat; }
            set
            {
                if (value >= 0)
                    congSuat = value;
                else
                    congSuat = 0;
            }
        }

        public Alpha()
        {
            SoKhung = "T0000";
            SoMay = "A0000";
            SoCho = 4;
            DongCo = 0;
            CongSuat = 100;
        }

        public Alpha(Alpha p)
        {
            SoKhung = p.SoKhung;
            SoMay = p.SoMay;
            SoCho = p.SoCho;
            DongCo = p.DongCo;
            CongSuat= p.CongSuat;
        }

        public Alpha(string khung, string may, int cho, int dongco, int congSuat)
        {
            SoKhung = khung;
            SoMay = may;
            SoCho = cho;
            DongCo = dongco;
            CongSuat = congSuat;
        }

        public string CongSuatCao()
        {
            if (congSuat > 100)
                return "Cong suat cao";
            else
                return "Khong thuoc cong suat cao";
        }
        public void Xuat()
        {
            string trangThaiDongCo = (DongCo == 1) ? "Có" : "Không";
            Console.WriteLine(
                $"{soKhung,-12} {soMay,-12} {soCho,-12} {trangThaiDongCo,-17} " +
                $"{congSuat,-14} {CongSuatCao(),-25} {hangXe,-12}"
            );
        }
    }
}
