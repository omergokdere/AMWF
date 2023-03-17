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
    public partial class UsrConAttendance : UserControl
    {
        public static UsrConAttendance ucAttendance;
        public UsrConAttendance()
        {
            ucAttendance = this;
            InitializeComponent();
        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            new FrmAdminConfirmation().ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CsInitializePort.serialPort.WriteLine("id: 1:108");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            CsInitializePort.serialPort.WriteLine("id: 2:96");

        }


        private void button3_Click(object sender, EventArgs e)
        {
            CsInitializePort.serialPort.WriteLine("id: 3:108");

        }


        private void button4_Click(object sender, EventArgs e)
        {
            CsInitializePort.serialPort.WriteLine("err: 2");
        }


        private static bool isstudentExist(ListView lv_Attendance, string studentID)
        {
            for (int i = 0; i < lv_Attendance.Items.Count; i++)
            {
                string listID = lv_Attendance.Items[i].SubItems[1].Text;
                string timeOut = lv_Attendance.Items[i].SubItems[5].Text;

                if (studentID == listID && timeOut != "")
                {
                    return true;
                }
            }

            return false;
        }


        private static bool SetTimeOut(ListView lv_Attendance, string studentID)
        {
            for (int i = 0; i < lv_Attendance.Items.Count; i++)
            {
                string listID = lv_Attendance.Items[i].SubItems[1].Text;
                string timeOut = lv_Attendance.Items[i].SubItems[5].Text;

                if (studentID == listID && String.IsNullOrEmpty( timeOut))
                {
                    CsAttendanceObject.timeOutnData = DateTime.Now.ToShortTimeString();
                    string queryUpdate = CsQueryObject.UpdateAttendance();
                    CsDatabaseUpdate.PerformUpdate(queryUpdate, CsModeObject.UpdateAttendanceMode);
                    return true;
                }
            }

            return false;
        }



        string currentFingerprintID = "";
        private void tm_FingerprintSensor_Tick(object sender, EventArgs e)
        {
            bool concurrent = false;
            string readedSerial = CsInitializePort.serialPort.ReadExisting();
            Console.WriteLine("Serial: " + readedSerial);
            if (readedSerial.Length > 0 && readedSerial.Contains("Found ID #"))
            {
                //checking the date if it is the current date
                if(datePick_Attendance.Value.Date != DateTime.Now.Date)
                {
                    CsMessageBox.Show("Message: You can't add attendance in this date!", CsMessageBox.OK, "Stop");

                    //exit the buffer
                    concurrent = true;
                    CsInitializePort.serialPort.WriteLine("exit");
                    CsInitializePort.serialPort.ReadExisting();
                    return;
                }


                //getting the ID of the fingerprint
                currentFingerprintID = readedSerial.Trim().Split('#')[1].Trim();
                currentFingerprintID = currentFingerprintID.Split(':')[0].Trim();

                //Checking if id is existing from database
                string query = CsQueryObject.AllQuery("tbl_user WHERE fingerprintID='" + currentFingerprintID .ToString()+ "'", "userKey");
                DataTable dataTable = new CsDatabaseGet(query, CsModeObject.LoginMode).GetTable;
                if (dataTable.Rows.Count == 0) { return; };
                CsAttendanceObject.studentIDData = dataTable.Rows[0]["studentID"].ToString();



                //Checking if student already in the list
                if (isstudentExist(lv_User, CsAttendanceObject.studentIDData)) 
                { 
                    CsMessageBox.Show("Message: User already in the list!", CsMessageBox.OK, "Stop");

                    //exit the buffer
                    concurrent = true;
                    //CsInitializePort.serialPort.WriteLine("exit");
                    CsInitializePort.serialPort.ReadExisting();
                    return; 
                }


                //Time-out the student
                if (SetTimeOut(lv_User, CsAttendanceObject.studentIDData))
                {
                    CsMessageBox.Show("Message: " + CsAttendanceObject.studentIDData + " time-out successfully!", CsMessageBox.OK, "Success");

                    //exit the buffer
                    concurrent = true;
                    //CsInitializePort.serialPort.WriteLine("exit");
                    CsInitializePort.serialPort.ReadExisting();

                    DefaultInterface();

                    return;
                }




                //Attendance the student
                CsAttendanceObject.studentIDData = dataTable.Rows[0]["studentID"].ToString();
                CsAttendanceObject.timeInData = DateTime.Now.ToShortTimeString();
                string queryInsert = CsQueryObject.InsertAttendanceQuery();
                CsDatabaseInsert.PerformInsert(queryInsert, CsModeObject.InsertAttendanceMode);
                CsMessageBox.Show("Message: Fingerprint found!", CsMessageBox.OK, "Success");



                //exit the buffer
                concurrent = true;
                //CsInitializePort.serialPort.WriteLine("exit");
                CsInitializePort.serialPort.ReadExisting();

                DefaultInterface();
            }

            concurrent = false;
        }
        
        private void DefaultInterface()
        {
            //Get the attendance of the current date
            string query = CsQueryObject.AllQuery("tbl_attendance WHERE timeInDate='" + datePick_Attendance.Value.ToString("yyyy-MM-dd") + "'", "attendanceKey");
            DataTable dataTable = new CsDatabaseGet(query, CsModeObject.AllMode).GetTable;

            //Put it in the listview
            CsListViewItem.AttendanceItem(dataTable, lv_User);
            CsListviewGridColor.SetGridColor(lv_User);

        }

        private void UsrConAttendance_Load(object sender, EventArgs e)
        {
            //Exit the buffer
            CsInitializePort.serialPort.WriteLine("exit");
            CsInitializePort.serialPort.ReadExisting();

            CsInitializePort.serialPort.WriteLine("read");

            tm_FingerprintSensor.Start();
            DefaultInterface();

        }

        private void datePick_Attendance_ValueChanged(object sender, EventArgs e)
        {
            DefaultInterface();
        }


    }
}
