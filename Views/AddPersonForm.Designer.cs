namespace UnicomTICManagementSystem.Views
{
    partial class AddPersonForm
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
            this.label_utno = new System.Windows.Forms.Label();
            this.tb_utno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_contactno = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label_course = new System.Windows.Forms.Label();
            this.cb_course = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.tb_nic = new System.Windows.Forms.TextBox();
            this.error_utno = new System.Windows.Forms.Label();
            this.error_nic = new System.Windows.Forms.Label();
            this.error_name = new System.Windows.Forms.Label();
            this.error_address = new System.Windows.Forms.Label();
            this.error_email = new System.Windows.Forms.Label();
            this.error_username = new System.Windows.Forms.Label();
            this.error_pw = new System.Windows.Forms.Label();
            this.error_course = new System.Windows.Forms.Label();
            this.error_contactno = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.cb_authentication = new System.Windows.Forms.CheckBox();
            this.tb_dob = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.error_dob = new System.Windows.Forms.Label();
            this.error_group = new System.Windows.Forms.Label();
            this.error_gender = new System.Windows.Forms.Label();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_datejoined = new System.Windows.Forms.Label();
            this.dtp_datejoined = new System.Windows.Forms.DateTimePicker();
            this.lable_parent = new System.Windows.Forms.Label();
            this.tb_parent = new System.Windows.Forms.TextBox();
            this.label_employeno = new System.Windows.Forms.Label();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.label_salary = new System.Windows.Forms.Label();
            this.error_parent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_utno
            // 
            this.label_utno.AutoSize = true;
            this.label_utno.Location = new System.Drawing.Point(588, 75);
            this.label_utno.Name = "label_utno";
            this.label_utno.Size = new System.Drawing.Size(72, 13);
            this.label_utno.TabIndex = 36;
            this.label_utno.Text = "UT NUMBER";
            this.label_utno.Visible = false;
            // 
            // tb_utno
            // 
            this.tb_utno.Location = new System.Drawing.Point(678, 71);
            this.tb_utno.Name = "tb_utno";
            this.tb_utno.Size = new System.Drawing.Size(121, 20);
            this.tb_utno.TabIndex = 1;
            this.tb_utno.Text = "UT";
            this.tb_utno.Visible = false;
            this.tb_utno.Enter += new System.EventHandler(this.tb_utno_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "FULL NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "ADDRESS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "EMAIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "CONTACT No.";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(179, 54);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(279, 20);
            this.tb_name.TabIndex = 2;
            this.tb_name.Leave += new System.EventHandler(this.tb_name_Leave);
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(179, 103);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(279, 20);
            this.tb_address.TabIndex = 3;
            this.tb_address.TextChanged += new System.EventHandler(this.tb_address_TextChanged);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(179, 145);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(279, 20);
            this.tb_email.TabIndex = 4;
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // tb_contactno
            // 
            this.tb_contactno.Location = new System.Drawing.Point(179, 185);
            this.tb_contactno.Name = "tb_contactno";
            this.tb_contactno.Size = new System.Drawing.Size(279, 20);
            this.tb_contactno.TabIndex = 5;
            this.tb_contactno.Leave += new System.EventHandler(this.tb_contactno_Leave);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(678, 556);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(44, 392);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(68, 13);
            this.label_username.TabIndex = 31;
            this.label_username.Text = "USERNAME";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(44, 432);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(70, 13);
            this.label_password.TabIndex = 30;
            this.label_password.Text = "PASSWORD";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(179, 389);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(279, 20);
            this.tb_username.TabIndex = 7;
            this.tb_username.Leave += new System.EventHandler(this.tb_username_Leave);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(179, 429);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(279, 20);
            this.tb_password.TabIndex = 8;
            this.tb_password.Leave += new System.EventHandler(this.tb_password_Leave);
            // 
            // label_course
            // 
            this.label_course.AutoSize = true;
            this.label_course.Location = new System.Drawing.Point(588, 168);
            this.label_course.Name = "label_course";
            this.label_course.Size = new System.Drawing.Size(52, 13);
            this.label_course.TabIndex = 17;
            this.label_course.Text = "COURSE";
            this.label_course.Visible = false;
            // 
            // cb_course
            // 
            this.cb_course.FormattingEnabled = true;
            this.cb_course.Location = new System.Drawing.Point(678, 165);
            this.cb_course.Name = "cb_course";
            this.cb_course.Size = new System.Drawing.Size(121, 21);
            this.cb_course.TabIndex = 9;
            this.cb_course.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "NIC NUMBER";
            // 
            // tb_nic
            // 
            this.tb_nic.Location = new System.Drawing.Point(179, 7);
            this.tb_nic.Name = "tb_nic";
            this.tb_nic.Size = new System.Drawing.Size(279, 20);
            this.tb_nic.TabIndex = 1;
            this.tb_nic.Leave += new System.EventHandler(this.tb_nic_Leave);
            // 
            // error_utno
            // 
            this.error_utno.AutoSize = true;
            this.error_utno.Location = new System.Drawing.Point(680, 94);
            this.error_utno.Name = "error_utno";
            this.error_utno.Size = new System.Drawing.Size(195, 13);
            this.error_utno.TabIndex = 21;
            this.error_utno.Text = "UT Number must format of \"UT010043\"";
            this.error_utno.Visible = false;
            // 
            // error_nic
            // 
            this.error_nic.AutoSize = true;
            this.error_nic.Location = new System.Drawing.Point(182, 32);
            this.error_nic.Name = "error_nic";
            this.error_nic.Size = new System.Drawing.Size(41, 13);
            this.error_nic.TabIndex = 22;
            this.error_nic.Text = "label11";
            this.error_nic.Visible = false;
            // 
            // error_name
            // 
            this.error_name.AutoSize = true;
            this.error_name.Location = new System.Drawing.Point(182, 77);
            this.error_name.Name = "error_name";
            this.error_name.Size = new System.Drawing.Size(41, 13);
            this.error_name.TabIndex = 23;
            this.error_name.Text = "label12";
            this.error_name.Visible = false;
            // 
            // error_address
            // 
            this.error_address.AutoSize = true;
            this.error_address.Location = new System.Drawing.Point(182, 126);
            this.error_address.Name = "error_address";
            this.error_address.Size = new System.Drawing.Size(41, 13);
            this.error_address.TabIndex = 24;
            this.error_address.Text = "label13";
            this.error_address.Visible = false;
            // 
            // error_email
            // 
            this.error_email.AutoSize = true;
            this.error_email.Location = new System.Drawing.Point(182, 168);
            this.error_email.Name = "error_email";
            this.error_email.Size = new System.Drawing.Size(41, 13);
            this.error_email.TabIndex = 25;
            this.error_email.Text = "label14";
            this.error_email.Visible = false;
            // 
            // error_username
            // 
            this.error_username.AutoSize = true;
            this.error_username.Location = new System.Drawing.Point(182, 411);
            this.error_username.Name = "error_username";
            this.error_username.Size = new System.Drawing.Size(41, 13);
            this.error_username.TabIndex = 26;
            this.error_username.Text = "label15";
            this.error_username.Visible = false;
            // 
            // error_pw
            // 
            this.error_pw.AutoSize = true;
            this.error_pw.Location = new System.Drawing.Point(182, 452);
            this.error_pw.Name = "error_pw";
            this.error_pw.Size = new System.Drawing.Size(41, 13);
            this.error_pw.TabIndex = 27;
            this.error_pw.Text = "label16";
            this.error_pw.Visible = false;
            // 
            // error_course
            // 
            this.error_course.AutoSize = true;
            this.error_course.Location = new System.Drawing.Point(680, 186);
            this.error_course.Name = "error_course";
            this.error_course.Size = new System.Drawing.Size(155, 13);
            this.error_course.TabIndex = 28;
            this.error_course.Text = "Please select a valid COURSE.";
            this.error_course.Visible = false;
            // 
            // error_contactno
            // 
            this.error_contactno.AutoSize = true;
            this.error_contactno.Location = new System.Drawing.Point(182, 208);
            this.error_contactno.Name = "error_contactno";
            this.error_contactno.Size = new System.Drawing.Size(41, 13);
            this.error_contactno.TabIndex = 29;
            this.error_contactno.Text = "label15";
            this.error_contactno.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(112, 556);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // cb_authentication
            // 
            this.cb_authentication.AutoSize = true;
            this.cb_authentication.Location = new System.Drawing.Point(179, 350);
            this.cb_authentication.Name = "cb_authentication";
            this.cb_authentication.Size = new System.Drawing.Size(417, 17);
            this.cb_authentication.TabIndex = 37;
            this.cb_authentication.Text = " Skip Register for Login (Enable this option to skip username password registrati" +
    "on.)";
            this.cb_authentication.UseVisualStyleBackColor = true;
            this.cb_authentication.CheckedChanged += new System.EventHandler(this.cb_authentication_CheckedChanged);
            // 
            // tb_dob
            // 
            this.tb_dob.Location = new System.Drawing.Point(179, 228);
            this.tb_dob.Name = "tb_dob";
            this.tb_dob.Size = new System.Drawing.Size(279, 20);
            this.tb_dob.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "DATE OF BIRTH";
            // 
            // error_dob
            // 
            this.error_dob.AutoSize = true;
            this.error_dob.Location = new System.Drawing.Point(182, 251);
            this.error_dob.Name = "error_dob";
            this.error_dob.Size = new System.Drawing.Size(41, 13);
            this.error_dob.TabIndex = 42;
            this.error_dob.Text = "label16";
            this.error_dob.Visible = false;
            // 
            // error_group
            // 
            this.error_group.AutoSize = true;
            this.error_group.Location = new System.Drawing.Point(680, 144);
            this.error_group.Name = "error_group";
            this.error_group.Size = new System.Drawing.Size(149, 13);
            this.error_group.TabIndex = 43;
            this.error_group.Text = "Please select a valid GROUP.";
            this.error_group.Visible = false;
            // 
            // error_gender
            // 
            this.error_gender.AutoSize = true;
            this.error_gender.Location = new System.Drawing.Point(321, 271);
            this.error_gender.Name = "error_gender";
            this.error_gender.Size = new System.Drawing.Size(156, 13);
            this.error_gender.TabIndex = 46;
            this.error_gender.Text = "Please select a valid GENDER.";
            this.error_gender.Visible = false;
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(179, 268);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(121, 21);
            this.cb_gender.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "GENDER";
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Location = new System.Drawing.Point(179, 315);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(121, 21);
            this.cb_role.TabIndex = 47;
            this.cb_role.SelectedIndexChanged += new System.EventHandler(this.cb_role_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "USER ROLE";
            // 
            // label_datejoined
            // 
            this.label_datejoined.AutoSize = true;
            this.label_datejoined.Location = new System.Drawing.Point(588, 10);
            this.label_datejoined.Name = "label_datejoined";
            this.label_datejoined.Size = new System.Drawing.Size(78, 13);
            this.label_datejoined.TabIndex = 49;
            this.label_datejoined.Text = "DATE JOINED";
            // 
            // dtp_datejoined
            // 
            this.dtp_datejoined.Location = new System.Drawing.Point(683, 7);
            this.dtp_datejoined.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtp_datejoined.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtp_datejoined.Name = "dtp_datejoined";
            this.dtp_datejoined.Size = new System.Drawing.Size(200, 20);
            this.dtp_datejoined.TabIndex = 50;
            this.dtp_datejoined.Value = new System.DateTime(2025, 6, 17, 0, 14, 48, 0);
            // 
            // lable_parent
            // 
            this.lable_parent.AutoSize = true;
            this.lable_parent.Location = new System.Drawing.Point(588, 243);
            this.lable_parent.Name = "lable_parent";
            this.lable_parent.Size = new System.Drawing.Size(58, 26);
            this.lable_parent.TabIndex = 51;
            this.lable_parent.Text = "PARENT\'s\r\nCONTACT";
            this.lable_parent.Visible = false;
            // 
            // tb_parent
            // 
            this.tb_parent.Location = new System.Drawing.Point(678, 243);
            this.tb_parent.Name = "tb_parent";
            this.tb_parent.Size = new System.Drawing.Size(205, 20);
            this.tb_parent.TabIndex = 52;
            this.tb_parent.Visible = false;
            this.tb_parent.TextChanged += new System.EventHandler(this.tb_parent_TextChanged);
            this.tb_parent.Enter += new System.EventHandler(this.tb_parent_Enter);
            // 
            // label_employeno
            // 
            this.label_employeno.AutoSize = true;
            this.label_employeno.Location = new System.Drawing.Point(588, 77);
            this.label_employeno.Name = "label_employeno";
            this.label_employeno.Size = new System.Drawing.Size(82, 13);
            this.label_employeno.TabIndex = 53;
            this.label_employeno.Text = "EMPLOYEE No";
            this.label_employeno.Visible = false;
            // 
            // tb_salary
            // 
            this.tb_salary.Location = new System.Drawing.Point(678, 119);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(120, 20);
            this.tb_salary.TabIndex = 54;
            this.tb_salary.Visible = false;
            this.tb_salary.Leave += new System.EventHandler(this.tb_salary_Leave);
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Location = new System.Drawing.Point(588, 122);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(49, 13);
            this.label_salary.TabIndex = 55;
            this.label_salary.Text = "SALARY";
            this.label_salary.Visible = false;
            // 
            // error_parent
            // 
            this.error_parent.AutoSize = true;
            this.error_parent.Location = new System.Drawing.Point(680, 276);
            this.error_parent.Name = "error_parent";
            this.error_parent.Size = new System.Drawing.Size(28, 13);
            this.error_parent.TabIndex = 56;
            this.error_parent.Text = "error";
            this.error_parent.Visible = false;
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.error_parent);
            this.Controls.Add(this.tb_salary);
            this.Controls.Add(this.label_salary);
            this.Controls.Add(this.label_employeno);
            this.Controls.Add(this.tb_parent);
            this.Controls.Add(this.lable_parent);
            this.Controls.Add(this.dtp_datejoined);
            this.Controls.Add(this.label_datejoined);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.error_gender);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.error_group);
            this.Controls.Add(this.error_dob);
            this.Controls.Add(this.tb_dob);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cb_authentication);
            this.Controls.Add(this.error_contactno);
            this.Controls.Add(this.error_course);
            this.Controls.Add(this.error_pw);
            this.Controls.Add(this.error_username);
            this.Controls.Add(this.error_email);
            this.Controls.Add(this.error_address);
            this.Controls.Add(this.error_name);
            this.Controls.Add(this.error_nic);
            this.Controls.Add(this.error_utno);
            this.Controls.Add(this.tb_nic);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_course);
            this.Controls.Add(this.label_course);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_contactno);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label_utno);
            this.Controls.Add(this.tb_utno);
            this.Name = "AddPersonForm";
            this.Text = "Student_Form";
            this.Load += new System.EventHandler(this.Student_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_utno;
        private System.Windows.Forms.TextBox tb_utno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_contactno;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label_course;
        private System.Windows.Forms.ComboBox cb_course;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_nic;
        private System.Windows.Forms.Label error_utno;
        private System.Windows.Forms.Label error_nic;
        private System.Windows.Forms.Label error_name;
        private System.Windows.Forms.Label error_address;
        private System.Windows.Forms.Label error_email;
        private System.Windows.Forms.Label error_username;
        private System.Windows.Forms.Label error_pw;
        private System.Windows.Forms.Label error_course;
        private System.Windows.Forms.Label error_contactno;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.CheckBox cb_authentication;
        private System.Windows.Forms.TextBox tb_dob;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label error_dob;
        private System.Windows.Forms.Label error_group;
        private System.Windows.Forms.Label error_gender;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_datejoined;
        private System.Windows.Forms.DateTimePicker dtp_datejoined;
        private System.Windows.Forms.Label lable_parent;
        private System.Windows.Forms.TextBox tb_parent;
        private System.Windows.Forms.Label label_employeno;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.Label error_parent;
    }
}