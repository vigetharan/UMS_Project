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
using UnicomTICManagementSystem.Dto;
using UnicomTICManagementSystem.Models;
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
        public LoggedInUser GetLoggedInUser(string username)
        {
            int userId;
            int personID;
            string name;
            Enums.UserRole role;
            Enums.PrivilageLevel accesslevel;

            string usertablequery = "SELECT Id, Role, AccessLevel FROM Users WHERE Username = @username";
            using (var dbconn = DatabaseManager.GetConnection())
            {
                using (var cmd = new SQLiteCommand(usertablequery, dbconn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userId = reader.GetInt32(0);
                            role = (Enums.UserRole)reader.GetInt32(1);
                            accesslevel = (Enums.PrivilageLevel)reader.GetInt32(2);
                        }
                        else
                        {
                            throw new Exception("User not found");
                        }
                    }
                }
                string persontablequery = "SELECT Id, Name FROM Persons WHERE UserId = @userId";
                using (var cmd = new SQLiteCommand(persontablequery, dbconn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            personID = reader.GetInt32(0);
                            name = reader.GetString(1);
                        }
                        else
                        {
                            throw new Exception("Person not found for the user");
                        }
                    }
                }
                return new LoggedInUser
                {
                    UserId = userId,
                    Role = role,
                    PersonId = personID,
                    Name = name,
                    PrivilageLevel = accesslevel
                };
            }
        }
    }
}
