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
            btn_add_person.Visible = false;
            btn_course.Visible = false;
            btn_addtimeslot.Visible = false;
            btn_addexam.Visible = false;
            btn_addcourse.Visible = false;
            if (LoggedInUser.Role == Enums.UserRole.ADMIN)
            {
                btn_add_person.Visible = true;
                btn_course.Visible = true;
                btn_addtimeslot.Visible = true;
                btn_addexam.Visible = true;
                btn_addcourse.Visible = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Person_Details pform = new Person_Details();
            pform.StartPosition = FormStartPosition.CenterScreen;
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
            TimeTableForm tt = new TimeTableForm();
            centerPanel.Controls.Clear();
            tt.TopLevel = false;
            tt.FormBorderStyle = FormBorderStyle.None;
            tt.Dock = DockStyle.Fill;
            centerPanel.Controls.Add(tt);
            tt.Show();
        }

        private void btn_exam_Click(object sender, EventArgs e)
        {
            Marks_Form marksForm = new Marks_Form();
            marksForm.Show();
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

        private void btn_addexam_Click(object sender, EventArgs e)
        {
            AddExam exam = new AddExam();
            exam.Show();
        }

        private void btn_addsubject_Click(object sender, EventArgs e)
        {

        }
    }
}
