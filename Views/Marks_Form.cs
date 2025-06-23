using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Views
{
    public partial class Marks_Form : Form
    {
        public Marks_Form()
        {
            InitializeComponent();
        }

        private void Marks_Form_Load(object sender, EventArgs e)
        {
            CourseController cc = new CourseController();
            DataTable dtt = cc.GetAllCoursesTOCombo();
            cb_course.DataSource = dtt;
            cb_course.DisplayMember = "CourseName";
            cb_course.ValueMember = "Id";

            cb_course.SelectedIndex = 0;

            ExamMarksController emc = new ExamMarksController();
            DataTable dt = emc.GetExams();
            cb_exam.DataSource = dt;
            cb_exam.DisplayMember = "Name";
            cb_exam.ValueMember = "Id";
            cb_exam.SelectedIndex = 0;
        

        }
        private void LoadStudentsForSelectedCourse()
            {
                try
                {
                    using (var dbconn = DatabaseManager.GetConnection())
                    {

                        // Ensure a valid course is selected
                        if (cb_course.SelectedValue == null || cb_course.SelectedValue is DBNull)
                        {
                            MessageBox.Show("No valid course selected. Please select a course.");
                            return;
                        }

                        // Retrieve the selected CourseId
                        int courseId;
                        if (!int.TryParse(cb_course.SelectedValue.ToString(), out courseId) || courseId <= 0)
                        {
                            MessageBox.Show("Please select a valid course.");
                            return;
                        }

                        // Query to fetch students for the selected course
                        string query = @"
                                    SELECT 
                                        s.PersonId AS Id,
                                        s.UTNumber AS UTNumber
                                    FROM 
                                        Students s
                                    WHERE 
                                        s.CourseId = @courseId";

                        using (var cmd = new SQLiteCommand(query, dbconn))
                        {
                            cmd.Parameters.AddWithValue("@courseId", courseId);

                            using (var adapter = new SQLiteDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);

                                // Add a default "Select One" row
                                DataRow dr = dt.NewRow();
                                dr["Id"] = -1; // Default value
                                dr["UTNumber"] = "-- Select One --";
                                dt.Rows.InsertAt(dr, 0);

                                // Bind the result to the ComboBox
                                cb_student.DataSource = dt;
                                cb_student.DisplayMember = "UTNUmber"; // Column to display
                                cb_student.ValueMember = "Id";    // Column for value
                                cb_student.SelectedIndex = 0;    // Default selection
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }

        private void cb_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudentsForSelectedCourse();
        }

        private void cb_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_name.Visible = false;
            using (var dbconn = DatabaseManager.GetConnection())
            { 
                string utno = cb_student.Text.ToString();
                string getnamequery = "SELECT p.Name FROM Persons p JOIN Students s ON p.Id = s.PersonId WHERE s.UTNumber = @utno;";
                using (var command = new SQLiteCommand(getnamequery, dbconn))
                {   command.Parameters.AddWithValue("@utno", utno);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string name = result.ToString();
                        label_name.Text = name;
                        label_name.Visible = true;
                    }
                }
            }
        }
    }
}
