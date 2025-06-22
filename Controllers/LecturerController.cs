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
                    string addStaffQuery = "INSERT INTO Lecturers ( PersonId,EmployeeNo, Salary, JoinedDate) VALUES (@lid, @empliyeeno,@salary, @joinedDate)";
                    SQLiteCommand addCommand = new SQLiteCommand(addStaffQuery, dbconn);
                    addCommand.Parameters.AddWithValue("@lid", l.PersonId);
                    addCommand.Parameters.AddWithValue("@empliyeeno", l.EmployeeNo);
                    addCommand.Parameters.AddWithValue("@salary", l.Salary);
                    addCommand.Parameters.AddWithValue("@joinedDate", l.JoinedDate);
                    addCommand.ExecuteNonQuery();
                }
                return "Lecturer added successfully";
        }

        public Lecturer GetLecturerById(int personId)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string getLecturerQuery = "SELECT * FROM Lecturers WHERE PersonId = @personId";
                SQLiteCommand getCommand = new SQLiteCommand(getLecturerQuery, dbconn);
                getCommand.Parameters.AddWithValue("@personId", personId);
                SQLiteDataReader reader = getCommand.ExecuteReader();

                if (reader.Read())
                {
                    return new Lecturer
                    {
                        PersonId = reader.GetInt32(0),
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
        public string UpdateLecturer(Lecturer l)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string updateLecturerQuery = "UPDATE Lecturers SET (EmployeeNo, Salary, JoinedDate) VALUES (@employeeno, @salary, @joinedDate)";
                SQLiteCommand addCommand = new SQLiteCommand(updateLecturerQuery, dbconn);
                addCommand.Parameters.AddWithValue("@employeeno", l.EmployeeNo);
                addCommand.Parameters.AddWithValue("@salary", l.Salary);
                addCommand.Parameters.AddWithValue("@joinedDate", l.JoinedDate);
                addCommand.ExecuteNonQuery();
            }
            return "Lecturer updated successfully";
        }
    }
}
