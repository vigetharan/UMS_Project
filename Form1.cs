using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Repositories;
using UnicomTICManagementSystem.Controllers;

namespace UnicomTICManagementSystem
{
    public partial class login_Form : Form
    {
        public login_Form()
        {
            InitializeComponent();
           DBInitializer.CreateTables();
            tb_username.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (LoginController.CheckLogin(tb_username.Text, tb_password.Text))
            {
                Main_Form f = new Main_Form();
                f.Show();
                
            }*/

            if (LoginController.CheckLogin(tb_username.Text, tb_password.Text))
            {
                Main_Form f = new Main_Form();
                f.Show();
                this.Hide();
            }
            else
            {
                tb_username.Clear();
                tb_password.Clear();
                label_error.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_error_Click(object sender, EventArgs e)
        {

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            label_error.Visible = false;
        }
    }
}
