namespace Attendance_Monitoring_With_Fingerprint
{
    partial class UsrConMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsrConMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_PDF = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Attendance = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.txt_TabTitle = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.btn_Student = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.tm_DateTime = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_PDF);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_Attendance);
            this.panel2.Controls.Add(this.btn_Logout);
            this.panel2.Controls.Add(this.btn_Student);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 738);
            this.panel2.TabIndex = 2;
            // 
            // btn_PDF
            // 
            this.btn_PDF.BackColor = System.Drawing.Color.Transparent;
            this.btn_PDF.BackgroundImage = global::Attendance_Monitoring_With_Fingerprint.Properties.Resources.icon_pdf;
            this.btn_PDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PDF.FlatAppearance.BorderSize = 0;
            this.btn_PDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_PDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PDF.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PDF.ForeColor = System.Drawing.Color.Navy;
            this.btn_PDF.Location = new System.Drawing.Point(0, 315);
            this.btn_PDF.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PDF.Name = "btn_PDF";
            this.btn_PDF.Size = new System.Drawing.Size(191, 64);
            this.btn_PDF.TabIndex = 1008;
            this.btn_PDF.Text = "            PDF Report";
            this.btn_PDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PDF.UseVisualStyleBackColor = false;
            this.btn_PDF.Click += new System.EventHandler(this.btn_PDF_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(191, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 666);
            this.panel3.TabIndex = 3;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_Logout.BackgroundImage = global::Attendance_Monitoring_With_Fingerprint.Properties.Resources.icon_logout;
            this.btn_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Navy;
            this.btn_Logout.Location = new System.Drawing.Point(0, 675);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(191, 64);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "            Logout";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Time.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Time.Location = new System.Drawing.Point(4, 12);
            this.lbl_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(109, 21);
            this.lbl_Time.TabIndex = 1006;
            this.lbl_Time.Text = "12:30:15 AM";
            // 
            // panel_Main
            // 
            this.panel_Main.Location = new System.Drawing.Point(191, 95);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1009, 644);
            this.panel_Main.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lbl_Time);
            this.panel4.Controls.Add(this.btn_Minimize);
            this.panel4.Controls.Add(this.panel_Title);
            this.panel4.Controls.Add(this.btn_Close);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(191, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1009, 95);
            this.panel4.TabIndex = 4;
            // 
            // btn_Attendance
            // 
            this.btn_Attendance.BackColor = System.Drawing.Color.Transparent;
            this.btn_Attendance.BackgroundImage = global::Attendance_Monitoring_With_Fingerprint.Properties.Resources.icon_attendance;
            this.btn_Attendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Attendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Attendance.FlatAppearance.BorderSize = 0;
            this.btn_Attendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Attendance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Attendance.ForeColor = System.Drawing.Color.Navy;
            this.btn_Attendance.Location = new System.Drawing.Point(0, 243);
            this.btn_Attendance.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Attendance.Name = "btn_Attendance";
            this.btn_Attendance.Size = new System.Drawing.Size(191, 64);
            this.btn_Attendance.TabIndex = 1007;
            this.btn_Attendance.Text = "            Attendance";
            this.btn_Attendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Attendance.UseVisualStyleBackColor = false;
            this.btn_Attendance.Click += new System.EventHandler(this.btn_Attendance_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.Navy;
            this.btn_Minimize.Location = new System.Drawing.Point(953, 52);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(37, 34);
            this.btn_Minimize.TabIndex = 1019;
            this.btn_Minimize.Text = "▬";
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.White;
            this.panel_Title.Controls.Add(this.txt_TabTitle);
            this.panel_Title.Controls.Add(this.lbl_Date);
            this.panel_Title.ForeColor = System.Drawing.Color.White;
            this.panel_Title.Location = new System.Drawing.Point(0, 52);
            this.panel_Title.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(337, 43);
            this.panel_Title.TabIndex = 1018;
            // 
            // txt_TabTitle
            // 
            this.txt_TabTitle.BackColor = System.Drawing.Color.DimGray;
            this.txt_TabTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TabTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TabTitle.ForeColor = System.Drawing.Color.Navy;
            this.txt_TabTitle.Location = new System.Drawing.Point(0, 18);
            this.txt_TabTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TabTitle.Name = "txt_TabTitle";
            this.txt_TabTitle.ReadOnly = true;
            this.txt_TabTitle.Size = new System.Drawing.Size(329, 25);
            this.txt_TabTitle.TabIndex = 1000;
            this.txt_TabTitle.Text = "ATTENDANCE SYSTEM ";
            this.txt_TabTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Date.Location = new System.Drawing.Point(5, -4);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(146, 18);
            this.lbl_Date.TabIndex = 1007;
            this.lbl_Date.Text = "November 26, 1992";
            // 
            // btn_Student
            // 
            this.btn_Student.BackColor = System.Drawing.Color.Transparent;
            this.btn_Student.BackgroundImage = global::Attendance_Monitoring_With_Fingerprint.Properties.Resources.icon_student;
            this.btn_Student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Student.FlatAppearance.BorderSize = 0;
            this.btn_Student.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Student.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student.ForeColor = System.Drawing.Color.Navy;
            this.btn_Student.Location = new System.Drawing.Point(0, 181);
            this.btn_Student.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(191, 64);
            this.btn_Student.TabIndex = 5;
            this.btn_Student.Text = "            Students";
            this.btn_Student.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Student.UseVisualStyleBackColor = false;
            this.btn_Student.Click += new System.EventHandler(this.btn_Student_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Navy;
            this.btn_Close.Location = new System.Drawing.Point(953, 10);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(37, 34);
            this.btn_Close.TabIndex = 1016;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // tm_DateTime
            // 
            this.tm_DateTime.Interval = 1000;
            this.tm_DateTime.Tick += new System.EventHandler(this.tm_DateTime_Tick);
            // 
            // UsrConMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_Main);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsrConMain";
            this.Size = new System.Drawing.Size(1200, 738);
            this.Load += new System.EventHandler(this.UserConMain_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btn_Logout;
        public System.Windows.Forms.Button btn_Student;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel_Title;
        public System.Windows.Forms.TextBox txt_TabTitle;
        public System.Windows.Forms.Button btn_Close;
        public System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.Label lbl_Time;
        public System.Windows.Forms.Timer tm_DateTime;
        public System.Windows.Forms.Button btn_Minimize;
        public System.Windows.Forms.Button btn_Attendance;
        public System.Windows.Forms.Button btn_PDF;
    }
}
