using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    public static class TienIch
    {
        public static void TieuDe()
        {
            Console.WriteLine(
                $"{"Mã NV",-10} {"Tên NV",-25} {"Phòng",-12} {"Chức Vụ",-12} " +
                $"{"HS Lương",-10} {"Thâm Niên",-10} {"Ngày Làm",-10} " +
                $"{"Lương CB",-12} {"HS Thi Đua",-10} {"Phụ Cấp",-12} {"Lương",-12}"
            );
            Console.WriteLine();
        }
    }
}
