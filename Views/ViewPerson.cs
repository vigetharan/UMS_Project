using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UnicomTICManagementSystem.Models.Enums;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;
using System.Xml.Linq;
using System.Data.SQLite;
using System.Net.NetworkInformation;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Views
{
    public partial class ViewPerson : Form
    {
        public bool IsViewOnly { get; set; } = false;
        public int personid;
        public DataTable dt;
        
        public ViewPerson(DataTable personData, bool isViewOnly)
        {
            InitializeComponent();
            IsViewOnly = isViewOnly;
            LoadDataToForm(personData);
            setViewMode(IsViewOnly);

        }
        private void setViewMode(bool IsViewOnly)
        {
            tb_name.Enabled = !IsViewOnly;
            tb_address.Enabled = !IsViewOnly;
            tb_email.Enabled = !IsViewOnly;
            tb_contact.Enabled = !IsViewOnly;            
            tb_empNo.Enabled = !IsViewOnly;
            tb_salary.Enabled = !IsViewOnly;
            tb_parentcontact.Enabled = !IsViewOnly;
            tb_datejoined.Enabled = !IsViewOnly;    
           btn_update.Enabled = !IsViewOnly; 
        }

        private void ViewPerson_Load(object sender, EventArgs e)
        {
            tb_nic.Enabled = false;
            tb_role.Enabled = false;
            tb_age.Enabled = false;
            tb_dob.Enabled = false;
            tb_nic.Enabled = false;
            tb_gender.Enabled = false;
            tb_course.Enabled = false;
//            dgv_marks.Visible = false;
            label_marks.Visible = false;
        }
        public void loadDGV(int PersonId)
        {
            DataTable dt = new DataTable();
            ExamMarksController emc = new ExamMarksController();
            dt = emc.GetAllMarks();
                    try
                    {
                        // Filter the DataTable for the logged-in user's only
                        DataRow[] filteredRows = dt.Select($"StudentId = '{LoggedInUser.PersonId}'");

                        if (filteredRows.Length > 0)
                        {
                            // Create a new DataTable with filtered rows
                            DataTable filteredTable = filteredRows.CopyToDataTable();

                            // Set the filtered table as the DataSource for the grid when STUDENT logged in.
                            dgv_marks.DataSource = filteredTable;
                            dgv_marks.Columns["StudentName"].Visible = false;
                            dgv_marks.Columns["Id"].Visible = false;
                            dgv_marks.Columns["StudentId"].Visible = false;

                }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
        }
        private void LoadDataToForm(DataTable datatable)
        {
            dt = datatable;
            try
            {
                if (dt.Rows.Count == 0) return;
                var row = dt.Rows[0];
                personid = Convert.ToInt32(row["Id"]);
                tb_nic.Text = row["NicNo"].ToString();
                tb_name.Text = row["Name"].ToString();
                tb_address.Text = row["Address"].ToString();
                tb_email.Text = row["Email"].ToString();
                tb_contact.Text = row["ContactNo"].ToString();
                tb_gender.Text = row["Gender"].ToString();
                tb_dob.Text = row["DateOfBirth"].ToString();
                tb_role.Text= row["UserRole"].ToString();
                tb_empNo.Text = row["UT_EMP_No"].ToString();
                tb_salary.Text = row["Salary"].ToString();
                tb_parentcontact.Text = row["PARENTS_CONTACT"].ToString();
                tb_datejoined.Text = row["JoinedDate"].ToString();
               tb_course.Text = row["CourseName"].ToString();
                tb_age.Text = row["Age"].ToString();


                switch (row["UserRole"].ToString())
                {
                    case "STUDENT":
                        label_salary.Visible = false;
                        tb_salary.Visible = false;
                        label_marks.Visible = true;
                        loadDGV(LoggedInUser.PersonId);
                        dgv_marks.Visible = true;
                        break;

                    case "LECTURER":
                        label_course.Visible = false;
                        tb_course.Visible=false;
                        label_parent.Visible = false;
                        tb_parentcontact.Visible = false;
                        break;

                    case "STAFF":
                        label_course.Visible = false;
                        tb_course.Visible = false;
                        label_parent.Visible = false;
                        tb_parentcontact.Visible = false;
                        break;

                    case "ADMIN":
                        label_course.Visible = false;
                        tb_course.Visible = false;
                        label_parent.Visible = false;
                        tb_parentcontact.Visible = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load person data: " + ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            var row = dt.Rows[0];
            Person p = new Person
            {
                Id= personid,
                Name = tb_name.Text.Trim(),
                Address = tb_address.Text.Trim(),
                Email = tb_email.Text.Trim(),
                ContactNo = tb_contact.Text.Trim()
            };
            PersonController pc = new PersonController();
            MessageBox.Show(pc.UpdatePerson(p));
            switch (row["UserRole"].ToString())
            {
                case "STUDENT":
                    Student s = new Student();
                    s.UTNumber = tb_empNo.Text.Trim();
                    s.JoinedDate = tb_datejoined.Text.Trim();
                    s.ParentContact = tb_parentcontact.Text.Trim();
                    s.CourseId = Convert.ToInt32(tb_course.Text.Trim());
                    StudentController st = new StudentController();
                    MessageBox.Show(st.UpdateStudent(s));
                    break;

                case "LECTURER":
                    Lecturer l = new Lecturer();
                    l.EmployeeNo = tb_empNo.Text.Trim();
                    l.Salary = Convert.ToDecimal(tb_salary.Text.Trim());
                    l.JoinedDate = tb_datejoined.Text.Trim();
                    LecturerController lc = new LecturerController();
                    MessageBox.Show(lc.UpdateLecturer(l));
                    break;
                case "ADMIN":
                    Admin a = new Admin();
                    a.EmployeeNo = tb_empNo.Text.Trim();
                    a.Salary = Convert.ToDecimal(tb_salary.Text.Trim());
                    a.JoinedDate = tb_datejoined.Text.Trim();
                    AdminController ad = new AdminController();
                    MessageBox.Show(ad.UpdateAdmin(a));
                    break;
                case "STAFF":
                    Staff staff = new Staff();
                    staff.EmployeeNo = tb_empNo.Text.Trim();
                   staff.Salary = Convert.ToDecimal(tb_salary.Text.Trim());
                    staff.JoinedDate = tb_datejoined.Text.Trim();
                    StaffController sc = new StaffController();
                    MessageBox.Show(sc.UpdateStaff(staff));
                    break; 

            }

        }
    }
}
