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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnicomTICManagementSystem.Views
{
    public partial class Student_Details : Form
    {
        private DataTable dt;
        public Student_Details()
        {
            InitializeComponent();
            LoadDataIntoGrid();
        }

        public void LoadDataIntoGrid()
        {
            StudentController Stc = new StudentController();
            dt = Stc.GetAllStudents();
            student_view.DataSource = dt;
        }

        private void student_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_filterbyname_TextChanged(object sender, EventArgs e)
        {
            //           DataView dv = dt.DefaultView;
            //         dv.RowFilter = $"Name LIKE '%{tb_filterbyname.Text}%'";
            //       student_view.DataSource = dv;
            if (dt == null) return;

            DataView dv = dt.DefaultView;
            dv.RowFilter = $"Name LIKE '%{tb_filterbyname.Text.Replace("'", "''")}%'"; // escape quotes
            student_view.DataSource = dv;
            student_view.Refresh();
        }
    }
}
