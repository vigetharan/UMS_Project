using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Repositories;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class AdminController
    {
        public string AddAdmin(Admin a)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string addAdminQuery = "INSERT INTO Admins ( AdminId, EmployeeNo, Salary, JoinedDate, PrivilageLevel) VALUES (@adid, @employeeno, @salary, @joinedDate, @plevel)";
                SQLiteCommand addCommand = new SQLiteCommand(addAdminQuery, dbconn);
                addCommand.Parameters.AddWithValue("@adid", a.AdminId);
                addCommand.Parameters.AddWithValue("@employeeno", a.EmployeeNo);
                addCommand.Parameters.AddWithValue("@salary", a.Salary);
                addCommand.Parameters.AddWithValue("@joinedDate", a.JoinedDate);
                addCommand.Parameters.AddWithValue("@plevel", a.PrivilageLevel);
                addCommand.ExecuteNonQuery();
            }
                return "Admin added successfully";
        }
    }
}
