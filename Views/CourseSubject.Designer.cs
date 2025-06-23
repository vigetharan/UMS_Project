namespace UnicomTICManagementSystem.Views
{
    partial class CourseSubject
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_course = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dtg_course = new System.Windows.Forms.DataGridView();
            this.btn_delete_subject = new System.Windows.Forms.Button();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.btn_add_subject = new System.Windows.Forms.Button();
            this.label_subject = new System.Windows.Forms.Label();
            this.cb_course = new System.Windows.Forms.ComboBox();
            this.cb_lecturer = new System.Windows.Forms.ComboBox();
            this.label_course_combo = new System.Windows.Forms.Label();
            this.label_lecturer = new System.Windows.Forms.Label();
            this.label_line = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_course)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COURSE NAME";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(256, 83);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_course
            // 
            this.tb_course.Location = new System.Drawing.Point(125, 85);
            this.tb_course.Name = "tb_course";
            this.tb_course.Size = new System.Drawing.Size(100, 20);
            this.tb_course.TabIndex = 2;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(256, 112);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dtg_course
            // 
            this.dtg_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_course.Location = new System.Drawing.Point(346, 2);
            this.dtg_course.MultiSelect = false;
            this.dtg_course.Name = "dtg_course";
            this.dtg_course.ReadOnly = true;
            this.dtg_course.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_course.Size = new System.Drawing.Size(429, 472);
            this.dtg_course.TabIndex = 4;
            // 
            // btn_delete_subject
            // 
            this.btn_delete_subject.Location = new System.Drawing.Point(256, 319);
            this.btn_delete_subject.Name = "btn_delete_subject";
            this.btn_delete_subject.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_subject.TabIndex = 8;
            this.btn_delete_subject.Text = "DELETE";
            this.btn_delete_subject.UseVisualStyleBackColor = true;
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(125, 244);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(100, 20);
            this.tb_subject.TabIndex = 7;
            // 
            // btn_add_subject
            // 
            this.btn_add_subject.Location = new System.Drawing.Point(256, 242);
            this.btn_add_subject.Name = "btn_add_subject";
            this.btn_add_subject.Size = new System.Drawing.Size(75, 23);
            this.btn_add_subject.TabIndex = 6;
            this.btn_add_subject.Text = "ADD";
            this.btn_add_subject.UseVisualStyleBackColor = true;
            this.btn_add_subject.Click += new System.EventHandler(this.btn_add_subject_Click);
            // 
            // label_subject
            // 
            this.label_subject.AutoSize = true;
            this.label_subject.Location = new System.Drawing.Point(12, 247);
            this.label_subject.Name = "label_subject";
            this.label_subject.Size = new System.Drawing.Size(89, 13);
            this.label_subject.TabIndex = 5;
            this.label_subject.Text = "SUBJECT NAME";
            // 
            // cb_course
            // 
            this.cb_course.FormattingEnabled = true;
            this.cb_course.Location = new System.Drawing.Point(125, 285);
            this.cb_course.Name = "cb_course";
            this.cb_course.Size = new System.Drawing.Size(121, 21);
            this.cb_course.TabIndex = 10;
            // 
            // cb_lecturer
            // 
            this.cb_lecturer.FormattingEnabled = true;
            this.cb_lecturer.Location = new System.Drawing.Point(125, 324);
            this.cb_lecturer.Name = "cb_lecturer";
            this.cb_lecturer.Size = new System.Drawing.Size(121, 21);
            this.cb_lecturer.TabIndex = 11;
            // 
            // label_course_combo
            // 
            this.label_course_combo.AutoSize = true;
            this.label_course_combo.Location = new System.Drawing.Point(12, 288);
            this.label_course_combo.Name = "label_course_combo";
            this.label_course_combo.Size = new System.Drawing.Size(52, 13);
            this.label_course_combo.TabIndex = 12;
            this.label_course_combo.Text = "COURSE";
            // 
            // label_lecturer
            // 
            this.label_lecturer.AutoSize = true;
            this.label_lecturer.Location = new System.Drawing.Point(12, 329);
            this.label_lecturer.Name = "label_lecturer";
            this.label_lecturer.Size = new System.Drawing.Size(82, 13);
            this.label_lecturer.TabIndex = 13;
            this.label_lecturer.Text = "BY LECTURER";
            // 
            // label_line
            // 
            this.label_line.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_line.Location = new System.Drawing.Point(11, 199);
            this.label_line.Name = "label_line";
            this.label_line.Size = new System.Drawing.Size(180, 30);
            this.label_line.TabIndex = 14;
            this.label_line.Text = "SUBJECTS";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "COURSES";
            // 
            // CourseSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(776, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_line);
            this.Controls.Add(this.label_lecturer);
            this.Controls.Add(this.label_course_combo);
            this.Controls.Add(this.cb_lecturer);
            this.Controls.Add(this.cb_course);
            this.Controls.Add(this.btn_delete_subject);
            this.Controls.Add(this.tb_subject);
            this.Controls.Add(this.btn_add_subject);
            this.Controls.Add(this.label_subject);
            this.Controls.Add(this.dtg_course);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.tb_course);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Name = "CourseSubject";
            this.Text = "COURSES AND SUBJECTS";
            this.Load += new System.EventHandler(this.CourseSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_course;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dtg_course;
        private System.Windows.Forms.Button btn_delete_subject;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.Button btn_add_subject;
        private System.Windows.Forms.Label label_subject;
        private System.Windows.Forms.ComboBox cb_course;
        private System.Windows.Forms.ComboBox cb_lecturer;
        private System.Windows.Forms.Label label_course_combo;
        private System.Windows.Forms.Label label_lecturer;
        private System.Windows.Forms.Label label_line;
        private System.Windows.Forms.Label label2;
    }
}