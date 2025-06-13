using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Views;

namespace UnicomTICManagementSystem
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_Form studentForm = new Student_Form();
            studentForm.TopLevel = false;
            studentForm.FormBorderStyle = FormBorderStyle.None;
            studentForm.Dock = DockStyle.Fill;
            centerPanel.Controls.Add(studentForm);
            studentForm.Show();
        }
    }
}
