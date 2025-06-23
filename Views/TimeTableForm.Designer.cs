namespace UnicomTICManagementSystem.Views
{
    partial class TimeTableForm
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
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add_timeslot = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_timeslot = new System.Windows.Forms.ComboBox();
            this.cb_room = new System.Windows.Forms.ComboBox();
            this.cb_course = new System.Windows.Forms.ComboBox();
            this.cb_subject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_lecturer = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_room = new System.Windows.Forms.Label();
            this.tb_room = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label_room_error = new System.Windows.Forms.Label();
            this.label_Exam = new System.Windows.Forms.Label();
            this.cb_exam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIME SLOTS";
            // 
            // dtp_start
            // 
            this.dtp_start.CalendarFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_start.Location = new System.Drawing.Point(115, 30);
            this.dtp_start.MinDate = new System.DateTime(2025, 6, 18, 0, 0, 0, 0);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(200, 20);
            this.dtp_start.TabIndex = 1;
            // 
            // dtp_end
            // 
            this.dtp_end.CalendarFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_end.Location = new System.Drawing.Point(424, 29);
            this.dtp_end.MinDate = new System.DateTime(2025, 6, 18, 0, 0, 0, 0);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(200, 20);
            this.dtp_end.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "STARTS AT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ENDS AT";
            // 
            // btn_add_timeslot
            // 
            this.btn_add_timeslot.Location = new System.Drawing.Point(664, 25);
            this.btn_add_timeslot.Name = "btn_add_timeslot";
            this.btn_add_timeslot.Size = new System.Drawing.Size(111, 23);
            this.btn_add_timeslot.TabIndex = 5;
            this.btn_add_timeslot.Text = "ADD TIMESLOT";
            this.btn_add_timeslot.UseVisualStyleBackColor = true;
            this.btn_add_timeslot.Click += new System.EventHandler(this.btn_add_timeslot_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-4, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ADD SCHEDULES";
            // 
            // cb_timeslot
            // 
            this.cb_timeslot.FormattingEnabled = true;
            this.cb_timeslot.Location = new System.Drawing.Point(103, 199);
            this.cb_timeslot.Name = "cb_timeslot";
            this.cb_timeslot.Size = new System.Drawing.Size(121, 21);
            this.cb_timeslot.TabIndex = 7;
            // 
            // cb_room
            // 
            this.cb_room.FormattingEnabled = true;
            this.cb_room.Location = new System.Drawing.Point(103, 310);
            this.cb_room.Name = "cb_room";
            this.cb_room.Size = new System.Drawing.Size(121, 21);
            this.cb_room.TabIndex = 8;
            // 
            // cb_course
            // 
            this.cb_course.FormattingEnabled = true;
            this.cb_course.Location = new System.Drawing.Point(103, 276);
            this.cb_course.Name = "cb_course";
            this.cb_course.Size = new System.Drawing.Size(121, 21);
            this.cb_course.TabIndex = 9;
            this.cb_course.SelectedIndexChanged += new System.EventHandler(this.cb_group_SelectedIndexChanged);
            // 
            // cb_subject
            // 
            this.cb_subject.FormattingEnabled = true;
            this.cb_subject.Location = new System.Drawing.Point(103, 345);
            this.cb_subject.Name = "cb_subject";
            this.cb_subject.Size = new System.Drawing.Size(121, 21);
            this.cb_subject.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "TIME SLOT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "VENUE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "SUBJECTS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "COURSE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "LECTURER";
            // 
            // cb_lecturer
            // 
            this.cb_lecturer.FormattingEnabled = true;
            this.cb_lecturer.Location = new System.Drawing.Point(103, 377);
            this.cb_lecturer.Name = "cb_lecturer";
            this.cb_lecturer.Size = new System.Drawing.Size(121, 21);
            this.cb_lecturer.TabIndex = 15;
            this.cb_lecturer.SelectedIndexChanged += new System.EventHandler(this.cb_lecturer_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "TYPE";
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(103, 237);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(121, 21);
            this.cb_type.TabIndex = 17;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "ADD SCHEDULE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(256, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 454);
            this.dataGridView1.TabIndex = 20;
            // 
            // label_room
            // 
            this.label_room.AutoSize = true;
            this.label_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_room.Location = new System.Drawing.Point(-4, 63);
            this.label_room.Name = "label_room";
            this.label_room.Size = new System.Drawing.Size(74, 20);
            this.label_room.TabIndex = 21;
            this.label_room.Text = "ROOMS";
            // 
            // tb_room
            // 
            this.tb_room.Location = new System.Drawing.Point(115, 62);
            this.tb_room.Name = "tb_room";
            this.tb_room.Size = new System.Drawing.Size(200, 20);
            this.tb_room.TabIndex = 22;
            this.tb_room.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(321, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "ADD A ROOM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_room_error
            // 
            this.label_room_error.AutoSize = true;
            this.label_room_error.Location = new System.Drawing.Point(112, 85);
            this.label_room_error.Name = "label_room_error";
            this.label_room_error.Size = new System.Drawing.Size(54, 13);
            this.label_room_error.TabIndex = 24;
            this.label_room_error.Text = "room error";
            this.label_room_error.Visible = false;
            // 
            // label_Exam
            // 
            this.label_Exam.AutoSize = true;
            this.label_Exam.Location = new System.Drawing.Point(33, 415);
            this.label_Exam.Name = "label_Exam";
            this.label_Exam.Size = new System.Drawing.Size(37, 13);
            this.label_Exam.TabIndex = 28;
            this.label_Exam.Text = "EXAM";
            // 
            // cb_exam
            // 
            this.cb_exam.FormattingEnabled = true;
            this.cb_exam.Location = new System.Drawing.Point(103, 411);
            this.cb_exam.Name = "cb_exam";
            this.cb_exam.Size = new System.Drawing.Size(121, 21);
            this.cb_exam.TabIndex = 27;
            // 
            // TimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(937, 572);
            this.Controls.Add(this.label_Exam);
            this.Controls.Add(this.cb_exam);
            this.Controls.Add(this.label_room_error);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_room);
            this.Controls.Add(this.label_room);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_lecturer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_subject);
            this.Controls.Add(this.cb_course);
            this.Controls.Add(this.cb_room);
            this.Controls.Add(this.cb_timeslot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_add_timeslot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.label1);
            this.Name = "TimeTableForm";
            this.Text = "TimeTable";
            this.Load += new System.EventHandler(this.TimeTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add_timeslot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_timeslot;
        private System.Windows.Forms.ComboBox cb_room;
        private System.Windows.Forms.ComboBox cb_course;
        private System.Windows.Forms.ComboBox cb_subject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_lecturer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_room;
        private System.Windows.Forms.TextBox tb_room;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_room_error;
        private System.Windows.Forms.Label label_Exam;
        private System.Windows.Forms.ComboBox cb_exam;
    }
}