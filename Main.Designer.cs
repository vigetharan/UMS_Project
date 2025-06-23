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
            this.btn_persondetails = new System.Windows.Forms.Button();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.ilabel_icon = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            this.btn_addexam = new System.Windows.Forms.Button();
            this.btn_addtimeslot = new System.Windows.Forms.Button();
            this.btn_addcourse = new System.Windows.Forms.Button();
            this.btn_add_person = new System.Windows.Forms.Button();
            this.linkLabel_logout = new System.Windows.Forms.LinkLabel();
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
            this.leftPanel.Controls.Add(this.btn_persondetails);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(111, 650);
            this.leftPanel.TabIndex = 0;
            // 
            // btn_exam
            // 
            this.btn_exam.Location = new System.Drawing.Point(0, 173);
            this.btn_exam.Name = "btn_exam";
            this.btn_exam.Size = new System.Drawing.Size(105, 56);
            this.btn_exam.TabIndex = 7;
            this.btn_exam.Text = "EXAMS / MARKS";
            this.btn_exam.UseVisualStyleBackColor = true;
            this.btn_exam.Click += new System.EventHandler(this.btn_exam_Click);
            // 
            // btn_timetable
            // 
            this.btn_timetable.Location = new System.Drawing.Point(0, 235);
            this.btn_timetable.Name = "btn_timetable";
            this.btn_timetable.Size = new System.Drawing.Size(105, 56);
            this.btn_timetable.TabIndex = 6;
            this.btn_timetable.Text = "TIME TABLES";
            this.btn_timetable.UseVisualStyleBackColor = true;
            this.btn_timetable.Click += new System.EventHandler(this.btn_timetable_Click);
            // 
            // btn_attendance
            // 
            this.btn_attendance.Location = new System.Drawing.Point(0, 111);
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
            // btn_persondetails
            // 
            this.btn_persondetails.Location = new System.Drawing.Point(0, 49);
            this.btn_persondetails.Name = "btn_persondetails";
            this.btn_persondetails.Size = new System.Drawing.Size(105, 56);
            this.btn_persondetails.TabIndex = 0;
            this.btn_persondetails.Text = "PERSON DETAILS";
            this.btn_persondetails.UseVisualStyleBackColor = true;
            this.btn_persondetails.Click += new System.EventHandler(this.button1_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerPanel.Location = new System.Drawing.Point(111, 40);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(889, 610);
            this.centerPanel.TabIndex = 1;
            this.centerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // UpPanel
            // 
            this.UpPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpPanel.Controls.Add(this.ilabel_icon);
            this.UpPanel.Controls.Add(this.label_welcome);
            this.UpPanel.Controls.Add(this.btn_addexam);
            this.UpPanel.Controls.Add(this.btn_addtimeslot);
            this.UpPanel.Controls.Add(this.btn_addcourse);
            this.UpPanel.Controls.Add(this.btn_add_person);
            this.UpPanel.Controls.Add(this.linkLabel_logout);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(111, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(889, 40);
            this.UpPanel.TabIndex = 2;
            // 
            // ilabel_icon
            // 
            this.ilabel_icon.AutoSize = true;
            this.ilabel_icon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilabel_icon.Location = new System.Drawing.Point(836, -1);
            this.ilabel_icon.Name = "ilabel_icon";
            this.ilabel_icon.Size = new System.Drawing.Size(35, 29);
            this.ilabel_icon.TabIndex = 7;
            this.ilabel_icon.Text = "👩‍🎓";
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.Location = new System.Drawing.Point(588, 0);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(72, 16);
            this.label_welcome.TabIndex = 5;
            this.label_welcome.Text = "Welcome";
            // 
            // btn_addexam
            // 
            this.btn_addexam.Location = new System.Drawing.Point(177, 3);
            this.btn_addexam.Name = "btn_addexam";
            this.btn_addexam.Size = new System.Drawing.Size(85, 37);
            this.btn_addexam.TabIndex = 3;
            this.btn_addexam.Text = "ADD AN EXAM";
            this.btn_addexam.UseVisualStyleBackColor = true;
            this.btn_addexam.Click += new System.EventHandler(this.btn_addexam_Click);
            // 
            // btn_addtimeslot
            // 
            this.btn_addtimeslot.Location = new System.Drawing.Point(268, 3);
            this.btn_addtimeslot.Name = "btn_addtimeslot";
            this.btn_addtimeslot.Size = new System.Drawing.Size(85, 37);
            this.btn_addtimeslot.TabIndex = 2;
            this.btn_addtimeslot.Text = "ADD A SCHEDULE";
            this.btn_addtimeslot.UseVisualStyleBackColor = true;
            this.btn_addtimeslot.Click += new System.EventHandler(this.btn_addtimeslot_Click);
            // 
            // btn_addcourse
            // 
            this.btn_addcourse.Location = new System.Drawing.Point(86, 2);
            this.btn_addcourse.Name = "btn_addcourse";
            this.btn_addcourse.Size = new System.Drawing.Size(85, 37);
            this.btn_addcourse.TabIndex = 1;
            this.btn_addcourse.Text = "ADD A COURSE";
            this.btn_addcourse.UseVisualStyleBackColor = true;
            this.btn_addcourse.Click += new System.EventHandler(this.btn_addcourse_Click);
            // 
            // btn_add_person
            // 
            this.btn_add_person.Location = new System.Drawing.Point(0, 2);
            this.btn_add_person.Name = "btn_add_person";
            this.btn_add_person.Size = new System.Drawing.Size(80, 37);
            this.btn_add_person.TabIndex = 0;
            this.btn_add_person.Text = "ADD A PERSON";
            this.btn_add_person.UseVisualStyleBackColor = true;
            this.btn_add_person.Click += new System.EventHandler(this.btn_add_person_Click);
            // 
            // linkLabel_logout
            // 
            this.linkLabel_logout.AutoSize = true;
            this.linkLabel_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_logout.Location = new System.Drawing.Point(828, 23);
            this.linkLabel_logout.Name = "linkLabel_logout";
            this.linkLabel_logout.Size = new System.Drawing.Size(54, 16);
            this.linkLabel_logout.TabIndex = 8;
            this.linkLabel_logout.TabStop = true;
            this.linkLabel_logout.Text = "Logout";
            this.linkLabel_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_logout_LinkClicked);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.leftPanel.ResumeLayout(false);
            this.UpPanel.ResumeLayout(false);
            this.UpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Button btn_course;
        private System.Windows.Forms.Button btn_persondetails;
        private System.Windows.Forms.Button btn_add_person;
        private System.Windows.Forms.Button btn_exam;
        private System.Windows.Forms.Button btn_timetable;
        private System.Windows.Forms.Button btn_addcourse;
        private System.Windows.Forms.Button btn_addexam;
        private System.Windows.Forms.Button btn_addtimeslot;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Label ilabel_icon;
        private System.Windows.Forms.LinkLabel linkLabel_logout;
    }
}