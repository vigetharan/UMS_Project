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
                string addStudentQuery = "INSERT INTO Students ( Name,Address) VALUES (@name,@address)";
                SQLiteCommand addCommand = new SQLiteCommand(addStudentQuery, dbconn);
                addCommand.Parameters.AddWithValue("@name", st.Name);
                addCommand.Parameters.AddWithValue("@address", st.Address);
                addCommand.Parameters.AddWithValue("@address", st.Address);
                addCommand.Parameters.AddWithValue("@address", st.Address);
                addCommand.ExecuteNonQuery();
            }
            return "STUDENT ADDED SUCCESSFULLY";


        }
    }
}
