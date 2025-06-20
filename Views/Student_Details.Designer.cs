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
            this.student_view = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_filterbyname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_all = new System.Windows.Forms.CheckBox();
            this.checkBox_Staffs = new System.Windows.Forms.CheckBox();
            this.checkBox_Lecturers = new System.Windows.Forms.CheckBox();
            this.checkBox_admins = new System.Windows.Forms.CheckBox();
            this.checkBox_students = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.student_view)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // student_view
            // 
            this.student_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.student_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.student_view.Location = new System.Drawing.Point(0, 30);
            this.student_view.MultiSelect = false;
            this.student_view.Name = "student_view";
            this.student_view.ReadOnly = true;
            this.student_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.student_view.Size = new System.Drawing.Size(873, 511);
            this.student_view.TabIndex = 1;
            this.student_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_view_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tb_filterbyname
            // 
            this.tb_filterbyname.Location = new System.Drawing.Point(573, 10);
            this.tb_filterbyname.Name = "tb_filterbyname";
            this.tb_filterbyname.Size = new System.Drawing.Size(125, 20);
            this.tb_filterbyname.TabIndex = 3;
            this.tb_filterbyname.TextChanged += new System.EventHandler(this.tb_filterbyname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "VIEW BY";
            // 
            // checkBox_all
            // 
            this.checkBox_all.AutoSize = true;
            this.checkBox_all.Location = new System.Drawing.Point(87, 12);
            this.checkBox_all.Name = "checkBox_all";
            this.checkBox_all.Size = new System.Drawing.Size(37, 17);
            this.checkBox_all.TabIndex = 5;
            this.checkBox_all.Text = "All";
            this.checkBox_all.UseVisualStyleBackColor = true;
            this.checkBox_all.CheckedChanged += new System.EventHandler(this.checkBox_all_CheckedChanged);
            // 
            // checkBox_Staffs
            // 
            this.checkBox_Staffs.AutoSize = true;
            this.checkBox_Staffs.Location = new System.Drawing.Point(346, 12);
            this.checkBox_Staffs.Name = "checkBox_Staffs";
            this.checkBox_Staffs.Size = new System.Drawing.Size(53, 17);
            this.checkBox_Staffs.TabIndex = 6;
            this.checkBox_Staffs.Text = "Staffs";
            this.checkBox_Staffs.UseVisualStyleBackColor = true;
            // 
            // checkBox_Lecturers
            // 
            this.checkBox_Lecturers.AutoSize = true;
            this.checkBox_Lecturers.Location = new System.Drawing.Point(270, 12);
            this.checkBox_Lecturers.Name = "checkBox_Lecturers";
            this.checkBox_Lecturers.Size = new System.Drawing.Size(70, 17);
            this.checkBox_Lecturers.TabIndex = 7;
            this.checkBox_Lecturers.Text = "Lecturers";
            this.checkBox_Lecturers.UseVisualStyleBackColor = true;
            // 
            // checkBox_admins
            // 
            this.checkBox_admins.AutoSize = true;
            this.checkBox_admins.Location = new System.Drawing.Point(204, 12);
            this.checkBox_admins.Name = "checkBox_admins";
            this.checkBox_admins.Size = new System.Drawing.Size(60, 17);
            this.checkBox_admins.TabIndex = 8;
            this.checkBox_admins.Text = "Admins";
            this.checkBox_admins.UseVisualStyleBackColor = true;
            // 
            // checkBox_students
            // 
            this.checkBox_students.AutoSize = true;
            this.checkBox_students.Location = new System.Drawing.Point(130, 12);
            this.checkBox_students.Name = "checkBox_students";
            this.checkBox_students.Size = new System.Drawing.Size(68, 17);
            this.checkBox_students.TabIndex = 9;
            this.checkBox_students.Text = "Students";
            this.checkBox_students.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "FILTER BY NAME";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 30);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 30);
            this.panel2.TabIndex = 12;
            // 
            // Person_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_students);
            this.Controls.Add(this.checkBox_admins);
            this.Controls.Add(this.checkBox_Lecturers);
            this.Controls.Add(this.checkBox_Staffs);
            this.Controls.Add(this.checkBox_all);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_filterbyname);
            this.Controls.Add(this.student_view);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Person_Details";
            this.Text = "Person_Details";
            ((System.ComponentModel.ISupportInitialize)(this.student_view)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView student_view;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_filterbyname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_all;
        private System.Windows.Forms.CheckBox checkBox_Staffs;
        private System.Windows.Forms.CheckBox checkBox_Lecturers;
        private System.Windows.Forms.CheckBox checkBox_admins;
        private System.Windows.Forms.CheckBox checkBox_students;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}