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
                string addStaffQuery = "INSERT INTO Staffs ( StaffId, EmployeeNo, Salary, JoinedDate, PrivilageLevel) VALUES (@stfid, @employeeno, @salary, @joinedDate, @plevel)";
                SQLiteCommand addCommand = new SQLiteCommand(addStaffQuery, dbconn);
                addCommand.Parameters.AddWithValue("@stfid", s.StaffId);
                addCommand.Parameters.AddWithValue("@employeeno", s.EmployeeNo);
                addCommand.Parameters.AddWithValue("@salary", s.Salary);
                addCommand.Parameters.AddWithValue("@joinedDate", s.JoinedDate);
                addCommand.Parameters.AddWithValue("@plevel", s.PrivilageLevel);
                addCommand.ExecuteNonQuery();
            }
            return "Staff added successfully";
        }
    }
}

