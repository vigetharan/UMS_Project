using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Repositories;
using UnicomTICManagementSystem.Models;
using System.Data.SQLite;
using System.Net.Sockets;

namespace UnicomTICManagementSystem.Controllers
{
    internal class StudentController
    {
        public string AddStudent(Student st)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string addStudentQuery = "INSERT INTO Students ( UTNumber,Name,Address,Email,ContactNo,CourseId,UserId) VALUES (@utnumber,@name,@address@email,@Contactno,@courseid,@userid)";
                SQLiteCommand addCommand = new SQLiteCommand(addStudentQuery, dbconn);
                addCommand.Parameters.AddWithValue("@UTNumber", st.UTNumber);
                addCommand.Parameters.AddWithValue("@name", st.Name);
                addCommand.Parameters.AddWithValue("@address", st.Address);
                addCommand.Parameters.AddWithValue("@email", st.Email);
                addCommand.Parameters.AddWithValue("@contactno", st.ContactNo);
                addCommand.Parameters.AddWithValue("@courseid", st.CourseId);
                addCommand.Parameters.AddWithValue("@userid", st.UserId);
                addCommand.ExecuteNonQuery();
            }
            return "STUDENT ADDED SUCCESSFULLY";


        }
    }
}
