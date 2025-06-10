using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class LoginController
    {
        public static void CheckLogin(string username, string Password, string Role, string Status )
        {

        }
        public static bool CheckLogin(string user, string pass)
        {
            string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
            using (var dbconn = DatabaseManager.GetConnection())
            {
                using (var cmd = new SQLiteCommand(query, dbconn))
                {
                    cmd.Parameters.AddWithValue("@username", user);
                    cmd.Parameters.AddWithValue("@password", pass);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Login Succeeded");
                            return true;
                            
                        }
                        else
                        {
                            MessageBox.Show("Login Failed");
                            return false;
                        }
                    }
                }
            }

        }
    }
}
