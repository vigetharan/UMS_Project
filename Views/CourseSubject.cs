using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;

namespace UnicomTICManagementSystem.Views
{
    public partial class CourseSubject : Form
    {
        public CourseSubject()
        {
            InitializeComponent();
            LoadDataIntoGrid();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            CourseController cController = new CourseController();
            string courseName = tb_course.Text;

            string getMessage = cController.AddCourse(courseName);

            MessageBox.Show(getMessage);
            tb_course.Clear();
            LoadDataIntoGrid();
        }

        private void CourseSubject_Load(object sender, EventArgs e)
        {

        }
        public void LoadDataIntoGrid()
        {
            CourseController Stc = new CourseController();
            DataTable dt = Stc.GetAllCourses();
            dtg_course.DataSource = dt;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            CourseController cController = new CourseController();
            if (dtg_course.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dtg_course.SelectedRows[0];

                // Get the ID from a specific column (assuming ID is in column 0)
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Or get by column name int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                string msg = cController.DeleteCourse(id);
                MessageBox.Show(msg);
                LoadDataIntoGrid();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
