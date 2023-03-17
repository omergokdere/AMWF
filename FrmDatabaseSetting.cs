using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring_With_Fingerprint
{
    public partial class FrmDatabaseSetting : Form
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

        private bool m_aeroEnabled;
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
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
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
                    if (m_aeroEnabled)
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


        public FrmDatabaseSetting()
        {
            m_aeroEnabled = true;
            InitializeComponent();
        }



        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Storing the database configuartion to textfile
            string lines = string.Format("{0}#{1}#{2}#{3}#{4}#{5}", txt_ServerAddress.Text, txt_Port.Text, txt_Username.Text, txt_Password.Text, txt_Database.Text, combo_Port.Text);
            System.IO.StreamWriter file = new System.IO.StreamWriter(Directory.GetCurrentDirectory() + @"\databaseconfig.txt");
            file.WriteLine(lines);
            file.Close();
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDatabaseSetting_Load(object sender, EventArgs e)
        {
            //fade in effect
            CsFormFadeEffect.InitializedFadeEffect(this, tm_FadeEffect);

            //Getting portnames
            string[] ports = SerialPort.GetPortNames();
            combo_Port.Items.Clear();

            foreach (string port in ports)
            {
                if (!combo_Port.Items.Contains(port))
                {
                    combo_Port.Items.Add(port);
                }
            }


            try
            {
                string SERVER = FetchDatabaseLocation()[0];
                string USERNAME = FetchDatabaseLocation()[1];
                string PASSWORD = FetchDatabaseLocation()[2];
                string DATABASE = FetchDatabaseLocation()[3];
                string ONLINE = FetchDatabaseLocation()[4];
                string AUTH = FetchDatabaseLocation()[5];

                txt_ServerAddress.Text = SERVER;
                txt_Port.Text = USERNAME;
                txt_Username.Text = PASSWORD;
                txt_Password.Text = DATABASE;
                txt_Database.Text = ONLINE;
                combo_Port.Text = AUTH;
            }
            catch { }
            this.ActiveControl = null;
        }

        private void tm_FadeEffect_Tick(object sender, EventArgs e)
        {
            CsFormFadeEffect.Open(this, tm_FadeEffect);
        }

        public static string[] FetchDatabaseLocation()
        {
            string[] returnData = new string[5];

            try
            {
                StreamReader file = new StreamReader(Directory.GetCurrentDirectory() + @"\databaseconfig.txt");

                returnData = file.ReadLine().Split('#');
                file.Close();
            }
            catch { }
            return returnData;

        }
    }
}
