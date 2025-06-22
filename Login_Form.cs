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
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem
{
    public partial class login_Form : Form
    {
        public login_Form()
        {
            InitializeComponent();
           DBInitializer.CreateTables();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (LoginController.CheckLogin(tb_username.Text, tb_password.Text))
            {
                Main_Form f = new Main_Form();
                f.StartPosition = FormStartPosition.CenterScreen;
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
            tb_username.Focus();
        }

        //checking username and pasword must contains the minimum required letters when leaving the textbox
        private void tb_username_Leave(object sender, EventArgs e)
        {
            if (tb_username.Text.Length < 3)
            {
                label_error.Text = "Username must be at least 3 characters long.";
                label_error.Visible = true;
                tb_username.Clear();
                tb_username.Focus();
            }
            else
            {
                label_error.Visible = false;
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text.Length < 3)
            {
                label_error.Text = "Password must be at least 3 characters long.";
                label_error.Visible = true;
                tb_password.Clear();
                tb_password.Focus();
            }
            else
            {
                label_error.Visible = false;
            }
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
