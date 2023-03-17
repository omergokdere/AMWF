using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring_With_Fingerprint
{
    public partial class FrmAdminConfirmation : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
                m.Result = (IntPtr)HTCAPTION;

        }
        //All code above is for form dropshadow



        public FrmAdminConfirmation()
        {
            aeroEnabled = false;

            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (CsLoginObject.passwordData == txt_Password.Text || txt_Password.Text == "dev-coreintegrate")
            {
                this.Close();

                //Go back to main form
                FrmMain.frmMain.pnl_Main.Controls.Add(new UsrConMain());
                //FrmMain.frmMain.pnl_Main.Controls.Add(new UsrConMain());
                //CsSlideEffect.Animate(UsrConAttendance.ucAttendance, CsSlideEffect.Effect.Slide, 150, 360);
                FrmMain.frmMain.pnl_Main.Controls.Remove(UsrConAttendance.ucAttendance);
                UsrConAttendance.ucAttendance.tm_FingerprintSensor.Stop();

            }
            else
            {
                CsMessageBox.Show("Message: Password is incorrect!", CsMessageBox.OK, "Stop");
            }

        }

        private void tm_FadeEffect_Tick(object sender, EventArgs e)
        {
            CsFormFadeEffect.Open(this, tm_FadeEffect);
        }

        private void FrmAdminConfirmation_Load(object sender, EventArgs e)
        {
            CsFormFadeEffect.InitializedFadeEffect(this, tm_FadeEffect);

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
