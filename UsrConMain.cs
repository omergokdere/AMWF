using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring_With_Fingerprint
{
    public partial class UsrConMain : UserControl
    {

        public static UsrConMain usrConMain;
        public UsrConMain()
        {
            usrConMain = this;
            InitializeComponent();
        }

        private void UserConMain_Load(object sender, EventArgs e)
        {
            //Opening module for student list
            CsInitializePort.serialPort.WriteLine("exit");

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new UsrConstudent());
            txt_TabTitle.Text = "STUDENTS";
            tm_DateTime.Start();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {

            //Logout
            bool messageBoxVal = CsMessageBox.Show("Question: Are you sure  you want to logout?", CsMessageBox.YESNO, "Question");
            if (messageBoxVal == true)
            {
                CsInitializePort.serialPort.Close();
                UsrConLogin ucLogin = new UsrConLogin();
                FrmMain.frmMain.pnl_Main.Controls.Add(ucLogin);
                FrmMain.frmMain.pnl_Main.Controls.Remove(this);
                //CsSlideEffect.Animate(this, CsSlideEffect.Effect.Slide, 150, 360);
            }
        }

        private void tm_DateTime_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
            lbl_Date.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            FrmMain.frmMain.WindowState = FormWindowState.Minimized;

        }

        private void btn_Attendance_Click(object sender, EventArgs e)
        {
            //Opening module for attendance
            FrmMain.frmMain.pnl_Main.Controls.Add(new UsrConAttendance());
            FrmMain.frmMain.pnl_Main.Controls.Remove(this);

            //CsSlideEffect.Animate(this, CsSlideEffect.Effect.Slide, 150, 360);
            FrmMain.frmMain.pnl_Main.Controls.Remove(this);

        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            //Opening module for student list
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new UsrConstudent());
            txt_TabTitle.Text = "STUDENTS";
        }


        private void btn_PDF_Click(object sender, EventArgs e)
        {
            //Opening module for PDF Report
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new UsrConPDF());
            txt_TabTitle.Text = "PDF Report";
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
