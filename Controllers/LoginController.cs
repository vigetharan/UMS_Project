using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;
using static UnicomTICManagementSystem.Models.Enums;

namespace UnicomTICManagementSystem.Controllers
{
    internal class LoginController
    {
        public static void CheckLogin(string username, string Password, string Role, string Status)
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
                        if (reader.Read())
                        {
                            LoggedInUser.UserId = reader.GetInt32(0);
                            LoggedInUser.Role = (UserRole)reader.GetInt32(3);

                            int userid = LoggedInUser.UserId;
                            string persontablequery = "SELECT Id, Name FROM Persons WHERE Id = @userId";
                            using (var cmd1 = new SQLiteCommand(persontablequery, dbconn))
                            {
                                cmd1.Parameters.AddWithValue("@userId", userid);
                                using (SQLiteDataReader reader1 = cmd1.ExecuteReader())
                                {
                                    if (reader1.Read())
                                    {
                                        LoggedInUser.Name = reader1.GetString(1);
                                        MessageBox.Show(LoggedInUser.Name);

                                    }
                                    else
                                    {
                                        throw new Exception("Person not found for the user");
                                    }
                                }
                            }
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
