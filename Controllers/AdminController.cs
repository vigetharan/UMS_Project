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
                string addAdminQuery = "INSERT INTO Admins ( AdminId, EmployeeNo, Salary, JoinedDate) VALUES (@adid, @employeeno, @salary, @joinedDate)";
                SQLiteCommand addCommand = new SQLiteCommand(addAdminQuery, dbconn);
                addCommand.Parameters.AddWithValue("adid", a.AdminId);
                addCommand.Parameters.AddWithValue("employeeno", a.EmployeeNo);
                addCommand.Parameters.AddWithValue("salary", a.Salary);
                addCommand.Parameters.AddWithValue("joinedDate", a.JoinedDate);
                addCommand.ExecuteNonQuery();
            }
                return "Admin added successfully";
        }
        public Admin GetAdminById(int adminId)
        {

            using (var dbconn = DatabaseManager.GetConnection())
            {
                string getAdminQuery = "SELECT * FROM Admins WHERE AdminId = @adminId";
                SQLiteCommand getCommand = new SQLiteCommand(getAdminQuery, dbconn);
                getCommand.Parameters.AddWithValue("@adminId", adminId);
                SQLiteDataReader reader = getCommand.ExecuteReader();

                if (reader.Read())
                {
                    return new Admin
                    {
                        AdminId = reader.GetInt32(0),
                        EmployeeNo = reader.GetString(1),
                        Salary = reader.GetDecimal(2),
                        JoinedDate = reader["JoinedDate"].ToString()
                    };
                }
                else
                {
                    return null;
                }
            }
        }

    }
}
