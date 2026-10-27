using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    public interface IAccount
    {
        bool Login(string user, string pass);
        bool Logout();
        void GetAddress();
    }
}
