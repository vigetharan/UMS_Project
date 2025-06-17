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
                string addStudentQuery = "INSERT INTO Students ( StudentId,UTNumber,CourseId,JoinedDate,Group_Assigned,ParentContact) VALUES (@studentid,@utnumber,@courseid,@joinedDate,@group,@parentcontact)";
                SQLiteCommand addCommand = new SQLiteCommand(addStudentQuery, dbconn);
                addCommand.Parameters.AddWithValue("@studentid", st.StudentId);
                addCommand.Parameters.AddWithValue("@utnumber", st.UTNumber);
                addCommand.Parameters.AddWithValue("@courseid", st.CourseId);
                addCommand.Parameters.AddWithValue("@joinedDate", st.JoinedDate);
                addCommand.Parameters.AddWithValue("@group", st.Group_Assigned);
                addCommand.Parameters.AddWithValue("@parentcontact", st.ParentContact);
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
                            p.Name,
                            p.NicNo,
                            p.Address,
                            p.Email,
                            p.ContactNo,
                            CASE p.Gender  WHEN 1 THEN 'MALE'  WHEN 2 THEN 'FEMALE'   END AS Gender,
                            p.DateOfBirth,
                            CAST(strftime('%Y', 'now') AS INTEGER) - CAST(strftime('%Y', p.DateOfBirth) AS INTEGER)
                            - CASE 
                                WHEN strftime('%m-%d', 'now') < strftime('%m-%d', p.DateOfBirth) 
                                THEN 1 
                                ELSE 0 
                              END AS Age,
                            CASE p.UserRole WHEN 0 THEN 'ADMIN' WHEN 1 THEN 'STUDENT' WHEN 2 THEN 'STAFF' WHEN 3 THEN 'LECTURER' END AS UserRole,
                            s.UtNumber,
                            CASE s.Group_Assigned WHEN 0 THEN 'GROUP-A' WHEN 1 THEN 'GROUP-B' END AS Group_Assigned,
                            s.JoinedDate,
                            s.ParentContact,
                            c.CourseName
                        FROM 
                            Persons p
                        INNER JOIN 
                            Students s ON p.Id = s.StudentId
                        LEFT JOIN
                            Courses c ON s.CourseId = c.Id";


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
