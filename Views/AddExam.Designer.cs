namespace UnicomTICManagementSystem.Views
{
    partial class AddExam
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
            this.tb_exam_name = new System.Windows.Forms.TextBox();
            this.cb_subject = new System.Windows.Forms.ComboBox();
            this.btn_add_exam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXAM NAME";
            // 
            // tb_exam_name
            // 
            this.tb_exam_name.Location = new System.Drawing.Point(69, 57);
            this.tb_exam_name.Name = "tb_exam_name";
            this.tb_exam_name.Size = new System.Drawing.Size(100, 20);
            this.tb_exam_name.TabIndex = 1;
            // 
            // cb_subject
            // 
            this.cb_subject.FormattingEnabled = true;
            this.cb_subject.Location = new System.Drawing.Point(204, 57);
            this.cb_subject.Name = "cb_subject";
            this.cb_subject.Size = new System.Drawing.Size(121, 21);
            this.cb_subject.TabIndex = 2;
            // 
            // btn_add_exam
            // 
            this.btn_add_exam.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_add_exam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add_exam.Location = new System.Drawing.Point(358, 86);
            this.btn_add_exam.Name = "btn_add_exam";
            this.btn_add_exam.Size = new System.Drawing.Size(75, 34);
            this.btn_add_exam.TabIndex = 3;
            this.btn_add_exam.Text = "ADD EXAM";
            this.btn_add_exam.UseVisualStyleBackColor = false;
            this.btn_add_exam.Click += new System.EventHandler(this.btn_add_exam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SUBJECT";
            // 
            // AddExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(505, 140);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_add_exam);
            this.Controls.Add(this.cb_subject);
            this.Controls.Add(this.tb_exam_name);
            this.Controls.Add(this.label1);
            this.Name = "AddExam";
            this.Text = "AddExam";
            this.Load += new System.EventHandler(this.AddExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_exam_name;
        private System.Windows.Forms.ComboBox cb_subject;
        private System.Windows.Forms.Button btn_add_exam;
        private System.Windows.Forms.Label label2;
    }
}