using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai2
{
    public class BDS
    {
        List<CongTyABC> dsbds;
        public List<CongTyABC> DsBDS
        {
            get { return dsbds; }
            set { dsbds = value; }
        }

        public BDS()
        {
            dsbds = new List<CongTyABC>();
        }

        public void DocFile(string filename)
        {
            XmlDocument read = new XmlDocument();
            read.Load(filename);

            XmlNodeList ds = read.SelectNodes("BDSs/BDS");
            foreach (XmlNode node in ds)
            {
                string loai = node["Loai"].InnerText;
                string ma = node["Ma"].InnerText;
                double dai = double.Parse(node["Dai"].InnerText);
                double rong = double.Parse(node["Rong"].InnerText);
                if(loai == "Dat trong")
                {
                    dsbds.Add(new DatTrong(ma, dai, rong));
                } else if(loai == "Nha o")
                {
                    int lau = int.Parse(node["SoLau"].InnerText);
                    dsbds.Add(new NhaLau(ma, dai, rong,lau));
                } else if(loai == "Biet thu")
                {
                    dsbds.Add(new BietThu(ma, dai, rong));
                } else if(loai == "Khach san")
                {
                    int sao = int.Parse(node["SoSao"].InnerText);
                    dsbds.Add(new KhachSan(ma, dai, rong, sao));
                }
            }
        }
        public void XuatDS()
        {
            foreach(CongTyABC ds in dsbds)
            {
                ds.Xuat();
                Console.WriteLine();
            }
        }

        public double TongGiaBan()
        {
            return dsbds.Sum(t => t.GiaBan());
        }

        public double TongKinhDoanh()
        {
            return dsbds.OfType<ITroGia>().Sum(t => t.hoTro());
        }
    }
}
