using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Repositories;
using UnicomTICManagementSystem.Models;
using System.Data.SQLite;
using System.Net.Sockets;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Controllers
{
    internal class StudentController
    {
        public string AddStudent(Student st)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string addStudentQuery = "INSERT INTO Students ( UTNumber,CourseId,JoinedDate,UserId) VALUES (@utnumber,@courseid,@joinedDate,@userid)";
                SQLiteCommand addCommand = new SQLiteCommand(addStudentQuery, dbconn);
                addCommand.Parameters.AddWithValue("@utnumber", st.UTNumber);
                addCommand.Parameters.AddWithValue("@courseid", st.CourseId);
                addCommand.Parameters.AddWithValue("@joinedDate", st.JoinedDate);
                addCommand.Parameters.AddWithValue("@userid", st.UserId);
                addCommand.ExecuteNonQuery();
            }
            return "STUDENT ADDED SUCCESSFULLY";


        }
        public String UpdateStudent(Student st)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string updateStudentQuery = "UPDATE Students SET Name = @name, Address = @address, Email = @email, NicNo = @nicno, ContactNo = @contactno, CourseId = @courseid WHERE UTNumber = @utnumber";
                SQLiteCommand updateCommand = new SQLiteCommand(updateStudentQuery, dbconn);
                updateCommand.Parameters.AddWithValue("@utnumber", st.UTNumber);
                updateCommand.Parameters.AddWithValue("@name", st.Name);
                updateCommand.Parameters.AddWithValue("@address", st.Address);
                updateCommand.Parameters.AddWithValue("@email", st.Email);
                updateCommand.Parameters.AddWithValue("@nicno", st.NicNo);
                updateCommand.Parameters.AddWithValue("@contactno", st.ContactNo);
                updateCommand.Parameters.AddWithValue("@courseid", st.CourseId);
                updateCommand.ExecuteNonQuery();
            }
            return "STUDENT UPDATED SUCCESSFULLY";
        }

        public string DeleteStudent(string studentId)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string deleteStudentQuery = "DELETE FROM Students WHERE Id = @sid";
                SQLiteCommand deleteCommand = new SQLiteCommand(deleteStudentQuery, dbconn);
                deleteCommand.Parameters.AddWithValue("@sid", studentId);
                deleteCommand.ExecuteNonQuery();
            }
            return "STUDENT DELETED SUCCESSFULLY";
        }
        public DataTable GetAllStudents()
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string query = @"
                        SELECT 
                            p.FirstName,
                            p.LastName,
                            p.DOB,
                            p.Address,
                            s.UtNumber,
                            s.JoinedDate,
                            c.CourseName
                        FROM 
                            Person p
                        INNER JOIN 
                            Student s ON p.Id = s.PersonId
                        LEFT JOIN
                            Courses c ON s.CourseId = c.Id


                using (SQLiteCommand cmd = new SQLiteCommand(query, dbconn))
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
       
    }
}
