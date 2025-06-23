namespace UnicomTICManagementSystem.Views
{
    partial class Person_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_viewPerson = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.tb_filterbyname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_filterbyname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.rb_student = new System.Windows.Forms.RadioButton();
            this.tb_filterbyid = new System.Windows.Forms.TextBox();
            this.rb_admin = new System.Windows.Forms.RadioButton();
            this.label_filterbyid = new System.Windows.Forms.Label();
            this.rb_lecturer = new System.Windows.Forms.RadioButton();
            this.rb_all = new System.Windows.Forms.RadioButton();
            this.rb_staff = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_radio = new System.Windows.Forms.GroupBox();
            this.student_view = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gb_radio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_view)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_viewPerson
            // 
            this.btn_viewPerson.Location = new System.Drawing.Point(32, 4);
            this.btn_viewPerson.Name = "btn_viewPerson";
            this.btn_viewPerson.Size = new System.Drawing.Size(108, 23);
            this.btn_viewPerson.TabIndex = 2;
            this.btn_viewPerson.Text = "VIEW DETAILS";
            this.btn_viewPerson.UseVisualStyleBackColor = true;
            this.btn_viewPerson.Click += new System.EventHandler(this.btn_viewPerson_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(223, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(108, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // tb_filterbyname
            // 
            this.tb_filterbyname.Location = new System.Drawing.Point(420, 4);
            this.tb_filterbyname.Name = "tb_filterbyname";
            this.tb_filterbyname.Size = new System.Drawing.Size(125, 20);
            this.tb_filterbyname.TabIndex = 3;
            this.tb_filterbyname.TextChanged += new System.EventHandler(this.tb_filterbyname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "VIEW\r\n  BY";
            // 
            // label_filterbyname
            // 
            this.label_filterbyname.AutoSize = true;
            this.label_filterbyname.Location = new System.Drawing.Point(359, 3);
            this.label_filterbyname.Name = "label_filterbyname";
            this.label_filterbyname.Size = new System.Drawing.Size(55, 26);
            this.label_filterbyname.TabIndex = 10;
            this.label_filterbyname.Text = "FILTER\r\nBY NAME";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_viewPerson);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 531);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 30);
            this.panel2.TabIndex = 12;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(398, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(108, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // rb_student
            // 
            this.rb_student.AutoSize = true;
            this.rb_student.Location = new System.Drawing.Point(42, 4);
            this.rb_student.Name = "rb_student";
            this.rb_student.Size = new System.Drawing.Size(67, 17);
            this.rb_student.TabIndex = 13;
            this.rb_student.TabStop = true;
            this.rb_student.Text = "Students";
            this.rb_student.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb_student.UseVisualStyleBackColor = true;
            this.rb_student.CheckedChanged += new System.EventHandler(this.rb_student_CheckedChanged);
            // 
            // tb_filterbyid
            // 
            this.tb_filterbyid.Location = new System.Drawing.Point(671, 4);
            this.tb_filterbyid.Name = "tb_filterbyid";
            this.tb_filterbyid.Size = new System.Drawing.Size(125, 20);
            this.tb_filterbyid.TabIndex = 11;
            this.tb_filterbyid.TextChanged += new System.EventHandler(this.tb_filterbyid_TextChanged);
            // 
            // rb_admin
            // 
            this.rb_admin.AutoSize = true;
            this.rb_admin.Location = new System.Drawing.Point(115, 4);
            this.rb_admin.Name = "rb_admin";
            this.rb_admin.Size = new System.Drawing.Size(59, 17);
            this.rb_admin.TabIndex = 13;
            this.rb_admin.TabStop = true;
            this.rb_admin.Text = "Admins";
            this.rb_admin.UseVisualStyleBackColor = true;
            this.rb_admin.CheckedChanged += new System.EventHandler(this.rb_admin_CheckedChanged);
            // 
            // label_filterbyid
            // 
            this.label_filterbyid.AutoSize = true;
            this.label_filterbyid.Location = new System.Drawing.Point(555, 3);
            this.label_filterbyid.Name = "label_filterbyid";
            this.label_filterbyid.Size = new System.Drawing.Size(110, 26);
            this.label_filterbyid.TabIndex = 12;
            this.label_filterbyid.Text = "FILTER BY\r\nEmployee No /UT No";
            // 
            // rb_lecturer
            // 
            this.rb_lecturer.AutoSize = true;
            this.rb_lecturer.Location = new System.Drawing.Point(177, 4);
            this.rb_lecturer.Name = "rb_lecturer";
            this.rb_lecturer.Size = new System.Drawing.Size(69, 17);
            this.rb_lecturer.TabIndex = 13;
            this.rb_lecturer.TabStop = true;
            this.rb_lecturer.Text = "Lecturers";
            this.rb_lecturer.UseVisualStyleBackColor = true;
            this.rb_lecturer.CheckedChanged += new System.EventHandler(this.rb_lecturer_CheckedChanged);
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.Location = new System.Drawing.Point(0, 4);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(36, 17);
            this.rb_all.TabIndex = 13;
            this.rb_all.TabStop = true;
            this.rb_all.Text = "All";
            this.rb_all.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb_all.UseVisualStyleBackColor = true;
            this.rb_all.CheckedChanged += new System.EventHandler(this.rb_all_CheckedChanged);
            // 
            // rb_staff
            // 
            this.rb_staff.AutoSize = true;
            this.rb_staff.Location = new System.Drawing.Point(252, 4);
            this.rb_staff.Name = "rb_staff";
            this.rb_staff.Size = new System.Drawing.Size(52, 17);
            this.rb_staff.TabIndex = 13;
            this.rb_staff.TabStop = true;
            this.rb_staff.Text = "Staffs";
            this.rb_staff.UseVisualStyleBackColor = true;
            this.rb_staff.CheckedChanged += new System.EventHandler(this.rb_staff_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.tb_filterbyname);
            this.panel1.Controls.Add(this.label_filterbyname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_filterbyid);
            this.panel1.Controls.Add(this.tb_filterbyid);
            this.panel1.Controls.Add(this.gb_radio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 45);
            this.panel1.TabIndex = 11;
            // 
            // gb_radio
            // 
            this.gb_radio.Controls.Add(this.rb_staff);
            this.gb_radio.Controls.Add(this.rb_all);
            this.gb_radio.Controls.Add(this.rb_student);
            this.gb_radio.Controls.Add(this.rb_lecturer);
            this.gb_radio.Controls.Add(this.rb_admin);
            this.gb_radio.Location = new System.Drawing.Point(44, 3);
            this.gb_radio.Name = "gb_radio";
            this.gb_radio.Size = new System.Drawing.Size(310, 31);
            this.gb_radio.TabIndex = 13;
            this.gb_radio.TabStop = false;
            // 
            // student_view
            // 
            this.student_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.student_view.Location = new System.Drawing.Point(0, 45);
            this.student_view.MultiSelect = false;
            this.student_view.Name = "student_view";
            this.student_view.ReadOnly = true;
            this.student_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.student_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.student_view.Size = new System.Drawing.Size(843, 486);
            this.student_view.TabIndex = 1;
            this.student_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_view_CellContentClick);
            // 
            // Person_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 561);
            this.Controls.Add(this.student_view);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Person_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Person_Details";
            this.Load += new System.EventHandler(this.Person_Details_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_radio.ResumeLayout(false);
            this.gb_radio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_viewPerson;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tb_filterbyname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_filterbyname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_student;
        private System.Windows.Forms.TextBox tb_filterbyid;
        private System.Windows.Forms.RadioButton rb_admin;
        private System.Windows.Forms.Label label_filterbyid;
        private System.Windows.Forms.RadioButton rb_lecturer;
        private System.Windows.Forms.RadioButton rb_all;
        private System.Windows.Forms.RadioButton rb_staff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView student_view;
        private System.Windows.Forms.GroupBox gb_radio;
        private System.Windows.Forms.Button btn_delete;
    }
}