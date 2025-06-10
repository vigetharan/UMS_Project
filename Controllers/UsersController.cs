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
        public string AddUser(User u)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string addUserQuery = "INSERT INTO Users ( Username,Password,Role,Status) VALUES (@username,@password,@role,@status)";
                SQLiteCommand addCommand = new SQLiteCommand(addUserQuery, dbconn);
                addCommand.Parameters.AddWithValue("@Username", u.Username);
                addCommand.Parameters.AddWithValue("@Password", u.Password);
                addCommand.Parameters.AddWithValue("@Role", u.Role);
                addCommand.Parameters.AddWithValue("@Status", u.Status);

                addCommand.ExecuteNonQuery();
            }
            return "USER REGISTERED SUCCESSFULLY";


        }
    }
}
