using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Repositories;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnicomTICManagementSystem.Views
{
    public partial class Person_Details : Form
    {
        private DataTable dt;
        public Person_Details()
        {
            InitializeComponent();
            LoadDataIntoGrid();
        }

        public void LoadDataIntoGrid()
        {
            PersonController pc = new PersonController();
            dt = pc.ViewAllPerson();
            //
            //set the access level to admin, staff, lecturer for view all persons details
            if (LoggedInUser.Role == Enums.UserRole.ADMIN || LoggedInUser.Role == Enums.UserRole.STAFF || LoggedInUser.Role == Enums.UserRole.LECTURER)
            {
                student_view.DataSource = dt;
            }
            else
            {
                try
                {
                    // Filter the DataTable for the logged-in user's only
                    DataRow[] filteredRows = dt.Select($"Id = '{LoggedInUser.PersonId}'");

                    if (filteredRows.Length > 0)
                    {
                        // Create a new DataTable with filtered rows
                        DataTable filteredTable = filteredRows.CopyToDataTable();

                        // Set the filtered table as the DataSource for the grid when STUDENT logged in.
                        student_view.DataSource = filteredTable;
                        panel1.Hide();
                        btn_delete.Hide();
                        btn_update.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void student_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_filterbyname_TextChanged(object sender, EventArgs e)
        {
            if (dt == null) return;

            DataView dv = dt.DefaultView;
            dv.RowFilter = $"Name LIKE '%{tb_filterbyname.Text.Replace("'", "''")}%'"; // escape quotes
            student_view.DataSource = dv;
            student_view.Refresh();
        }

        private void checkBox_all_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_viewPerson_Click(object sender, EventArgs e)
        {

            if (student_view.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to view details.");
                return;
            }

            DataRow[] filteredRows;

            // Check if there is a selected row in the DataGridView
            if (student_view.SelectedRows.Count > 0)
            {
                // Get the PersonId from the selected row
                int personId = Convert.ToInt32(student_view.SelectedRows[0].Cells["Id"].Value);

                // Filter DataTable based on PersonId
                filteredRows = dt.Select($"Id = '{personId}'");
            }
            else
            {
                MessageBox.Show("Please select a row to view details.");
                return;
            }

            // Check if any rows are found
            if (filteredRows.Length > 0)
            {
                // Create a new DataTable with the filtered rows
                DataTable personData = filteredRows.CopyToDataTable();

                // Pass the DataTable to the ViewPerson form
                ViewPerson pop = new ViewPerson(personData, true);
                pop.StartPosition = FormStartPosition.CenterScreen;
                pop.Show();
            }
            else
            {
                MessageBox.Show("No data found for the Selected row.");
            }
        }

        private void Person_Details_Load(object sender, EventArgs e)
        {
            LoadDataIntoGrid();
        }

        private void rb_all_CheckedChanged(object sender, EventArgs e)
        {
            student_view.DataSource = dt;
        }

        private void rb_student_CheckedChanged(object sender, EventArgs e)
        {
            DataRow[] filteredrow = dt.Select($"UserRole = 'STUDENT'");
            if (filteredrow.Length > 0)
            {
                DataTable filteredTable = filteredrow.CopyToDataTable();
                student_view.DataSource = filteredTable;
            }      

            else
            {
                MessageBox.Show("No lecturers found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void rb_admin_CheckedChanged(object sender, EventArgs e)
        {
            DataRow[] filteredrow = dt.Select($"UserRole = 'ADMIN'");
            if (filteredrow.Length > 0)
            {                
                DataTable filteredTable = filteredrow.CopyToDataTable();
                student_view.DataSource = filteredTable;
            }
            else
            {

                MessageBox.Show("No Admins found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void rb_lecturer_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_lecturer.Checked)
            {
                DataRow[] filteredrow = dt.Select($"UserRole = 'LECTURER'");
                if (filteredrow.Length > 0)
                {
                    DataTable filteredTable = filteredrow.CopyToDataTable();
                    student_view.DataSource = filteredTable;
                }
                else
                {

                    MessageBox.Show("No lecturers found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void rb_staff_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_staff.Checked)
            {
                DataRow[] filteredrow = dt.Select($"UserRole = 'STAFF'");
                if (filteredrow.Length > 0)
                {
                    DataTable filteredTable = filteredrow.CopyToDataTable();
                    student_view.DataSource = filteredTable;
                }
                else
                {

                    MessageBox.Show("No Staffs found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void tb_filterbyid_TextChanged(object sender, EventArgs e)
        {
            if (dt == null) return;

            DataView dv = dt.DefaultView;
            dv.RowFilter = $"UT_EMP_No LIKE '%{tb_filterbyid.Text.Replace("'", "''")}%'"; // escape quotes
            student_view.DataSource = dv;
            student_view.Refresh();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (student_view.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to view details.");
                return;
            }

            DataRow[] filteredRowsupdate;

            // Check if there is a selected row in the DataGridView
            if (student_view.SelectedRows.Count > 0)
            {
                // Get the PersonId from the selected row
                string personId = student_view.SelectedRows[0].Cells["Id"].Value.ToString();

                // Filter DataTable based on PersonId
                filteredRowsupdate = dt.Select($"Id = '{personId}'");
            }
            else
            {
                MessageBox.Show("Please select a row to view details.");
                return;
            }

            // Check if any rows are found
            if (filteredRowsupdate.Length > 0)
            {
                // Create a new DataTable with the filtered rows
                DataTable personDatau = filteredRowsupdate.CopyToDataTable();

                // Pass the DataTable to the ViewPerson form
                ViewPerson pop = new ViewPerson(personDatau, false);
                pop.StartPosition = FormStartPosition.CenterScreen;
                pop.Show();
            }
            else
            {
                MessageBox.Show("No data found for the Selected row.");
            }
            LoadDataIntoGrid();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (student_view.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Get selected person's Id
            int personId = Convert.ToInt32(student_view.SelectedRows[0].Cells["Id"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this person?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Delete using controller
                PersonController pc = new PersonController();
                bool success = pc.DeletePerson(personId);

                if (success)
                {
                    MessageBox.Show("Person deleted successfully.");
                    LoadDataIntoGrid(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Deletion failed. Person may not exist.");
                }
            }
        }
    }
    
    
    
}
