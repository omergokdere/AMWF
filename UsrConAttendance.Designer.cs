namespace Attendance_Monitoring_With_Fingerprint
{
    partial class UsrConAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsrConAttendance));
            this.lv_User = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tm_FingerprintSensor = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.datePick_Attendance = new System.Windows.Forms.DateTimePicker();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_User
            // 
            this.lv_User.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_User.BackColor = System.Drawing.Color.White;
            this.lv_User.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5});
            this.lv_User.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_User.ForeColor = System.Drawing.Color.Gray;
            this.lv_User.FullRowSelect = true;
            this.lv_User.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_User.HideSelection = false;
            this.lv_User.LabelWrap = false;
            this.lv_User.Location = new System.Drawing.Point(0, 54);
            this.lv_User.Margin = new System.Windows.Forms.Padding(4);
            this.lv_User.Name = "lv_User";
            this.lv_User.Size = new System.Drawing.Size(1196, 681);
            this.lv_User.TabIndex = 218;
            this.lv_User.UseCompatibleStateImageBehavior = false;
            this.lv_User.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Student ID";
            this.columnHeader6.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 277;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Desgination";
            this.columnHeader4.Width = 190;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time-In";
            this.columnHeader3.Width = 119;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Time-Out";
            this.columnHeader5.Width = 119;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 221;
            this.button1.Text = "simulate1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 222;
            this.button2.Text = "simulate2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 14);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 223;
            this.button3.Text = "simulate3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tm_FingerprintSensor
            // 
            this.tm_FingerprintSensor.Interval = 500;
            this.tm_FingerprintSensor.Tick += new System.EventHandler(this.tm_FingerprintSensor_Tick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(406, 15);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 224;
            this.button4.Text = "simulate not found";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // datePick_Attendance
            // 
            this.datePick_Attendance.CalendarForeColor = System.Drawing.Color.Gray;
            this.datePick_Attendance.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.datePick_Attendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datePick_Attendance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePick_Attendance.Location = new System.Drawing.Point(870, 12);
            this.datePick_Attendance.Margin = new System.Windows.Forms.Padding(4);
            this.datePick_Attendance.Name = "datePick_Attendance";
            this.datePick_Attendance.Size = new System.Drawing.Size(311, 27);
            this.datePick_Attendance.TabIndex = 225;
            this.datePick_Attendance.ValueChanged += new System.EventHandler(this.datePick_Attendance_ValueChanged);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Back.Location = new System.Drawing.Point(9, 7);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(55, 41);
            this.btn_Back.TabIndex = 220;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // UsrConAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.datePick_Attendance);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lv_User);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsrConAttendance";
            this.Size = new System.Drawing.Size(1197, 736);
            this.Load += new System.EventHandler(this.UsrConAttendance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView lv_User;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.DateTimePicker datePick_Attendance;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.Timer tm_FingerprintSensor;
    }
}
