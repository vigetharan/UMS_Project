using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class UsersController
    {
        public int AddUser(User u)
        {
            int uId;
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string addUserQuery = "INSERT INTO Users ( Username,Password,Role,Status) VALUES (@username,@password,@role,@status)";
                SQLiteCommand addCommand = new SQLiteCommand(addUserQuery, dbconn);
                addCommand.Parameters.AddWithValue("@username", u.Username);
                addCommand.Parameters.AddWithValue("@password", u.Password);
                addCommand.Parameters.AddWithValue("@role", u.Role);
                addCommand.Parameters.AddWithValue("@status", u.Status);

                addCommand.ExecuteNonQuery();
                string LastIdQuery = "SELECT last_insert_rowid()";
                SQLiteCommand idCommand = new SQLiteCommand(LastIdQuery, dbconn);
                uId = Convert.ToInt32(idCommand.ExecuteScalar());
            }
            MessageBox.Show(uId.ToString());
            return uId;


        }
    }
}
