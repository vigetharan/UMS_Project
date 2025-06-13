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
            string query = "SELECT CourseName FROM Courses";

            try
            {
                using (var dbconn = DatabaseManager.GetConnection())
                {
                    SQLiteCommand cmd = new SQLiteCommand(query, dbconn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    combo_course.Items.Clear();

                    while (reader.Read())
                    {
                        combo_course.Items.Add(reader["CourseName"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                CourseId = int.Parse("1"),
                UserId = user.Id
            };

            StudentController stController = new StudentController();


            string getMessage = stController.AddStudent(st);

            MessageBox.Show(getMessage+"\n"+getMessage1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
