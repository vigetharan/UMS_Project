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
        public void AddMarks(int examId, int studentId, int marks, int updatedBy)
        {
            // Logic to add marks for a student in an exam
            // This would typically involve creating a Result object and saving it to the database
        }

        public void UpdateMarks(int resultId, int marks, int updatedBy)
        {
            // Logic to update marks for a specific result
            // This would typically involve fetching the Result object and updating its properties
        }

        public void DeleteMarks(int resultId)
        {
            // Logic to delete marks for a specific result
            // This would typically involve removing the Result object from the database
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
