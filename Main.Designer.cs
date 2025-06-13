namespace UnicomTICManagementSystem
{
    partial class Main_Form
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btn_exam = new System.Windows.Forms.Button();
            this.btn_timetable = new System.Windows.Forms.Button();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.btn_course = new System.Windows.Forms.Button();
            this.btn_staff = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_lecturer = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_add_new = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.UpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.leftPanel.Controls.Add(this.btn_exam);
            this.leftPanel.Controls.Add(this.btn_timetable);
            this.leftPanel.Controls.Add(this.btn_attendance);
            this.leftPanel.Controls.Add(this.btn_course);
            this.leftPanel.Controls.Add(this.btn_staff);
            this.leftPanel.Controls.Add(this.btn_admin);
            this.leftPanel.Controls.Add(this.btn_lecturer);
            this.leftPanel.Controls.Add(this.btn_student);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(111, 650);
            this.leftPanel.TabIndex = 0;
            // 
            // btn_exam
            // 
            this.btn_exam.Location = new System.Drawing.Point(0, 483);
            this.btn_exam.Name = "btn_exam";
            this.btn_exam.Size = new System.Drawing.Size(105, 56);
            this.btn_exam.TabIndex = 7;
            this.btn_exam.Text = "EXAMS / MARKS";
            this.btn_exam.UseVisualStyleBackColor = true;
            this.btn_exam.Click += new System.EventHandler(this.btn_exam_Click);
            // 
            // btn_timetable
            // 
            this.btn_timetable.Location = new System.Drawing.Point(0, 421);
            this.btn_timetable.Name = "btn_timetable";
            this.btn_timetable.Size = new System.Drawing.Size(105, 56);
            this.btn_timetable.TabIndex = 6;
            this.btn_timetable.Text = "TIME TABLES";
            this.btn_timetable.UseVisualStyleBackColor = true;
            this.btn_timetable.Click += new System.EventHandler(this.btn_timetable_Click);
            // 
            // btn_attendance
            // 
            this.btn_attendance.Location = new System.Drawing.Point(0, 359);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Size = new System.Drawing.Size(105, 56);
            this.btn_attendance.TabIndex = 5;
            this.btn_attendance.Text = "ATTENDANCES";
            this.btn_attendance.UseVisualStyleBackColor = true;
            this.btn_attendance.Click += new System.EventHandler(this.btn_attendance_Click);
            // 
            // btn_course
            // 
            this.btn_course.Location = new System.Drawing.Point(0, 297);
            this.btn_course.Name = "btn_course";
            this.btn_course.Size = new System.Drawing.Size(105, 56);
            this.btn_course.TabIndex = 4;
            this.btn_course.Text = "COURSE / SUBJECTS";
            this.btn_course.UseVisualStyleBackColor = true;
            this.btn_course.Click += new System.EventHandler(this.btn_course_Click);
            // 
            // btn_staff
            // 
            this.btn_staff.Location = new System.Drawing.Point(0, 235);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Size = new System.Drawing.Size(105, 56);
            this.btn_staff.TabIndex = 3;
            this.btn_staff.Text = "STAFFS";
            this.btn_staff.UseVisualStyleBackColor = true;
            this.btn_staff.Click += new System.EventHandler(this.btn_staff_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(0, 173);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(105, 56);
            this.btn_admin.TabIndex = 2;
            this.btn_admin.Text = "ADMINS";
            this.btn_admin.UseVisualStyleBackColor = true;
            // 
            // btn_lecturer
            // 
            this.btn_lecturer.Location = new System.Drawing.Point(0, 111);
            this.btn_lecturer.Name = "btn_lecturer";
            this.btn_lecturer.Size = new System.Drawing.Size(105, 56);
            this.btn_lecturer.TabIndex = 1;
            this.btn_lecturer.Text = "LECTURERS";
            this.btn_lecturer.UseVisualStyleBackColor = true;
            this.btn_lecturer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_student
            // 
            this.btn_student.Location = new System.Drawing.Point(0, 49);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(105, 56);
            this.btn_student.TabIndex = 0;
            this.btn_student.Text = "STUDENTS";
            this.btn_student.UseVisualStyleBackColor = true;
            this.btn_student.Click += new System.EventHandler(this.button1_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(111, 40);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(889, 610);
            this.centerPanel.TabIndex = 1;
            this.centerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // UpPanel
            // 
            this.UpPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpPanel.Controls.Add(this.button1);
            this.UpPanel.Controls.Add(this.btn_add_new);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(111, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(889, 40);
            this.UpPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "EDIT AN ENTRY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_add_new
            // 
            this.btn_add_new.Location = new System.Drawing.Point(3, 3);
            this.btn_add_new.Name = "btn_add_new";
            this.btn_add_new.Size = new System.Drawing.Size(80, 37);
            this.btn_add_new.TabIndex = 0;
            this.btn_add_new.Text = "ADD A NEW ENTRY";
            this.btn_add_new.UseVisualStyleBackColor = true;
            this.btn_add_new.Click += new System.EventHandler(this.button7_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.UpPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.leftPanel.ResumeLayout(false);
            this.UpPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Button btn_course;
        private System.Windows.Forms.Button btn_staff;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_lecturer;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_add_new;
        private System.Windows.Forms.Button btn_exam;
        private System.Windows.Forms.Button btn_timetable;
        private System.Windows.Forms.Button button1;
    }
}