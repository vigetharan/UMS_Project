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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           DBInitializer.CreateTables();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginController.CheckLogin( tb_username.Text, tb_password.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
