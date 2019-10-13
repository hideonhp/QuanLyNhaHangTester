using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.Control
{
    class LogInCtrl
    {
        public static string CheckDangNhap(string _user, String _pass)
        {
            try
            {
                Models.LogInBoiDoi logIn = new Models.LogInBoiDoi(_user, _pass);
                return logIn.CheckLogIn();
            }
            catch
            {
                return "";
            }
        }
    }
}
