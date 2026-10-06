using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_BTVN
{
    public class TienIch
    {
        public static void TieuDe()
        {
            Console.WriteLine(
                $"{"Mã Phòng",-10} {"Số Lượng",-10} {"Giá Thuê",-15} {"Số Điện",-10} " +
                $"{"Máy Lạnh",-10} {"Tiền Phòng",-15}"
            );
            Console.WriteLine(new string('-', 80));
        }
    }
}
