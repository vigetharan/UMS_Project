namespace UnicomTICManagementSystem.Views
{
    partial class Student_Form
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tb_utno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_contactno = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_course = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.tb_nic = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UT Number";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(112, 369);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // tb_utno
            // 
            this.tb_utno.Location = new System.Drawing.Point(179, 32);
            this.tb_utno.Name = "tb_utno";
            this.tb_utno.Size = new System.Drawing.Size(279, 20);
            this.tb_utno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FULL NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ADDRESS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "EMAIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "CONTACT NUMBER";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(179, 101);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(279, 20);
            this.tb_name.TabIndex = 7;
            this.tb_name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(179, 134);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(279, 20);
            this.tb_address.TabIndex = 8;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(179, 176);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(279, 20);
            this.tb_email.TabIndex = 9;
            // 
            // tb_contactno
            // 
            this.tb_contactno.Location = new System.Drawing.Point(179, 216);
            this.tb_contactno.Name = "tb_contactno";
            this.tb_contactno.Size = new System.Drawing.Size(279, 20);
            this.tb_contactno.TabIndex = 10;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(225, 369);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(347, 369);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "USERNAME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "PASSWORD";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(179, 250);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(279, 20);
            this.tb_username.TabIndex = 15;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(179, 292);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "COURSE";
            // 
            // combo_course
            // 
            this.combo_course.FormattingEnabled = true;
            this.combo_course.Location = new System.Drawing.Point(179, 332);
            this.combo_course.Name = "combo_course";
            this.combo_course.Size = new System.Drawing.Size(121, 21);
            this.combo_course.TabIndex = 18;
            this.combo_course.SelectedIndexChanged += new System.EventHandler(this.combo_course_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "NIC NUMBER";
            // 
            // tb_nic
            // 
            this.tb_nic.Location = new System.Drawing.Point(179, 66);
            this.tb_nic.Name = "tb_nic";
            this.tb_nic.Size = new System.Drawing.Size(279, 20);
            this.tb_nic.TabIndex = 20;
            // 
            // Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_nic);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo_course);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.tb_contactno);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_utno);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label1);
            this.Name = "Student_Form";
            this.Text = "Student_Form";
            this.Load += new System.EventHandler(this.Student_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox tb_utno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_contactno;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_course;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_nic;
    }
}