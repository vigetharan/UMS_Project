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
        private bool lecturerButtonClicked = false;
        private bool staffButtonClicked = false;
        private bool adminButtonClicked = false;
        private bool courseButtonClicked = false;
        private bool timetableButtonClicked = false;
        private bool attendanceButtonClicked = false;
        private bool examButtonClicked = false;

        private void button1_Click(object sender, EventArgs e)
        {
            // clear center viewing panel to empty, and other button clicks set to false
            btn_student.FlatStyle = FlatStyle.Popup;
            centerPanel.Controls.Clear();
            studentButtonClicked = true;
            lecturerButtonClicked = false;
            staffButtonClicked = false;
            adminButtonClicked = false;
            timetableButtonClicked = false;
            courseButtonClicked = false;
            attendanceButtonClicked = false;
            examButtonClicked = false;

            //Load lecturerForm into center panel
            Student_Details sdform = new Student_Details();
            sdform.TopLevel = false;
            sdform.FormBorderStyle = FormBorderStyle.None;
            sdform.Dock = DockStyle.Fill;
            centerPanel.Controls.Add(sdform);
            sdform.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // clear center viewing panel to empty, and other button clicks set to false

            centerPanel.Controls.Clear();
            studentButtonClicked = false;
            lecturerButtonClicked = true;
            staffButtonClicked = false;
            adminButtonClicked = false;
            timetableButtonClicked = false;
            courseButtonClicked = false;
            attendanceButtonClicked = false;
            examButtonClicked = false;

            //Load lecturerForm into center panel
            LecturerDetails lecForm = new LecturerDetails();
            lecForm.TopLevel = false;
            lecForm.FormBorderStyle = FormBorderStyle.None;
            lecForm.Dock = DockStyle.Fill;
            centerPanel.Controls.Add(lecForm);
            lecForm.Show();
        }

        private void btn_add_person_Click(object sender, EventArgs e)
        {
            AddPersonForm popup = new AddPersonForm();
            popup.StartPosition = FormStartPosition.CenterScreen; // or CenterParent
            popup.Show();




            /*           if (studentButtonClicked)
                       {
                           Student_Form popup = new Student_Form();
                           popup.StartPosition = FormStartPosition.CenterScreen; // or CenterParent
                           popup.Show();
                       }
                       else if (lecturerButtonClicked)
                       {
                           Lecturer_Form popup = new Lecturer_Form();
                           popup.StartPosition = FormStartPosition.CenterScreen; // or CenterParent
                           popup.Show();
                       }
                       else if (staffButtonClicked)
                       {
                           Staff_Form popup = new Staff_Form();
                           popup.StartPosition = FormStartPosition.CenterScreen; // or CenterParent
                           popup.Show();
                       }
                       else if (adminButtonClicked)
                       {
                           Admin popup = new Admin();
                           popup.StartPosition = FormStartPosition.CenterScreen; // or CenterParent
                           popup.Show();
                       }
                       else if (timetableButtonClicked)
                       {
                           TimeTable popup = new TimeTable();
                           popup.StartPosition = FormStartPosition.CenterScreen; // or CenterParent
                           popup.Show();
                       }
                       else if (examButtonClicked)
                       {
                           Marks_Form popup = new Marks_Form();
                           popup.StartPosition = FormStartPosition.CenterScreen; // or CenterParent
                           popup.Show();
                       }
                       else if (attendanceButtonClicked)
                       {
                           Attendance popup = new Attendance();
                           popup.StartPosition = FormStartPosition.CenterScreen; // or CenterParent
                           popup.Show();
                       }
                       else if (courseButtonClicked)
                       {
                           CourseSubject popup = new CourseSubject();
                           popup.StartPosition = FormStartPosition.CenterScreen; // or CenterParent
                           popup.Show();
                       }
                       else
                       {
                           MessageBox.Show("❌\nPlease Select one for add a new entry !");
                       }
           */
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            // clear center viewing panel to empty, and other button clicks set to false

            centerPanel.Controls.Clear();
            studentButtonClicked = false;
            lecturerButtonClicked = false;
            staffButtonClicked = false;
            adminButtonClicked = true;
            timetableButtonClicked = false;
            courseButtonClicked = false;
            attendanceButtonClicked = false;
            examButtonClicked = false;

            //Load Admin Form into center panel
            AdminDetails adminForm = new AdminDetails();
            adminForm.TopLevel = false;
            adminForm.FormBorderStyle = FormBorderStyle.None;
            adminForm.Dock = DockStyle.Fill;
            centerPanel.Controls.Add(adminForm);
            adminForm.Show();

        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            // clear center viewing panel to empty, and other button clicks set to false

            centerPanel.Controls.Clear();
            studentButtonClicked = false;
            lecturerButtonClicked = false;
            staffButtonClicked = true;
            adminButtonClicked = false;
            timetableButtonClicked = false;
            courseButtonClicked = false;
            attendanceButtonClicked = false;
            examButtonClicked = false;

            //Load Staff Form into center panel
            StaffDetails staffForm = new StaffDetails();
            staffForm.TopLevel = false;
            staffForm.FormBorderStyle = FormBorderStyle.None;
            staffForm.Dock = DockStyle.Fill;
            centerPanel.Controls.Add(staffForm);
            staffForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
            CourseSubjectDetails csd = new CourseSubjectDetails();
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
    }
}
