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
    internal class CourseController
    {
            public string AddCourse(string coursename)
            {
                using (var dbconn = DatabaseManager.GetConnection())
                {
                    string addCourseQuery = "INSERT INTO Courses ( CourseName) VALUES (@coursename)";
                    SQLiteCommand addCommand = new SQLiteCommand(addCourseQuery, dbconn);
                    addCommand.Parameters.AddWithValue("@UTNumber", coursename);
                    
                    addCommand.ExecuteNonQuery();
                }
                return $"NEW COURSE {coursename} ADDED SUCCESSFULLY";


            }
}
