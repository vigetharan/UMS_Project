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
    internal class StaffController
    {

        public string AddStaff(Staff s)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string addStaffQuery = "INSERT INTO Staffs ( StaffId, EmployeeNo, Salary, JoinedDate) VALUES (@stfid, @employeeno, @salary, @joinedDate)";
                SQLiteCommand addCommand = new SQLiteCommand(addStaffQuery, dbconn);
                addCommand.Parameters.AddWithValue("@stfid", s.StaffId);
                addCommand.Parameters.AddWithValue("@employeeno", s.EmployeeNo);
                addCommand.Parameters.AddWithValue("@salary", s.Salary);
                addCommand.Parameters.AddWithValue("@joinedDate", s.JoinedDate);
                addCommand.ExecuteNonQuery();
            }
            return "Staff added successfully";
        }

        public Staff GetStaffById(int staffId)
        {

            using (var dbconn = DatabaseManager.GetConnection())
            {
                string getStaffQuery = "SELECT * FROM Staffs WHERE StaffId = @staffId";
                SQLiteCommand getCommand = new SQLiteCommand(getStaffQuery, dbconn);
                getCommand.Parameters.AddWithValue("@staffId", staffId);
                SQLiteDataReader reader = getCommand.ExecuteReader();

                if (reader.Read())
                {
                    return new Staff
                    {
                        StaffId = reader.GetInt32(0),
                        EmployeeNo = reader.GetString(1),
                        Salary = reader.GetDecimal(2),
                        JoinedDate = reader["JoinedDate"].ToString()
                    };
                }
                else
                {
                    return null; // No staff found with the given ID
                }
            }

        }
    }
}

