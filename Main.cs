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
using UnicomTICManagementSystem.Models;
using static UnicomTICManagementSystem.Models.Enums;

namespace UnicomTICManagementSystem
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            string title = LoggedInUser.Gender == Gender.MALE ? "Mr." : "Ms.";
            label_welcome.Text = $"Welcome, {title}{LoggedInUser.Name}\nROLE As : {LoggedInUser.Role}";
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            btn_add_person.Visible = true;
            btn_course.Visible = false;
            btn_addtimeslot.Visible = false;
            btn_addsubject.Visible = false;
            btn_addexam.Visible = false;
            btn_addcourse.Visible = false;
            if (LoggedInUser.Role == Enums.UserRole.ADMIN)
            {
                btn_add_person.Visible = true;
                btn_course.Visible = true;
                btn_addtimeslot.Visible = true;
                btn_addsubject.Visible = true;
                btn_addexam.Visible = true;
                btn_addcourse.Visible = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
 //           centerPanel.AutoScroll = true;
            Person_Details pform = new Person_Details();
 //           pform.TopLevel = false;
 //           pform.FormBorderStyle = FormBorderStyle.None;
            pform.StartPosition = FormStartPosition.CenterScreen;
 //           pform.Dock = DockStyle.Fill;
 //           pform.AutoScaleMode = AutoScaleMode.None;
//            centerPanel.Controls.Add(pform);
            pform.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_person_Click(object sender, EventArgs e)
        {
            AddPersonForm popup = new AddPersonForm();
            popup.StartPosition = FormStartPosition.CenterScreen; // or CenterParent
            popup.Show();
        }


        private void btn_admin_Click(object sender, EventArgs e)
        {

        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
        }


        private void btn_course_Click(object sender, EventArgs e)
        {
            // clear center viewing panel to empty, and other button clicks set to false

            centerPanel.Controls.Clear();
            CourseSubject csd = new CourseSubject();
            centerPanel.Controls.Clear();
            csd.TopLevel = false;
            csd.FormBorderStyle = FormBorderStyle.None;
            csd.Dock = DockStyle.Fill;
            centerPanel.Controls.Add(csd);
            csd.Show();


        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            // clear center viewing panel to empty, and other button clicks set to false

            centerPanel.Controls.Clear();
            AttendanceDetails atn = new AttendanceDetails();
            centerPanel.Controls.Clear();
            atn.TopLevel = false;
            atn.FormBorderStyle = FormBorderStyle.None;
            atn.Dock = DockStyle.Fill;
            centerPanel.Controls.Add(atn);
            atn.Show();
        }

        private void btn_timetable_Click(object sender, EventArgs e)
        {
            // clear center viewing panel to empty, and other button clicks set to false

            centerPanel.Controls.Clear();
            TimeTableDetails tt = new TimeTableDetails();
            centerPanel.Controls.Clear();
            tt.TopLevel = false;
            tt.FormBorderStyle = FormBorderStyle.None;
            tt.Dock = DockStyle.Fill;
            centerPanel.Controls.Add(tt);
            tt.Show();
        }

        private void btn_exam_Click(object sender, EventArgs e)
        {
            // clear center viewing panel to empty, and other button clicks set to false

            centerPanel.Controls.Clear();
            
            //Load Exam and Marks Form into center panel
            MarksDetails marks = new MarksDetails();
            centerPanel.Controls.Clear();
            marks.TopLevel = false;
            marks.FormBorderStyle = FormBorderStyle.None;
            marks.Dock = DockStyle.Fill;
            centerPanel.Controls.Add(marks);
            marks.Show();
        }

        private void btn_addcourse_Click(object sender, EventArgs e)
        {
            CourseSubject popup = new CourseSubject();
            popup.Text = "Add New Course";
            popup.StartPosition = FormStartPosition.CenterParent; // or CenterParent
            popup.Show();
        }

        private void linkLabel_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login_Form l = new login_Form();
            LoggedInUser.Name = "";
            LoggedInUser.PersonId = -1;
            LoggedInUser.UserId = -1;
            LoggedInUser.Role =Enums.UserRole.NONE;
            l.Show();
            this.Hide();

        }

        private void btn_addtimeslot_Click(object sender, EventArgs e)
        {
            TimeTableForm tt = new TimeTableForm();
            tt.Show();
        }
    }
}
