namespace UnicomTICManagementSystem.Views
{
    partial class Marks_Form
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
            this.cb_student = new System.Windows.Forms.ComboBox();
            this.cb_exam = new System.Windows.Forms.ComboBox();
            this.tb_marks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addmarks = new System.Windows.Forms.Button();
            this.cb_course = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_student
            // 
            this.cb_student.FormattingEnabled = true;
            this.cb_student.Location = new System.Drawing.Point(190, 47);
            this.cb_student.Name = "cb_student";
            this.cb_student.Size = new System.Drawing.Size(121, 21);
            this.cb_student.TabIndex = 0;
            this.cb_student.SelectedIndexChanged += new System.EventHandler(this.cb_student_SelectedIndexChanged);
            // 
            // cb_exam
            // 
            this.cb_exam.FormattingEnabled = true;
            this.cb_exam.Location = new System.Drawing.Point(353, 47);
            this.cb_exam.Name = "cb_exam";
            this.cb_exam.Size = new System.Drawing.Size(121, 21);
            this.cb_exam.TabIndex = 1;
            // 
            // tb_marks
            // 
            this.tb_marks.Location = new System.Drawing.Point(518, 47);
            this.tb_marks.Name = "tb_marks";
            this.tb_marks.Size = new System.Drawing.Size(100, 20);
            this.tb_marks.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "STUDENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "EXAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "MARKS OPTAINED";
            // 
            // btn_addmarks
            // 
            this.btn_addmarks.Location = new System.Drawing.Point(667, 44);
            this.btn_addmarks.Name = "btn_addmarks";
            this.btn_addmarks.Size = new System.Drawing.Size(103, 23);
            this.btn_addmarks.TabIndex = 6;
            this.btn_addmarks.Text = "ADD MARKS";
            this.btn_addmarks.UseVisualStyleBackColor = true;
            // 
            // cb_course
            // 
            this.cb_course.FormattingEnabled = true;
            this.cb_course.Location = new System.Drawing.Point(32, 47);
            this.cb_course.Name = "cb_course";
            this.cb_course.Size = new System.Drawing.Size(121, 21);
            this.cb_course.TabIndex = 7;
            this.cb_course.SelectedIndexChanged += new System.EventHandler(this.cb_course_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "COURSE";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(187, 73);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(33, 13);
            this.label_name.TabIndex = 9;
            this.label_name.Text = "name";
            this.label_name.Visible = false;
            // 
            // Marks_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_course);
            this.Controls.Add(this.btn_addmarks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_marks);
            this.Controls.Add(this.cb_exam);
            this.Controls.Add(this.cb_student);
            this.Name = "Marks_Form";
            this.Text = "Marks_Form";
            this.Load += new System.EventHandler(this.Marks_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_student;
        private System.Windows.Forms.ComboBox cb_exam;
        private System.Windows.Forms.TextBox tb_marks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addmarks;
        private System.Windows.Forms.ComboBox cb_course;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_name;
    }
}