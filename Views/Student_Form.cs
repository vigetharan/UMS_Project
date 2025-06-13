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

namespace UnicomTICManagementSystem.Views
{
    public partial class Student_Form : Form
    {
        public Student_Form()
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
    }
}
