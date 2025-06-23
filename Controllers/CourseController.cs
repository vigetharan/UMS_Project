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
        public string AddSubject(Subject sub)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string addSubjectQuery = "INSERT INTO Subjects (Name, CourseId,LecturerId) VALUES (@name, @cid, @lid)";
                SQLiteCommand addCommand = new SQLiteCommand(addSubjectQuery, dbconn);
                addCommand.Parameters.AddWithValue("name", sub.Name);
                addCommand.Parameters.AddWithValue("cid", sub.CourseId);
                addCommand.Parameters.AddWithValue("lid", sub.LecturerId);

                addCommand.ExecuteNonQuery();
            // Get the last inserted ID to use in CourseSubject table
/*
                string LastInsertIdQuery = "SELECT last_insert_rowid()";
                SQLiteCommand lastIdCommand = new SQLiteCommand(LastInsertIdQuery, dbconn);
                long subId = (long)lastIdCommand.ExecuteScalar();
                string addcoursesubjectQuery = "Insert INTO CourseSubject ( CourseId, SubjectId) VALUES (@cid, @subid)";
                SQLiteCommand addCommand1 = new SQLiteCommand(addcoursesubjectQuery, dbconn);
                addCommand1.Parameters.AddWithValue("cid", sub.CourseId);
                addCommand1.Parameters.AddWithValue("subid", subId);
                   addCommand1.ExecuteNonQuery();
                */
                return $"NEW SUBJECT ADDED SUCCESSFULLY";
            }
        }

        public DataTable GetCourseSubjectsToGrid()
        {
                                string getQuery = @"
                                               SELECT 
                                                    c.CourseName,
                                                    COALESCE(p.Name, 'No Lecturer Assigned') AS LecturerName,
                                                    s.Name AS SubjectName, 
                                                    s.Id AS SubjectId,
                                                    c.Id AS CourseId
                                                FROM Courses c
                                                LEFT JOIN Subjects s ON s.CourseId = c.Id
                                                LEFT JOIN Lecturers l ON s.LecturerId = l.PersonId
                                                LEFT JOIN Persons p ON l.PersonId = p.Id
                                                ORDER BY c.CourseName, s.Name";
            try
            {
                using (var dbconn = DatabaseManager.GetConnection())
                {
                    SQLiteCommand getCommand = new SQLiteCommand(getQuery, dbconn);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(getCommand);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        public DataTable GetAllCoursesTOCombo()
        {
            try
            {
                using (var dbconn = DatabaseManager.GetConnection())
                {
                    string getAllCoursesQuery ="SELECT Id, CourseName FROM Courses ORDER BY CourseName";
                    SQLiteCommand getCommand = new SQLiteCommand(getAllCoursesQuery, dbconn);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(getCommand);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataRow dr = dt.NewRow();
                    dr["Id"] = -1;
                    dr["CourseName"] = "-- Select One --";
                    dt.Rows.InsertAt(dr, 0);
                    return dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
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
            return "COURSE DELETED SUCCESSFULLY";
        }

    }
}
