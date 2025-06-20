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
            ((System.ComponentModel.ISupportInitialize)(this.dtg_course)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COURSE NAME";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(125, 66);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_course
            // 
            this.tb_course.Location = new System.Drawing.Point(125, 28);
            this.tb_course.Name = "tb_course";
            this.tb_course.Size = new System.Drawing.Size(100, 20);
            this.tb_course.TabIndex = 2;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(125, 108);
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
            this.dtg_course.Location = new System.Drawing.Point(257, -1);
            this.dtg_course.MultiSelect = false;
            this.dtg_course.Name = "dtg_course";
            this.dtg_course.ReadOnly = true;
            this.dtg_course.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_course.Size = new System.Drawing.Size(350, 322);
            this.dtg_course.TabIndex = 4;
            // 
            // CourseSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 322);
            this.Controls.Add(this.dtg_course);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.tb_course);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Name = "CourseSubject";
            this.Text = "CourseSubject";
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
    }
}