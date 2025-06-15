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
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            CourseController cController = new CourseController();
            string courseName = tb_course.Text;

            string getMessage = cController.AddCourse(courseName);

            MessageBox.Show(getMessage);
            tb_course.Clear();
        }
    }
}
