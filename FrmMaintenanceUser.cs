using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring_With_Fingerprint
{
    public partial class FrmMaintenanceUser : Form
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



        public static FrmMaintenanceUser frmUserMaintenance;
        public FrmMaintenanceUser()
        {
            frmUserMaintenance = this;
            InitializeComponent();
        }


        private void SetUserObjectFromFields()
        {
            CsstudentObject.studentIDData = lbl_studentID.Text;
            CsstudentObject.fingerprintIDData = lbl_FingerprintID.Text;
            CsstudentObject.designationData = combo_UserType.Text;

            CsstudentObject.firstnameData = txt_Firstname.Text;
            CsstudentObject.lastnameData = txt_Lastname.Text;
            CsstudentObject.usernameData = txt_Username.Text;
            CsstudentObject.passwordData = txt_Password.Text;

            CsstudentObject.pictureData = picBox_User.Image;

        }



        private void btn_Register_Click(object sender, EventArgs e)
        {
            SetUserObjectFromFields();

            if (!CsValidation.PerformUserValidation()) return;
            
            if (btn_Add.Text.Equals("Add"))
            {
                //Inserting the student to the database
                string query = CsQueryObject.InsertUserQuery();
                CsDatabaseInsert.PerformInsert(query, CsModeObject.InsertstudentMode);
                CsMessageBox.Show("Message: " + combo_UserType.Text + " is successfully registered!", CsMessageBox.OK, "Success");
                isFingerprintAdded = false;
            }


            if (btn_Add.Text.Equals("Update"))
            {
                //Updating the student to the database
                string query = CsQueryObject.UpdatestudentQuery();
                CsDatabaseUpdate.PerformUpdate(query, CsModeObject.UpdatestudentMode);
                CsMessageBox.Show("Message: " + combo_UserType.Text + " is successfully updated!", CsMessageBox.OK, "Success");
                isFingerprintAdded = false;
                
            }


            CsstudentObject.reset();
            this.Close();
        }


        private int intervalTap = 0;
        string currentCommand = "";
        public static bool isFingerprintAdded = false;
        private void tm_FingerprintSensor_Tick(object sender, EventArgs e)
        {

            if (intervalTap % 2 == 1)
            {
                txt_Message.Visible = false;
            }
            else
            {
                txt_Message.Visible = true;
            }

            intervalTap++;


            string readedSerial = CsInitializePort.serialPort.ReadExisting();

            if (readedSerial.Length > 0)
            {
                currentCommand = readedSerial.Trim();
                Thread.Sleep(100);
            }


            if (currentCommand == "core-WT")
            {
                txt_Message.Text = "PLACE YOUR FINGERS";
                picBox_Fingerprint.Image = Properties.Resources.img_fingerprint_initial;
            }


            if (currentCommand == "core-RF")
            {
                txt_Message.Text = "REMOVE YOUR FINGER";
                picBox_Fingerprint.Image = Properties.Resources.img_fingerprint_second;
            }

            if (currentCommand == "core-PF")
            {
                txt_Message.Text = "PLACE SAME FINGER";
                picBox_Fingerprint.Image = Properties.Resources.img_fingerprint_first;

            }

            if (currentCommand.Contains("ok") || currentCommand.Contains("core-PM") || isFingerprintAdded)
            {
                tm_FingerprintSensor.Stop();
                txt_Message.Text = "FINGERPRINT SAVED";
                picBox_Fingerprint.Image = Properties.Resources.img_fingerprint_success;
                txt_Message.Visible = true;
                lbl_ReadAgain.Visible = true;
                isFingerprintAdded = true;

                CsInitializePort.serialPort.WriteLine("exit" + lbl_FingerprintID.Text);
                CsInitializePort.serialPort.ReadExisting();
            }

            bool err9Concurrent = false;
            if (currentCommand == "core-DM" && !isFingerprintAdded && !err9Concurrent)
            {
                err9Concurrent = true;

                tm_FingerprintSensor.Stop();
                CsMessageBox.Show("Message: Fingerprint did'nt match, please try again.", CsMessageBox.OK, "Stop");
                picBox_Fingerprint.Image = Properties.Resources.img_fingerprint_initial;

                CsInitializePort.serialPort.WriteLine("exit" + lbl_FingerprintID.Text);
                CsInitializePort.serialPort.ReadExisting();

                CsInitializePort.serialPort.WriteLine("enroll:" + lbl_FingerprintID.Text);
                tm_FingerprintSensor.Start();
                err9Concurrent = false;

            }

        }


        public static string mode = "Add";
        private void FrmEnroll_Load(object sender, EventArgs e)
        {

            if (mode == "Update")
            {
                txt_Message.Text = "FINGERPRINT SAVED";
                picBox_Fingerprint.Image = Properties.Resources.img_fingerprint_success;
                txt_Message.Visible = true;
                lbl_ReadAgain.Visible = true;
                isFingerprintAdded = true;

                btn_Add.Text = "Update";
                lbl_ReadAgain.Visible = true;
                string queryUpdate = CsQueryObject.AllQuery("tbl_user WHERE studentID='" + CsstudentObject.studentIDData + "'", "studentID");
                DataTable dataTable = new CsDatabaseGet(queryUpdate, CsModeObject.AllMode).GetTable;

                foreach (DataRow row in dataTable.Rows)
                {
                    txt_Firstname.Text = row["firstname"].ToString();
                    txt_Lastname.Text = row["lastname"].ToString();
                    txt_Username.Text = row["username"].ToString();
                    txt_Password.Text = row["password"].ToString();
                    lbl_studentID.Text = row["studentID"].ToString();
                    lbl_FingerprintID.Text = row["fingerprintID"].ToString();
                    combo_UserType.Text = row["designation"].ToString();
                    picBox_User.Image = CsPictureConverter.ToImage((byte[])row["image"]);
                }

                return;
            }

            combo_UserType.SelectedIndex = 0;

            string query = CsQueryObject.AllQuery("tbl_user", "userKey ASC");
            DataTable table = new CsDatabaseGet(query, CsModeObject.AllMode).GetTable;

            lbl_studentID.Text = CsAutoID.GetIncrementedID(table, "STUDENT-", "studentID");

            InitializeNewFingerprint();
            tm_FingerprintSensor.Start();
        }

        private void InitializeNewFingerprint()
        {
            CsInitializePort.serialPort.WriteLine("enroll:" + lbl_FingerprintID.Text);
        }




        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            CsInitializePort.serialPort.WriteLine("cancel");
            //if (currentCommand == "core-WT" || currentCommand == "core-PF" || currentCommand == "core-RF")
            //{
            //    CsInitializePort.serialPort.WriteLine("cancel");
            //}

            if (mode != "Update" && isFingerprintAdded)
            {
                CsInitializePort.serialPort.WriteLine("delete:" + lbl_FingerprintID.Text);
            }

            if (isFingerprintAdded)
            {
                CsInitializePort.serialPort.WriteLine("delete:" + lbl_FingerprintID.Text);
            }

            this.Close();
        }

        private void lbl_ReadAgain_Click(object sender, EventArgs e)
        {
            isFingerprintAdded = false;
            CsInitializePort.serialPort.WriteLine("enroll:" + lbl_FingerprintID.Text);

            picBox_Fingerprint.Image = Properties.Resources.img_fingerprint_initial;
            txt_Message.Text = "PLACE YOUR FINGER";
            tm_FingerprintSensor.Start();
            lbl_ReadAgain.Visible = false;
        }

        private void picBox_User_Click(object sender, EventArgs e)
        {
            CsOpenDialog.ImportPicture(picBox_User);
        }

        private void combo_UserType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (combo_UserType.Text == "Administrator")
            {
                //group_Fingerprint.Visible = false;


                //btn_Cancel.Location = new Point(12, 340);
                //btn_Add.Location = new Point(215, 340);

                txt_Username.Enabled = true;
                txt_Password.Enabled = true;

                //this.Size = new Size(427, 385);
                return;

            }

            group_Fingerprint.Visible = true;

            this.Size = new Size(427, 523);


            btn_Cancel.Location = new Point(12, 477);
            btn_Add.Location = new Point(215, 477);

            txt_Username.Enabled = false;
            txt_Password.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CsInitializePort.serialPort.WriteLine("core-RF");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CsInitializePort.serialPort.WriteLine("core-PF");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CsInitializePort.serialPort.WriteLine("ok");

        }
    }
}
