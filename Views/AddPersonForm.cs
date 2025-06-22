using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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



        public AddPersonForm()
        {
            InitializeComponent();
            LoadComboBoxData();
            tb_parent.Text = "Enter Parent's / Guardian's Contact Number";
            tb_parent.ForeColor = Color.LightGray;
        }

        private void Student_Form_Load(object sender, EventArgs e)
        {
            tb_name.Focus();

            // Load into Gender combo
            var genderList = new List<string> { "--select--" };
            genderList.AddRange(Enum.GetValues(typeof(Enums.Gender)).Cast<Enums.Gender>().Select(g => g.ToString()));
            cb_gender.DataSource = genderList;
            cb_gender.SelectedIndex = 0; // default to "--select--"

            // Load into Role combo
            var roleList = new List<string> { "--select--" };
            roleList.AddRange(Enum.GetValues(typeof(Enums.UserRole)).Cast<Enums.UserRole>().Select(r => r.ToString()));
            cb_role.DataSource = roleList;
            cb_role.SelectedIndex = 0; // default to "--select--"
        }
        //method for clear all fields
        private void Clear_Form()
        {
            tb_address.Clear();
            tb_name.Clear();
            tb_contactno.Clear();
            tb_email.Clear();
            tb_dob.Clear();
            tb_parent.Text = "Enter Parent's / Guardian's Contact Number";
            tb_parent.ForeColor = Color.LightGray;
            tb_salary.Clear();
            tb_username.Clear();
            tb_password.Clear();
            tb_utno.Clear();
            tb_nic.Clear();
            cb_role.SelectedIndex = 0;
            cb_gender.SelectedIndex = 0;
        }

        // method for load course combo box
        private void LoadComboBoxData()
        {
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
                    Role = (Enums.UserRole)Enum.Parse(typeof(Enums.UserRole), cb_role.SelectedItem.ToString().ToUpper()),
                    Status = Enums.UserStatus.ACTIVE,
                };
                UsersController uController = new UsersController();
                int userid = uController.AddUser(user);

                Person p = new Person
                {
                    NicNo = tb_nic.Text.Trim(),
                    Name = tb_name.Text.Trim(),
                    Address = tb_address.Text.Trim(),
                    Email = tb_email.Text.Trim(),
                    ContactNo = tb_contactno.Text.Trim(),
                    Gender = (Gender)cb_gender.SelectedIndex,
                    DateOfBirth = DateTime.Parse(tb_dob.Text),
                    UserId = userid,
                    UserRole = (Enums.UserRole)Enum.Parse(typeof(Enums.UserRole), cb_role.SelectedItem.ToString().ToUpper()),
                };

                PersonController pController = new PersonController();
                int personId = pController.AddPerson(p);

                string selectedRole = cb_role.SelectedItem.ToString();
                switch (selectedRole)
                {
                    case "STUDENT":
                        Student st = new Student
                        {
                            PersonId = personId,
                            UTNumber = tb_utno.Text.Trim(),
                            CourseId = Convert.ToInt32(cb_course.SelectedValue),
                            JoinedDate = dtp_datejoined.Value.ToString("yyyyMMdd"),
                            ParentContact = tb_parent.Text.Trim()
                        };
                        StudentController sController = new StudentController();
                        string message = sController.AddStudent(st);
                        MessageBox.Show(message);
                        break;
                    case "LECTURER":
                        {
                            Lecturer l = new Lecturer
                            {
                                PersonId = personId,
                                EmployeeNo = tb_utno.Text.Trim(),
                                Salary = Convert.ToDecimal(tb_salary.Text.Trim()),
                                JoinedDate = dtp_datejoined.Value.ToString("yyyyMMdd")
                            };
                            LecturerController lController = new LecturerController();
                            string messag = lController.AddLecturer(l);
                            MessageBox.Show(messag);
                            break;
                        }
                    case "STAFF":
                        {
                            Staff s = new Staff
                            {
                                PersonId = personId,
                                EmployeeNo = tb_utno.Text, // Assuming tb_utno is used for employee ID
                                Salary = Convert.ToDecimal(tb_salary.Text),
                                JoinedDate = dtp_datejoined.Value.ToString("yyyy-MM-dd")
                            };
                            StaffController stfController = new StaffController();
                            string mess = stfController.AddStaff(s);
                            MessageBox.Show(mess);
                            break;
                        }
                    case "ADMIN":
                        {
                            Admin a = new Admin
                            {
                                PersonId = personId,
                                EmployeeNo = tb_utno.Text,
                                Salary = Convert.ToDecimal(tb_salary.Text),
                                UserId = userid,
                                JoinedDate = dtp_datejoined.Value.ToString("yyyy-MM-dd")
                            };
                            AdminController aController = new AdminController();
                            string mes = aController.AddAdmin(a);
                            MessageBox.Show(mes);
                            break;
                        }
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






        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            cb_course.Visible = false;
            label_utno.Visible = false;
            label_course.Visible = false;
            lable_parent.Visible = false;
            label_salary.Visible = false;
            tb_salary.Visible = false;
            
            string selectedRole = cb_role.SelectedItem.ToString();
            switch (selectedRole)
            {
                case "ADMIN":
                    label_employeno.Visible = true;
                    tb_utno.Visible = true;
                    tb_utno.Text = "Enter Employee No";
                    tb_utno.ForeColor = Color.LightGray;
                    label_salary.Visible = true;
                    tb_salary.Visible = true;
                    break;

                case "STUDENT":
                    label_employeno.Visible = false;
                    tb_utno.Visible = true;
                    cb_course.Visible = true;
                    label_utno.Visible = true;
                    label_course.Visible = true;
                    lable_parent.Visible = true;
                    tb_parent.Visible = true;
                    break;

                case "STAFF":
                    label_employeno.Visible = true;
                    tb_utno.Visible = true;
                    tb_utno.Text = "Enter Employee No";
                    tb_utno.ForeColor = Color.LightGray;
                    label_salary.Visible = true;
                    tb_salary.Visible = true;
                    break;

                case "LECTURER":
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


        private void tb_name_Leave(object sender, EventArgs e)
        {
            if (tb_name.Text.Length<4 && !string.IsNullOrWhiteSpace(tb_name.Text))
            {
                error_name.Visible = true;
                error_name.Text = "Name must be at least 4 characters long.";
                tb_name.Clear();
            }
            else
            {
                error_name.Visible = false;
            }
        }

        private void tb_address_TextChanged(object sender, EventArgs e)
        {
            if(tb_address.Text.Length < 10 && !string.IsNullOrWhiteSpace(tb_address.Text) )
            {
                error_address.Visible = true;
                error_address.Text = "Address must be at least 10 characters long.";
            }
            else
            {
                error_address.Visible = false;
            }
        }

        private void tb_email_Leave(object sender, EventArgs e)
        {
            string email = tb_email.Text;

            // Basic email pattern
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (email.Length < 5 || !Regex.IsMatch(email, pattern))
            {
                error_email.Visible = true;
                error_email.Text = "Email must be at least 5 characters long\nand must be in a valid email format (e.g., user@example.com).";
                tb_email.Clear();
            }
            else
            {
                error_email.Visible = false;
            }
        }

        private void tb_contactno_Leave(object sender, EventArgs e)
        {
            if(tb_contactno.Text.Length < 10 || !Regex.IsMatch(tb_contactno.Text, @"^0\d{9}$"))
            {
                error_contactno.Visible = true;
                error_contactno.Text = "Contact number must be exactly 10 digits long.";
                tb_contactno.Clear();
            }
            else
            {
                error_contactno.Visible = false;
            }
        }

        private void tb_username_Leave(object sender, EventArgs e)
        {
            string username= tb_username.Text.Trim();
            LoginController l = new LoginController();
            if (username.Length < 3 && !string.IsNullOrWhiteSpace(username))
            {
                error_username.Visible = true;
                error_username.Text = "Username must be at least 3 characters long.";
                tb_username.Clear();
            }
            else if(l.IsUsernameTaken(username))
            {
                    error_username.Text = "Username is already taken. Please choose another one.";
                    tb_username.Clear();
            
            }
            else
            {
                error_username.Visible = false;
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if(tb_password.Text.Length < 3 && !string.IsNullOrWhiteSpace(tb_password.Text))
                {

                error_pw.Visible = true;
                error_pw.Text = "Password must be at least 3 characters long.";
                tb_password.Clear();
            }
        }

        private void tb_salary_Leave(object sender, EventArgs e)
        {
            if(!decimal.TryParse(tb_salary.Text, out decimal salary) || salary <= 0)
            {
                error_group.Visible = true;
                error_group.Text = "Salary must be a positive number.";
                tb_salary.Clear();
            }
            else
            {
                error_group.Visible = false;
            }
        }

        private void tb_parent_TextChanged(object sender, EventArgs e)
        {
            if(tb_parent.Text.Length < 10 && !string.IsNullOrWhiteSpace(tb_parent.Text) || !Regex.IsMatch(tb_contactno.Text, @"^0\d{9}$"))
            {
                error_parent.Visible = true;
                error_parent.Text = "Parent's contact number must be at least 10 digits long.";
            }
            else
            {
                error_parent.Visible = false;
            }
        }
    }
}
