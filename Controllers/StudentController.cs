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
                string addStudentQuery = "INSERT INTO Students ( PersonId,UTNumber,CourseId,JoinedDate,ParentContact) VALUES (@studentid,@utnumber,@courseid,@joinedDate,@parentcontact)";
                SQLiteCommand addCommand = new SQLiteCommand(addStudentQuery, dbconn);
                addCommand.Parameters.AddWithValue("@studentid", st.PersonId);
                addCommand.Parameters.AddWithValue("@utnumber", st.UTNumber);
                addCommand.Parameters.AddWithValue("@courseid", st.CourseId);
                addCommand.Parameters.AddWithValue("@joinedDate", st.JoinedDate);
                addCommand.Parameters.AddWithValue("@parentcontact", st.ParentContact);
                addCommand.ExecuteNonQuery();
            }
            return "STUDENT ADDED SUCCESSFULLY";


        }
        public String UpdateStudent(Student st)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string updateStudentQuery = "UPDATE Students SET (UTNumber,CourseId,JoinedDate,ParentContact) VALUES (@utnumber,@courseid,@joinedDate,@parentcontact)";
                SQLiteCommand addCommand = new SQLiteCommand(updateStudentQuery, dbconn);
                addCommand.Parameters.AddWithValue("@utnumber", st.UTNumber);
                addCommand.Parameters.AddWithValue("@courseid", st.CourseId);
                addCommand.Parameters.AddWithValue("@joinedDate", st.JoinedDate);
                addCommand.Parameters.AddWithValue("@parentcontact", st.ParentContact);
                addCommand.ExecuteNonQuery();
            }
            return "STUDENT UPDATED SUCCESSFULLY";
        }

        public string DeleteStudent(int PersonId)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string deleteStudentQuery = "DELETE FROM Students WHERE Id = @sid";
                SQLiteCommand deleteCommand = new SQLiteCommand(deleteStudentQuery, dbconn);
                deleteCommand.Parameters.AddWithValue("@sid", PersonId);
                deleteCommand.ExecuteNonQuery();
            }
            return "STUDENT DELETED SUCCESSFULLY";
        }

            public Student GetStudentByPersonId(int personId)
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    string query = "SELECT * FROM Students WHERE PersonId = @PersonId";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PersonId", personId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Student
                                {
                                    PersonId = Convert.ToInt32(reader["PersonId"]),
                                    UTNumber = reader["UTNumber"].ToString(),
                                    CourseId = Convert.ToInt32(reader["CourseId"]),
                                    JoinedDate = reader["JoinedDate"].ToString(),
                                    ParentContact = reader["ParentContact"].ToString()
                                };
                            }
                        }
                    }
                }
                return null; // If no student found for that PersonId
            }
    }
}
