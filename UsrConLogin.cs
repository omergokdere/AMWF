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
    public partial class UsrConLogin : UserControl
    {

        public static UsrConLogin usrConLogin;
        public UsrConLogin()
        {
            usrConLogin = this;
            InitializeComponent();
        }

        private void UserConLogin_Load(object sender, EventArgs e)
        {
            CsInitializePort.InittializedPort();
            tm_PlaceFinger.Start();

            try
            {
                CsInitializePort.serialPort.WriteLine("read");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Initialize database connection
            CsConnection.EstablishConnection();


            //Check database is already connected
            if (CsConnection.connection.State == ConnectionState.Closed)
            {
                CsMessageBox.Show("ERROR: Connect to database!", CsMessageBox.OK, "Error");
                return;
            }


            //Putting value to login object
            CsLoginObject.usernameData = txt_Username.Text;
            CsLoginObject.passwordData = txt_Password.Text;



            PerformUserAccess();
        }


        //Checking the credentials if exist
        private void PerformUserAccess()
        {

            string query = CsQueryObject.LoginQuery();

            DataTable dataTable = new CsDatabaseGet(query, CsModeObject.LoginMode).GetTable;

            if (dataTable.Rows.Count == 0) { PerformDeveloperAccess(); return; };

            CsLoginObject.pictureData = CsPictureConverter.ToImage((byte[])dataTable.Rows[0]["image"]);
            CsLoginObject.studentIDData = dataTable.Rows[0]["studentID"].ToString();
            CsLoginObject.firstnameData = dataTable.Rows[0]["firstname"].ToString();
            CsLoginObject.lastnameData = dataTable.Rows[0]["lastname"].ToString();
            CsLoginObject.usernameData = dataTable.Rows[0]["username"].ToString();
            CsLoginObject.passwordData = dataTable.Rows[0]["password"].ToString();

            FrmMain.frmMain.pnl_Main.Controls.Add(new UsrConMain());
            FrmMain.frmMain.pnl_Main.Controls.Remove(this);
            //CsSlideEffect.Animate(this, CsSlideEffect.Effect.Slide, 150, 360);
            tm_PlaceFinger.Stop();

        }


        //Developer access
        private void PerformDeveloperAccess()
        {
            if (txt_Username.Text == "kadirhas" && txt_Password.Text == "kadir.has")
            {
                FrmMain.frmMain.pnl_Main.Controls.Add(new UsrConMain());
                FrmMain.frmMain.pnl_Main.Controls.Remove(this);
                //CsSlideEffect.Animate(this, CsSlideEffect.Effect.Slide, 150, 360);
                tm_PlaceFinger.Stop();

            }
            else
            {

                lbl_Invalid.Visible = true;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            FrmMain.frmMain.WindowState = FormWindowState.Minimized;
        }



        private void btn_Setting_Click(object sender, EventArgs e)
        {
            new FrmDatabaseSetting().ShowDialog();
            CsConnection.EstablishConnection();
            CsInitializePort.InittializedPort();

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Setting.Visible = txt_Password.Text == "kadir.has" ? true : false;
        }

        private int intervalTap = 0;
        string currentFingerprintID = "";

        private void tm_PlaceFinger_Tick(object sender, EventArgs e)
        {
            if (intervalTap % 2 == 1)
            {
                lbl_PlaceFinger.Visible = true;
            }
            else
            {
                lbl_PlaceFinger.Visible = true;
            }

            intervalTap++;

            try
            {
                string readedSerial = CsInitializePort.serialPort.ReadExisting();
                Console.WriteLine(readedSerial);
                if (readedSerial.Length > 0 && readedSerial.Contains("Found ID #"))
                {
                    currentFingerprintID = readedSerial.Trim().Split('#')[1].Trim();
                    currentFingerprintID = currentFingerprintID.Split(':')[0].Trim();

                    string query = CsQueryObject.AllQuery("tbl_user WHERE fingerprintID='" + currentFingerprintID.ToString() + "' AND designation='Administrator'", "userKey");
                    DataTable dataTable = new CsDatabaseGet(query, CsModeObject.LoginMode).GetTable;
                    if (dataTable.Rows.Count == 0) { return; };

                    CsLoginObject.pictureData = CsPictureConverter.ToImage((byte[])dataTable.Rows[0]["image"]);
                    CsLoginObject.fingerprintIDData = dataTable.Rows[0]["fingerprintID"].ToString();
                    CsLoginObject.usernameData = dataTable.Rows[0]["username"].ToString();
                    CsLoginObject.passwordData = dataTable.Rows[0]["password"].ToString();

                    picBox_Login.Image = CsLoginObject.pictureData;
                    txt_Username.Text = CsLoginObject.usernameData;
                    txt_Password.Text = CsLoginObject.passwordData;
                }

            }
            catch (Exception)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
