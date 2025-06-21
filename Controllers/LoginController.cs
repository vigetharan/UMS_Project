using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public static bool CheckLogin(string username, string password)
        {
            string query = @"
        SELECT Users.Id, Users.Role, Persons.Name, Persons.Id
        FROM Users
        LEFT JOIN Persons ON Users.Id = Persons.Id
        WHERE Users.Username = @username AND Users.Password = @password";

            using (var dbconn = DatabaseManager.GetConnection())
            {
                using (var cmd = new SQLiteCommand(query, dbconn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            LoggedInUser.UserId = reader.GetInt32(0);
                            LoggedInUser.Role = (UserRole)reader.GetInt32(1);

                            // Persons.Name might be null if no matching person found
                            if (!reader.IsDBNull(2))
                            {
                                LoggedInUser.Name = reader.GetString(2);
                                LoggedInUser.PersonId = reader.GetInt32(3);
                                MessageBox.Show(LoggedInUser.Name);
                            }
                            else
                            {
                                throw new Exception("Person not found for the user");
                            }

                            MessageBox.Show($"Login Succeeded\n welcome{LoggedInUser.Name}");
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
        public bool IsUsernameTaken(string username)
        {
            bool isTaken = false;

            
                string query = "SELECT Username FROM Users WHERE Username = @username";

            using (var dbconn = DatabaseManager.GetConnection())
            {
                using (var cmd = new SQLiteCommand(query, dbconn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    dbconn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    isTaken = count > 0;
                }
            }

            return isTaken;
        }


    }
}
