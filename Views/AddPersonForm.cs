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
using static UnicomTICManagementSystem.Models.Enums;

namespace UnicomTICManagementSystem.Views
{
    public partial class AddPersonForm : Form
    {
        public AddPersonForm()
        {
            InitializeComponent();
            LoadComboBoxData();
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


                        combo_course.DataSource = dt;
                        combo_course.DisplayMember = "CourseName"; // visible text
                        combo_course.ValueMember = "Id";     // internal value
                                                             // Set default selected index (the dummy row)
                        combo_course.SelectedIndex = 0;
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
            User user = new User
            {
                Username = tb_username.Text,
                Password = tb_password.Text,
                Role = Enums.UserRole.STUDENT,
                Status = Enums.UserStatus.ACTIVE
            };
            UsersController uController = new UsersController();
            string getMessage1 = uController.AddUser(user);
            Student st = new Student
            {
                UTNumber = tb_utno.Text,
                NicNo = tb_nic.Text,
                Name = tb_name.Text,
                Address = tb_address.Text,
                Email = tb_email.Text,
                ContactNo = tb_contactno.Text,
                CourseId = Convert.ToInt32(combo_course.SelectedValue),
                UserId = user.Id
            };

            StudentController stController = new StudentController();


            string getMessage = stController.AddStudent(st);

            MessageBox.Show(getMessage+"\n"+getMessage1);
 //           this.Clear();
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
                error_nic.Text = "Invalid NIC ! Please enter a valid one.";
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
            string selectedRole = cb_role.SelectedItem.ToString();
            if(selectedRole == "ADMIN")
            {
                MessageBox.Show("ADMIN SELECTED");
            }
        }
    }
}
