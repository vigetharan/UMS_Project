using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static UnicomTICManagementSystem.Models.Enums;

namespace UnicomTICManagementSystem.Views
{
    public partial class AddPersonForm : Form
    {
        public object DateOnly { get; private set; }
        public Enums.PrivilageLevel accessLevel;

        public AddPersonForm()
        {
            InitializeComponent();
            LoadComboBoxData();
            tb_parent.Text = "Enter Parent's / Guardian's Contact Number";
            tb_parent.ForeColor = Color.LightGray;
        }

        private void combo_course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Student_Form_Load(object sender, EventArgs e)
        {
                // Create a list with a default placeholder
                var genderList = new List<string> { "--Select--" };

                // Add enum values to the list
                genderList.AddRange(Enum.GetValues(typeof(Gender)).Cast<Gender>().Select(g => g.ToString()));

                // Bind the list to the ComboBox
                cb_gender.DataSource = genderList;
                var groupList = new List<string> { "--Select--" };
                groupList.AddRange(Enum.GetValues(typeof(Group)).Cast<Group>().Select(g => g.ToString()));
                cb_group.DataSource = groupList;


                var rolelist = new List<string> { "--select--" };
                rolelist.AddRange(Enum.GetValues(typeof(UserRole)).Cast<UserRole>().Select(g => g.ToString()));
                cb_role.DataSource = rolelist;
        }
        private void Clear_Form()
        {
            tb_address.Clear();
            tb_name.Clear();

        }

        private void LoadComboBoxData()
        {
 //           string query = "SELECT Id, CourseName FROM Courses";

            try
            {
                using (var dbconn = DatabaseManager.GetConnection())
                {
                    string query = "SELECT Id, CourseName FROM Courses";
                    using (var cmd = new SQLiteCommand(query, dbconn))
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DataRow dr = dt.NewRow();
                        dr["Id"] = -1;              // or -1 or some invalid ID
                        dr["CourseName"] = "-- Select One --";
                        dt.Rows.InsertAt(dr, 0);


                        cb_course.DataSource = dt;
                        cb_course.DisplayMember = "CourseName";
                        cb_course.ValueMember = "Id";

                        cb_course.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //comment
        private void btn_add_Click(object sender, EventArgs e)
        {

            try
            {
                User user = new User
                {
                    Username = cb_authentication.Checked ? null : tb_username.Text,
                    Password = cb_authentication.Checked ? null : tb_password.Text,
                    Role = Enums.UserRole.STUDENT,
                    Status = Enums.UserStatus.ACTIVE,
                    AccessLevel = accessLevel
                };
                UsersController uController = new UsersController();
                int userid = uController.AddUser(user);

                Person p = new Person
                {
                    NicNo = tb_nic.Text,
                    Name = tb_name.Text,
                    Address = tb_address.Text,
                    Email = tb_email.Text,
                    ContactNo = tb_contactno.Text,
                    Gender = (Gender)cb_gender.SelectedIndex,
                    DateOfBirth = DateTime.Parse(tb_dob.Text),
                    UserId = userid
                };

                PersonController pController = new PersonController();
                int personId = pController.AddPerson(p);

                MessageBox.Show(personId.ToString());
                if (cb_role.SelectedItem.ToString() == "STUDENT")
                {
                    Student st = new Student
                    {
                        StudentId = personId,
                        UTNumber = tb_utno.Text,
                        Group_Assigned = (Group)cb_group.SelectedIndex,
                        CourseId = Convert.ToInt32(cb_course.SelectedValue),
                        JoinedDate = dtp_datejoined.Value.ToString("yyyyMMdd"),
                        ParentContact = tb_parent.Text,
                        PrivilageLevel =accessLevel
                    };
                    StudentController sController = new StudentController();
                    string message = sController.AddStudent(st);
                    MessageBox.Show(message);
                }

                else if (cb_role.SelectedItem.ToString() == "LECTURER")
                {
                    Lecturer l = new Lecturer
                    {
                        LecturerId = personId,
                        EmployeeNo = tb_utno.Text,
                        Salary = Convert.ToDecimal(tb_salary.Text),
                        JoinedDate = dtp_datejoined.Value.ToString("yyyyMMdd"),
                        PrivilageLevel = accessLevel
                    };
                    LecturerController lController = new LecturerController();
                    string message = lController.AddLecturer(l);
                    MessageBox.Show(message);
                }
                else if (cb_role.SelectedItem.ToString() == "STAFF")
                {
                    Staff s = new Staff
                    {
                        StaffId = personId,
                        EmployeeNo = tb_utno.Text, // Assuming tb_utno is used for employee ID
                        Salary = Convert.ToDecimal(tb_salary.Text),
                        JoinedDate = dtp_datejoined.Value.ToString("yyyy-MM-dd"),
                        PrivilageLevel =  accessLevel
                    };
                    StaffController sController = new StaffController();
                    string message = sController.AddStaff(s);
                    MessageBox.Show(message);
                }
                else if (cb_role.SelectedItem.ToString() == "ADMIN")
                {
                    Admin a = new Admin
                    {
                        AdminId = personId,
                        EmployeeNo = tb_utno.Text,
                        Salary = Convert.ToDecimal(tb_salary.Text),
                        UserId = userid,
                        JoinedDate = dtp_datejoined.Value.ToString("yyyy-MM-dd"),
                        PrivilageLevel = accessLevel
                    };
                    AdminController aController = new AdminController();
                    string message = aController.AddAdmin(a);
                    MessageBox.Show(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Clear_Form();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void error_utno_Click(object sender, EventArgs e)
        {

        }
        private void cb_authentication_CheckedChanged(object sender, EventArgs e)
        {
            bool ischecked = cb_authentication.Checked;
            tb_username.Visible = !ischecked;
            tb_password.Visible = !ischecked;
            label_username.Visible = !ischecked;
            label_password.Visible = !ischecked;
            
            if (!ischecked)
            {
                tb_username.Clear();
                tb_password.Clear();
            }
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_group_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_nic_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_nic_Leave(object sender, EventArgs e)
        {
            PersonController pc = new PersonController();
            if (!pc.CheckNic(tb_nic.Text))
            {
                error_nic.Visible = true;
                error_nic.Text = "Invalid NIC ! Please enter a valid one as Format of (123456789V)";
            }
            else
            {
                error_nic.Visible = false;
                try
                {
                    DateTime dob = pc.GetDob(tb_nic.Text);
                    tb_dob.Text = dob.ToString("yyyy-MM-dd");
                    Enums.Gender gender = PersonController.CheckGender(tb_nic.Text);
                    cb_gender.SelectedItem = gender.ToString();
                }
                catch (ArgumentException ex)
                {
                    error_nic.Visible = true;
                    error_nic.Text = ex.Message;
                }
            }
        }

        private void cb_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_utno.Visible = false;
            tb_parent.Visible = false;
            cb_group.Visible = false;
            cb_course.Visible = false;
            label_utno.Visible = false;
            label_group.Visible = false;
            label_course.Visible = false;
            lable_parent.Visible = false;
            label_salary.Visible = false;
            tb_salary.Visible = false;
            
            string selectedRole = cb_role.SelectedItem.ToString();
            switch (selectedRole)
            {
                case "ADMIN":
                    accessLevel = Enums.PrivilageLevel.ADMIN;
                    label_employeno.Visible = true;
                    tb_utno.Visible = true;
                    tb_utno.Text = "Enter Employee No";
                    tb_utno.ForeColor = Color.LightGray;
                    label_salary.Visible = true;
                    tb_salary.Visible = true;
                    break;

                case "STUDENT":
                    accessLevel = Enums.PrivilageLevel.STUDENT;
                    label_employeno.Visible = false;
                    tb_utno.Visible = true;
                    cb_group.Visible = true;
                    cb_course.Visible = true;
                    label_utno.Visible = true;
                    label_group.Visible = true;
                    label_course.Visible = true;
                    lable_parent.Visible = true;
                    tb_parent.Visible = true;
                    break;

                case "STAFF":
                    accessLevel = Enums.PrivilageLevel.STAFF;
                    label_employeno.Visible = true;
                    tb_utno.Visible = true;
                    tb_utno.Text = "Enter Employee No";
                    tb_utno.ForeColor = Color.LightGray;
                    label_salary.Visible = true;
                    tb_salary.Visible = true;
                    break;

                case "LECTURER":
                    accessLevel = Enums.PrivilageLevel.LECTURER;
                    label_employeno.Visible = true;
                    tb_utno.Visible = true;
                    tb_utno.Text = "Enter Employee No";
                    tb_utno.ForeColor = Color.LightGray;
                    label_salary.Visible = true;
                    tb_salary.Visible = true;
                    break;
            }
        }

        private void tb_datejoined_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_parent_Enter(object sender, EventArgs e)
        {
            tb_parent.ForeColor = Color.Black;
            tb_parent.Text = string.Empty;
        }

        private void tb_utno_Enter(object sender, EventArgs e)
        {
            tb_utno.Text = string.Empty;
            tb_utno.ForeColor = Color.Black;
        }
    }
}
