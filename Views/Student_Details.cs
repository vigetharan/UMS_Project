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
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Views
{
    public partial class Student_Details : Form
    {
        public Student_Details()
        {
            InitializeComponent();
            LoadDataIntoGrid();
        }

        public void LoadDataIntoGrid()
        {
            string query = @"
        SELECT 
            s.*,
            c.CourseName
        FROM 
            Students s
        LEFT JOIN 
            Courses c ON s.CourseId = c.Id";

            using (var dbconn = DatabaseManager.GetConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, dbconn))
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    student_view.DataSource = dt;
                    student_view.Columns["CourseId"].Visible = false;
                    student_view.Columns["UserId"].Visible = false;
                    student_view.Columns["Id"].Visible = false;
                }
            }
        }

        private void student_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
