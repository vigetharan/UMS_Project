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
    internal class LecturerController
    {
        public string AddLecturer(Lecturer l)
        {
                using (var dbconn = DatabaseManager.GetConnection())
                {
                    string addStaffQuery = "INSERT INTO Lecturers ( LecturerId,EmployeeNo, Salary, JoinedDate, PrivilageLevel) VALUES (@lid, @empliyeeno,@salary, @joinedDate, @plevel)";
                    SQLiteCommand addCommand = new SQLiteCommand(addStaffQuery, dbconn);
                    addCommand.Parameters.AddWithValue("@lid", l.LecturerId);
                    addCommand.Parameters.AddWithValue("@empliyeeno", l.EmployeeNo);
                    addCommand.Parameters.AddWithValue("@salary", l.Salary);
                    addCommand.Parameters.AddWithValue("@joinedDate", l.JoinedDate);
                    addCommand.Parameters.AddWithValue("@plevel", l.PrivilageLevel);
                    addCommand.ExecuteNonQuery();
                }
                return "Lecturer added successfully";
        }
    }
}
