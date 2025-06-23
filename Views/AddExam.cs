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
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Views
{
    public partial class AddExam : Form
    {
        public AddExam()
        {
            InitializeComponent();
        }

        private void AddExam_Load(object sender, EventArgs e)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string queryexam = "SELECT Id, Name FROM Subjects";
                using (var cmd = new SQLiteCommand(queryexam, dbconn))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataRow dr = dt.NewRow();
                    dr["Id"] = 0;
                    dr["Name"] = "-- Select One --";
                    dt.Rows.InsertAt(dr, 0);


                    cb_subject.DataSource = dt;
                    cb_subject.DisplayMember = "Name";
                    cb_subject.ValueMember = "Id";
                    cb_subject.SelectedIndex = 0;
                }
            }
        }

        private void btn_add_exam_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam
            {
               Name = tb_exam_name.Text,
               SubjectId = Convert.ToInt32(cb_subject.SelectedValue.ToString())
            };
            ExamMarksController emc = new ExamMarksController();
            MessageBox.Show(emc.AddExam(exam));
        }
    }
}
