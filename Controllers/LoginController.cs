using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Controllers
{
    internal class LoginController
    {
        public static void CheckLogin(string username, string Password, string Role, String Status )
        {

        }
        public static void CheckLogin(string username, string Password)
        {
            if (username == "admin" && Password == "1234")
            {
                MessageBox.Show("Login Succeeded");
            }
        }
    }
}
