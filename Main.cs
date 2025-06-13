using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Views;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool studentButtonClicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            studentButtonClicked = true;
            Student_Details sdform = new Student_Details();
            sdform.TopLevel = false;
            sdform.FormBorderStyle = FormBorderStyle.None;
            sdform.Dock = DockStyle.Fill;
            centerPanel.Controls.Add(sdform);
            sdform.Show();


 /*           Student_Form studentForm = new Student_Form();
            studentForm.TopLevel = false;
            studentForm.FormBorderStyle = FormBorderStyle.None;
            studentForm.Dock = DockStyle.Fill;
            centerPanel.Controls.Add(studentForm);
            studentForm.Show();
 */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentButtonClicked = false;
            CourseSubject courseSubject = new CourseSubject();
            courseSubject.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (studentButtonClicked)
            {
                Student_Form popup = new Student_Form();
                popup.StartPosition = FormStartPosition.CenterScreen; // or CenterParent
                popup.Show();
                /*               Student_Form studentForm = new Student_Form();
                               studentForm.TopLevel = false;
                               studentForm.FormBorderStyle = FormBorderStyle.None;
                               studentForm.Dock = DockStyle.Fill;
               //                centerPanel.Controls.Add(studentForm);
                               studentForm.ShowDialog();
                */
            }
        }
    }
}
