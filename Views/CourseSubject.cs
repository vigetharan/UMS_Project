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
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class CourseSubject : Form
    {
        public CourseSubject()
        {
            InitializeComponent();
            LoadDataIntoGrid();
            LoadComboBoxData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_course.Text.Length < 3)
            {
                MessageBox.Show("Subject name must be at least 3 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_course.Clear();
                return;
            }
            CourseController cController = new CourseController();
            string courseName = tb_course.Text;

            string getMessage = cController.AddCourse(courseName);

            MessageBox.Show(getMessage);
            tb_course.Clear();
            LoadDataIntoGrid();
            LoadComboBoxData();
        }
        private void LoadComboBoxData()
        {
            CourseController cc = new CourseController();
            DataTable dt = cc.GetAllCoursesTOCombo();
            cb_course.DataSource = dt;
            cb_course.DisplayMember = "CourseName";
            cb_course.ValueMember = "Id";

            cb_course.SelectedIndex = 0;

            LecturerController lc = new LecturerController();
            DataTable dt2 = lc.GetLecturerTOCombo();
            cb_lecturer.DataSource = dt2;
            cb_lecturer.DisplayMember = "Name";
            cb_lecturer.ValueMember = "Id";

            cb_lecturer.SelectedIndex = 0;
        }

        private void CourseSubject_Load(object sender, EventArgs e)
        {

        }
        public void LoadDataIntoGrid()
        {
            CourseController cc = new CourseController();
            DataTable dt = cc.GetCourseSubjectsToGrid();
            dtg_course.DataSource = dt;
            dtg_course.Columns["CourseId"].Visible = false;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            CourseController cController = new CourseController();
            if (dtg_course.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dtg_course.SelectedRows[0];

                // Get the ID from a specific column (assuming ID is in column 0)
                int id = Convert.ToInt32(selectedRow.Cells[4].Value);

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

        private void btn_add_subject_Click(object sender, EventArgs e)
        {
            if(tb_subject.Text.Length<3)
            {
                MessageBox.Show("Subject name must be at least 3 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_subject.Clear();
                return;
            }
            if (cb_course.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cb_lecturer.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a lecturer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Subject sub = new Subject
            {
                Name = tb_subject.Text.Trim(),
                CourseId = Convert.ToInt32(cb_course.SelectedValue),
                LecturerId = Convert.ToInt32(cb_lecturer.SelectedValue)
            };
            CourseController courseController = new CourseController();
            MessageBox.Show(courseController.AddSubject(sub, Convert.ToInt32(cb_lecturer.SelectedValue)));
            tb_subject.Clear();
            LoadDataIntoGrid();
            cb_lecturer.SelectedIndex = 0;
        }

    }
}
