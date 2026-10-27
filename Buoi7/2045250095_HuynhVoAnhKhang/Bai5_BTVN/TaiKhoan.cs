using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN
{
    public class TaiKhoan: IAccount
    {
        protected string username;
        protected string password;
        protected string phone;
        protected bool trangThai;

        public string Username
        {
            get {  return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value;}
        }
        public TaiKhoan()
        {
            Username = "No Name";
            Password = "12345678";
            Phone = "090492424";
            TrangThai = false;
        }                     

        public TaiKhoan(string user, string pass, string phone, bool IsLog)
        {
            Username = user;
            Password = pass;
            Phone = phone;
            TrangThai= IsLog;
        }

        public bool Login(string user, string pass)
        {
            if (TrangThai)
            {
                Console.WriteLine($"Login {user} is succesfull...!!!");
                return true;
            }

            if(this.Username == user && this.Password == pass)
            {
                TrangThai = true;
                Console.WriteLine($"{user} - {pass} connected account....");
                return true;
            }
            Console.WriteLine("Error: connect is failed...");
            return false;
        }

        public bool Logout()
        {
            if (!TrangThai)
            {
                Console.WriteLine("Logout is succesfull...!!!");
                return false;
            }
            TrangThai = false;
            Console.WriteLine("Goodbye...");
            return true;
        }

        public void GetAddress()
        {
            Random r = new Random();
            if (!TrangThai)
            {
                Console.WriteLine("You need to login account!!!");
                return;
            }
            int rd = r.Next(0, 1000); //Random từ 0 - 1000
            Console.WriteLine($"{Username} - {Password} address random: {rd}");
        }

        public virtual void Xuat()
        {
            string isLog = (trangThai == true) ? "Online" : "Offline";
            Console.WriteLine($"Username: {username}");
            Console.WriteLine($"Password: {password}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"Trang thai: {isLog}");
        }

    }
}
