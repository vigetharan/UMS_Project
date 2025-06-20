using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;
using System.Data;

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
                addCommand.Parameters.AddWithValue("coursename", coursename);

                addCommand.ExecuteNonQuery();
            }
            return $"NEW COURSE {coursename} ADDED SUCCESSFULLY";


        }
        public DataTable GetAllCourses()
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string getAllCoursesQuery = "SELECT * FROM Courses";
                SQLiteCommand getCommand = new SQLiteCommand(getAllCoursesQuery, dbconn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(getCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;

            }
        }
        public string DeleteCourse(int id)
        {

           using (var dbconn = DatabaseManager.GetConnection())
            {
                string deleteCourseQuery = "DELETE FROM Courses WHERE Id = @cid";
                SQLiteCommand deleteCommand = new SQLiteCommand(deleteCourseQuery, dbconn);
                deleteCommand.Parameters.AddWithValue("@cid", id); // Example ID, replace with actual logic
                deleteCommand.ExecuteNonQuery();
            }
            return "COURSE DELETED SUCCESSFULLY";}
    }
}
