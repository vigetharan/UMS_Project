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

namespace UnicomTICManagementSystem.Views
{
    public partial class ViewPerson : Form
    {
        public bool IsViewOnly { get; set; } = false;
        public int personid;
        
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
        }
        private void LoadDataToForm(DataTable dt)
        {
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

        }
    }
}
