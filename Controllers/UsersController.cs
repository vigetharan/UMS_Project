using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class UsersController
    {
        public int AddUser(User u)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string addUserQuery = "INSERT INTO Users ( Username,Password,Role,Status) VALUES (@username,@password,@role,@status)";
                SQLiteCommand addCommand = new SQLiteCommand(addUserQuery, dbconn);
                addCommand.Parameters.AddWithValue("@username", u.Username);
                addCommand.Parameters.AddWithValue("@password", u.Password);
                addCommand.Parameters.AddWithValue("@role", u.Role);
                addCommand.Parameters.AddWithValue("@status", u.Status);

                addCommand.ExecuteNonQuery();
            }
            return u.Id;


        }
    }
}
