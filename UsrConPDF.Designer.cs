namespace Attendance_Monitoring_With_Fingerprint
{
    partial class UsrConPDF
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_Dash = new System.Windows.Forms.Label();
            this.datePick_To = new System.Windows.Forms.DateTimePicker();
            this.datePick_From = new System.Windows.Forms.DateTimePicker();
            this.combo_MonthDistance = new System.Windows.Forms.ComboBox();
            this.combo_Filter = new System.Windows.Forms.ComboBox();
            this.lv_User = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_GeneratePDF = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_Search.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.panel_Search);
            this.panel1.Controls.Add(this.lbl_Dash);
            this.panel1.Controls.Add(this.datePick_To);
            this.panel1.Controls.Add(this.datePick_From);
            this.panel1.Controls.Add(this.combo_MonthDistance);
            this.panel1.Controls.Add(this.combo_Filter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 54);
            this.panel1.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Silver;
            this.btn_Search.BackgroundImage = global::Attendance_Monitoring_With_Fingerprint.Properties.Resources.icon_search;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Search.Location = new System.Drawing.Point(961, 11);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(33, 31);
            this.btn_Search.TabIndex = 1040;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Visible = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // panel_Search
            // 
            this.panel_Search.BackColor = System.Drawing.Color.White;
            this.panel_Search.Controls.Add(this.txt_Search);
            this.panel_Search.Location = new System.Drawing.Point(699, 11);
            this.panel_Search.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(263, 31);
            this.panel_Search.TabIndex = 1039;
            this.panel_Search.Visible = false;
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.White;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.LightGray;
            this.txt_Search.Location = new System.Drawing.Point(7, 6);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(251, 20);
            this.txt_Search.TabIndex = 0;
            // 
            // lbl_Dash
            // 
            this.lbl_Dash.AutoSize = true;
            this.lbl_Dash.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dash.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Dash.Location = new System.Drawing.Point(411, 11);
            this.lbl_Dash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dash.Name = "lbl_Dash";
            this.lbl_Dash.Size = new System.Drawing.Size(26, 32);
            this.lbl_Dash.TabIndex = 1038;
            this.lbl_Dash.Text = "-";
            this.lbl_Dash.Visible = false;
            // 
            // datePick_To
            // 
            this.datePick_To.CalendarForeColor = System.Drawing.Color.Gray;
            this.datePick_To.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.datePick_To.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datePick_To.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePick_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePick_To.Location = new System.Drawing.Point(444, 14);
            this.datePick_To.Margin = new System.Windows.Forms.Padding(4);
            this.datePick_To.Name = "datePick_To";
            this.datePick_To.Size = new System.Drawing.Size(180, 27);
            this.datePick_To.TabIndex = 1037;
            this.datePick_To.Visible = false;
            // 
            // datePick_From
            // 
            this.datePick_From.CalendarForeColor = System.Drawing.Color.Gray;
            this.datePick_From.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.datePick_From.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datePick_From.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePick_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePick_From.Location = new System.Drawing.Point(221, 14);
            this.datePick_From.Margin = new System.Windows.Forms.Padding(4);
            this.datePick_From.Name = "datePick_From";
            this.datePick_From.Size = new System.Drawing.Size(180, 27);
            this.datePick_From.TabIndex = 1036;
            this.datePick_From.Visible = false;
            this.datePick_From.ValueChanged += new System.EventHandler(this.datePick_From_ValueChanged);
            // 
            // combo_MonthDistance
            // 
            this.combo_MonthDistance.BackColor = System.Drawing.Color.White;
            this.combo_MonthDistance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_MonthDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_MonthDistance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_MonthDistance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_MonthDistance.ForeColor = System.Drawing.Color.Gray;
            this.combo_MonthDistance.FormattingEnabled = true;
            this.combo_MonthDistance.Items.AddRange(new object[] {
            "All",
            "Day",
            "Week",
            "Month",
            "Distance"});
            this.combo_MonthDistance.Location = new System.Drawing.Point(221, 12);
            this.combo_MonthDistance.Margin = new System.Windows.Forms.Padding(4);
            this.combo_MonthDistance.Name = "combo_MonthDistance";
            this.combo_MonthDistance.Size = new System.Drawing.Size(196, 29);
            this.combo_MonthDistance.TabIndex = 1035;
            this.combo_MonthDistance.SelectedIndexChanged += new System.EventHandler(this.combo_MonthDistance_SelectedIndexChanged);
            // 
            // combo_Filter
            // 
            this.combo_Filter.BackColor = System.Drawing.Color.White;
            this.combo_Filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_Filter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Filter.ForeColor = System.Drawing.Color.Gray;
            this.combo_Filter.FormattingEnabled = true;
            this.combo_Filter.Items.AddRange(new object[] {
            "All",
            "Day",
            "Week",
            "Month",
            "student"});
            this.combo_Filter.Location = new System.Drawing.Point(16, 12);
            this.combo_Filter.Margin = new System.Windows.Forms.Padding(4);
            this.combo_Filter.Name = "combo_Filter";
            this.combo_Filter.Size = new System.Drawing.Size(196, 29);
            this.combo_Filter.TabIndex = 1034;
            this.combo_Filter.SelectedIndexChanged += new System.EventHandler(this.combo_Filter_SelectedIndexChanged);
            // 
            // lv_User
            // 
            this.lv_User.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_User.BackColor = System.Drawing.Color.White;
            this.lv_User.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader1});
            this.lv_User.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_User.ForeColor = System.Drawing.Color.Gray;
            this.lv_User.FullRowSelect = true;
            this.lv_User.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_User.HideSelection = false;
            this.lv_User.LabelWrap = false;
            this.lv_User.Location = new System.Drawing.Point(0, 52);
            this.lv_User.Margin = new System.Windows.Forms.Padding(4);
            this.lv_User.Name = "lv_User";
            this.lv_User.Size = new System.Drawing.Size(1008, 552);
            this.lv_User.TabIndex = 219;
            this.lv_User.UseCompatibleStateImageBehavior = false;
            this.lv_User.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Student ID";
            this.columnHeader6.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 201;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Desgination";
            this.columnHeader4.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time-In";
            this.columnHeader3.Width = 65;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Time-Out";
            this.columnHeader5.Width = 65;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 147;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.btn_GeneratePDF);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 603);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1009, 41);
            this.panel5.TabIndex = 220;
            // 
            // btn_GeneratePDF
            // 
            this.btn_GeneratePDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_GeneratePDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GeneratePDF.FlatAppearance.BorderSize = 0;
            this.btn_GeneratePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GeneratePDF.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GeneratePDF.ForeColor = System.Drawing.Color.White;
            this.btn_GeneratePDF.Location = new System.Drawing.Point(812, 4);
            this.btn_GeneratePDF.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GeneratePDF.Name = "btn_GeneratePDF";
            this.btn_GeneratePDF.Size = new System.Drawing.Size(195, 33);
            this.btn_GeneratePDF.TabIndex = 92;
            this.btn_GeneratePDF.Text = "Generate PDF";
            this.btn_GeneratePDF.UseVisualStyleBackColor = false;
            this.btn_GeneratePDF.Click += new System.EventHandler(this.btn_GeneratePDF_Click);
            // 
            // UsrConPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lv_User);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsrConPDF";
            this.Size = new System.Drawing.Size(1009, 644);
            this.Load += new System.EventHandler(this.UsrConPDF_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Search.ResumeLayout(false);
            this.panel_Search.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel_Search;
        public System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Dash;
        public System.Windows.Forms.DateTimePicker datePick_To;
        public System.Windows.Forms.DateTimePicker datePick_From;
        public System.Windows.Forms.ComboBox combo_MonthDistance;
        public System.Windows.Forms.ComboBox combo_Filter;
        public System.Windows.Forms.ListView lv_User;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Button btn_GeneratePDF;
    }
}
