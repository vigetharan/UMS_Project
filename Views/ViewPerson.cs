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
        
        public ViewPerson(DataTable personData, bool isViewOnly)
        {
            InitializeComponent();
            IsViewOnly = isViewOnly;
            LoadDataToForm(personData);
            setViewMode(IsViewOnly);

        }
        private void setViewMode(bool editable)
        {
            // Example for textboxes:
 //           txtName.ReadOnly = !editable;
 //           txtRole.ReadOnly = !editable;

//            btnSave.Enabled = editable;  // enable save only in editable mode
 //           btnUpdate.Enabled = !editable; // enable update only in view mode
        }


        private void ViewPerson_Load(object sender, EventArgs e)
        {
//            if(isViewMode) 
 //           {
//                if(control)

        }
        private void LoadDataToForm(DataTable dt)
        {
            try
            {
                if (dt.Rows.Count == 0) return;
                var row = dt.Rows[0];
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
                        MessageBox.Show("student role");
                        break;

                    case "LECTURER":
                        label_course.Visible = false;
                        label_parent.Visible = false;
                        MessageBox.Show("lec role");
                        break;

                    case "STAFF":
                        label_course.Visible = false;
                        label_parent.Visible = false;
                        MessageBox.Show("staff role");
                        break;

                    case "ADMIN":
                        label_course.Visible = false;
                        label_parent.Visible = false;
                        MessageBox.Show("admin role");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load person data: " + ex.Message);
            }
        }

    }
}
