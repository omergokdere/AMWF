namespace Attendance_Monitoring_With_Fingerprint
{
    partial class FrmMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMessageBox));
            this.btn_OkOrYes = new System.Windows.Forms.Button();
            this.txt_MessageBoxMessage = new System.Windows.Forms.TextBox();
            this.tm_FadeEffect = new System.Windows.Forms.Timer(this.components);
            this.btn_No = new System.Windows.Forms.Button();
            this.picBox_MessageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_MessageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OkOrYes
            // 
            this.btn_OkOrYes.BackColor = System.Drawing.Color.Silver;
            this.btn_OkOrYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OkOrYes.FlatAppearance.BorderSize = 0;
            this.btn_OkOrYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OkOrYes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OkOrYes.ForeColor = System.Drawing.Color.White;
            this.btn_OkOrYes.Location = new System.Drawing.Point(23, 203);
            this.btn_OkOrYes.Name = "btn_OkOrYes";
            this.btn_OkOrYes.Size = new System.Drawing.Size(176, 33);
            this.btn_OkOrYes.TabIndex = 21;
            this.btn_OkOrYes.Text = "OK";
            this.btn_OkOrYes.UseVisualStyleBackColor = false;
            this.btn_OkOrYes.Click += new System.EventHandler(this.btn_OkOrYes_Click);
            // 
            // txt_MessageBoxMessage
            // 
            this.txt_MessageBoxMessage.BackColor = System.Drawing.SystemColors.Control;
            this.txt_MessageBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MessageBoxMessage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MessageBoxMessage.ForeColor = System.Drawing.Color.Gray;
            this.txt_MessageBoxMessage.Location = new System.Drawing.Point(32, 145);
            this.txt_MessageBoxMessage.Multiline = true;
            this.txt_MessageBoxMessage.Name = "txt_MessageBoxMessage";
            this.txt_MessageBoxMessage.Size = new System.Drawing.Size(342, 42);
            this.txt_MessageBoxMessage.TabIndex = 23;
            this.txt_MessageBoxMessage.Text = "Message";
            this.txt_MessageBoxMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tm_FadeEffect
            // 
            this.tm_FadeEffect.Interval = 5;
            this.tm_FadeEffect.Tick += new System.EventHandler(this.tm_FadeEffect_Tick);
            // 
            // btn_No
            // 
            this.btn_No.BackColor = System.Drawing.Color.Silver;
            this.btn_No.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_No.FlatAppearance.BorderSize = 0;
            this.btn_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_No.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_No.ForeColor = System.Drawing.Color.White;
            this.btn_No.Location = new System.Drawing.Point(205, 203);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(169, 33);
            this.btn_No.TabIndex = 25;
            this.btn_No.Text = "NO";
            this.btn_No.UseVisualStyleBackColor = false;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // picBox_MessageBox
            // 
            this.picBox_MessageBox.Image = global::Attendance_Monitoring_With_Fingerprint.Properties.Resources.icon_messagebox_warning;
            this.picBox_MessageBox.Location = new System.Drawing.Point(150, 22);
            this.picBox_MessageBox.Name = "picBox_MessageBox";
            this.picBox_MessageBox.Size = new System.Drawing.Size(100, 100);
            this.picBox_MessageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_MessageBox.TabIndex = 24;
            this.picBox_MessageBox.TabStop = false;
            // 
            // FrmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(396, 249);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.picBox_MessageBox);
            this.Controls.Add(this.txt_MessageBoxMessage);
            this.Controls.Add(this.btn_OkOrYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.Load += new System.EventHandler(this.FrmMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_MessageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OkOrYes;
        private System.Windows.Forms.TextBox txt_MessageBoxMessage;
        private System.Windows.Forms.PictureBox picBox_MessageBox;
        private System.Windows.Forms.Timer tm_FadeEffect;
        private System.Windows.Forms.Button btn_No;
    }
}