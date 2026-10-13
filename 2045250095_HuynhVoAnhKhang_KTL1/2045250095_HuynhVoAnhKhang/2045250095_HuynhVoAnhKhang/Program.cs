using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2045250095_HuynhVoAnhKhang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            SieuThi st = new SieuThi();
            Console.WriteLine("CHƯƠNG TRÌNH NHẬP THÊM SỐ LƯỢNG SẢN PHẨM VÀO DANH SÁCH");
            st.NhapSanPham();
            st.XuatSieuThi();
            Console.WriteLine();

            Console.WriteLine("CHƯƠNG TRÌNH DANH SÁCH ĐỌC FILE");
            st.DocFileDanhSach(@"..\..\sieuThi.xml");
            st.XuatSieuThi();
            Console.WriteLine();

            Console.WriteLine("TỔNG GIÁ TRỊ SẢN PHẨM Ở SIÊU THỊ: {0:N0}", st.TinhTongGiaTriTatCaSanPham());
            Console.WriteLine();

            Console.WriteLine("SẮP XẾP DANH SÁCH SẢN PHẨM");
            st.SapXepSanPham();
            st.XuatSieuThi();
            Console.WriteLine();

            Console.WriteLine("SẢN PHẨM CÓ TỔNG GIÁ TRỊ LỚN NHẤT CỦA SIÊU THỊ");
            st.DanhSachTongLonNhat();
            st.XuatSieuThi();
        }
    }
}
