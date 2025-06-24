using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Repositories;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class ExamMarksController
    {
        public string AddMarks(Result r)
        {
            string grade;
            if(r.Marks>75)
            {
                grade = Enums.Grade.A.ToString();
            }
            else if (r.Marks > 60)
            {
                grade = Enums.Grade.B.ToString();
            }
            else if (r.Marks > 50)
            {
                grade = Enums.Grade.C.ToString();
            }
            else if (r.Marks > 40)
            {
                grade = Enums.Grade.D.ToString();
            }
            else
            {
                grade = Enums.Grade.F.ToString();
            }
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string addSubjectQuery = "INSERT INTO Marks (Marks, StudentId, ExamId, Grade_Obtained, UpdatedBy) VALUES (@marks, @sid, @eid, @grade, @updatedby)";
                SQLiteCommand addCommand = new SQLiteCommand(addSubjectQuery, dbconn);
                addCommand.Parameters.AddWithValue("marks", r.Marks);
                addCommand.Parameters.AddWithValue("sid", r.StudentId);
                addCommand.Parameters.AddWithValue("eid", r.ExamId);
                addCommand.Parameters.AddWithValue("grade", grade);
                addCommand.Parameters.AddWithValue("updatedby", r.UpdatedBy);
                addCommand.ExecuteNonQuery();  
            }return $"Marks of {r.StudentId} added successfully.";
        }

        public void UpdateMarks(int resultId, int marks, int updatedBy)
        {
            try
            {
                string grade;
                if (marks > 75)
                {
                    grade = Enums.Grade.A.ToString();
                }
                else if (marks > 60)
                {
                    grade = Enums.Grade.B.ToString();
                }
                else if (marks > 50)
                {
                    grade = Enums.Grade.C.ToString();
                }
                else if (marks > 40)
                {
                    grade = Enums.Grade.D.ToString();
                }
                else
                {
                    grade = Enums.Grade.F.ToString();
                }

                using (var dbconn = DatabaseManager.GetConnection())
                {
                    string updateQuery = "UPDATE Marks SET Marks = @marks, Grade_Obtained = @grade, UpdatedBy = @updatedBy WHERE Id = @resultId";
                    SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, dbconn);
                    updateCommand.Parameters.AddWithValue("@marks", marks);
                    updateCommand.Parameters.AddWithValue("@grade", grade);
                    updateCommand.Parameters.AddWithValue("@updatedBy", updatedBy);
                    updateCommand.Parameters.AddWithValue("@resultId", resultId);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Marks updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No record found to update.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating marks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteMarks(int resultId)
        {
            try
            {
                using (var dbconn = DatabaseManager.GetConnection())
                {
                    string deleteQuery = "DELETE FROM Marks WHERE Id = @resultId";
                    SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, dbconn);
                    deleteCommand.Parameters.AddWithValue("@resultId", resultId);

                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Marks deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No record found to delete.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting marks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable GetAllMarks()
        {

                string getquery = "SELECT p.Name AS StudentName, e.Name AS ExamName, m.Id, m.Marks, m.Grade_Obtained , m.StudentId " +
                               " FROM Marks m " +
                               "JOIN Exams e ON m.ExamId = e.Id " +
                               "JOIN Persons p ON m.StudentId = p.Id";

                using (var dbconn = DatabaseManager.GetConnection())
                {
                    
                    using (SQLiteCommand cmd = new SQLiteCommand(getquery, dbconn))
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            return dt;
                        }
                        else
                        {
                            MessageBox.Show("No users found, please contact admin...");
                            return null;
                        }
                    }
                }
            
        }

        public string AddExam(Exam exam)
        {
            try
            {
                using (var dbconn = DatabaseManager.GetConnection())
                {
                    string insertExamQuery = "INSERT INTO Exams (Name, SubjectId) VALUES (@Name, @SubjectId)";
                    SQLiteCommand insertCommand = new SQLiteCommand(insertExamQuery, dbconn);
                    insertCommand.Parameters.AddWithValue("@Name", exam.Name);
                    insertCommand.Parameters.AddWithValue("@SubjectId", exam.SubjectId);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    return rowsAffected > 0 ? "Exam added successfully." : "Failed to add exam.";
                }
            }
            catch (Exception ex)
            {
                return $"Error adding exam: {ex.Message}";
            }
        }
        public DataTable GetExams()
        {
            {
                try
                {
                    using (var dbconn = DatabaseManager.GetConnection())
                    {
                        string getAllExamQuery = "SELECT Id, Name FROM Exams";
                        SQLiteCommand getCommand = new SQLiteCommand(getAllExamQuery, dbconn);
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(getCommand);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DataRow dr = dt.NewRow();
                        dr["Id"] = -1;
                        dr["Name"] = "-- Select One --";
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
        }
    }
}
