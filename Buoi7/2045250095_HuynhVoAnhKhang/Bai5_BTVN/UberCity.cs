using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai5_BTVN
{
    public class UberCity
    {
        List<Vehicle> dsXe;
        List<TaiKhoanKH> dsKH;
        List<TaiKhoanTaiXe> dsTX;
        List<ChuyenXe> dsCX;

        public List<Vehicle> DsXe
        {
            get { return dsXe; }
            set { dsXe = value; }
        }
        public List<TaiKhoanKH> DsKH
        {
            get { return dsKH; }
            set { dsKH = value; }
        }
        public List<TaiKhoanTaiXe> DsTX
        {
            get { return dsTX; }
            set { dsTX = value; }
        }

        public List<ChuyenXe> DsCX
        {
            get { return dsCX; }
            set { dsCX = value; }
        }

        public UberCity()
        {
            dsXe = new List<Vehicle>();
            dsKH = new List<TaiKhoanKH>();
            dsTX = new List<TaiKhoanTaiXe>();
            dsCX = new List<ChuyenXe>();
        }

        public void DocFileXe(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);

            XmlNode xe = read.SelectSingleNode("UberData/Vehicles");
            XmlNode kh = read.SelectSingleNode("UberData/Customers");
            XmlNode tx = read.SelectSingleNode("UberData/Drivers");
            XmlNode cx = read.SelectSingleNode("UberData/Trips");

            if (xe != null)
            {
                foreach (XmlNode node in xe.ChildNodes)
                {
                    string loai = node.Attributes["Loai"].Value;
                    if (loai == "ganMay"){
                        dsXe.Add(new GanMay)
                    }
                }
            }
        }
    }
}
