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

namespace UnicomTICManagementSystem
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            label_welcome.Text = $"Welcome, {LoggedInUser.Name}/n{LoggedInUser.Role}";
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            if (LoggedInUser.Role == Enums.UserRole.ADMIN)
            {
                btn_add_person.Visible = true;
                btn_course.Visible = true;
                btn_addtimeslot.Visible = true;
                btn_addsubject.Visible = true;
                btn_addexam.Visible = true;
                btn_schedule.Visible = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool studentButtonClicked = false;
        private bool lecturerButtonClicked = false;
        private bool staffButtonClicked = false;
        private bool adminButtonClicked = false;
        private bool courseButtonClicked = false;
        private bool timetableButtonClicked = false;
        private bool attendanceButtonClicked = false;
        private bool examButtonClicked = false;

        private void button1_Click(object sender, EventArgs e)
        {
 /*           // clear center viewing panel to empty, and other button clicks set to false
            btn_persondetails.FlatStyle = FlatStyle.Popup;
            centerPanel.Controls.Clear();
            studentButtonClicked = true;
            lecturerButtonClicked = false;
            staffButtonClicked = false;
            adminButtonClicked = false;
            timetableButtonClicked = false;
            courseButtonClicked = false;
            attendanceButtonClicked = false;
            examButtonClicked = false;
 */
            //Load lecturerForm into center panel
            Person_Details pform = new Person_Details();
            pform.TopLevel = false;
            pform.FormBorderStyle = FormBorderStyle.None;
            pform.StartPosition = FormStartPosition.CenterParent;
            centerPanel.AutoScroll = true;
            centerPanel.Controls.Add(pform);
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
            studentButtonClicked = false;
            lecturerButtonClicked = false;
            staffButtonClicked = false;
            adminButtonClicked = false;
            courseButtonClicked = true;
            timetableButtonClicked = false;
            attendanceButtonClicked = false;
            examButtonClicked = false;

            //Load Course and Subjects Form into center panel
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
            studentButtonClicked = false;
            lecturerButtonClicked = false;
            staffButtonClicked = false;
            adminButtonClicked = false;
            courseButtonClicked = false;
            timetableButtonClicked = false;
            attendanceButtonClicked = true;
            examButtonClicked = false;

            //Load AttendancesForm into center panel
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
            studentButtonClicked = false;
            lecturerButtonClicked = false;
            staffButtonClicked = false;
            adminButtonClicked = false;
            courseButtonClicked = false;
            timetableButtonClicked = true;
            attendanceButtonClicked = false;
            examButtonClicked = false;

            //Load TimeTable Form into center panel
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
            studentButtonClicked = false;
            lecturerButtonClicked = false;
            staffButtonClicked = false;
            adminButtonClicked = false;
            courseButtonClicked = false;
            timetableButtonClicked = false;
            attendanceButtonClicked = false;
            examButtonClicked = true;

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

        }
    }
}
