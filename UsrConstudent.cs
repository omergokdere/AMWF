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
    public partial class UsrConstudent : UserControl
    {
        public UsrConstudent()
        {
            InitializeComponent();
        }


        private void DefaultInterface()
        {
            //Getting data from database
            string query = CsQueryObject.AllQuery("tbl_user", "userKey");
            DataTable dataTable = new CsDatabaseGet(query, CsModeObject.AllMode).GetTable;


            //Putting it in listview
            CsListViewItem.UserItem(dataTable, lv_User);
            CsListviewGridColor.SetGridColor(lv_User);

            btn_Add.Text = "Add";
            btn_Cancel.Visible = false;
            btn_Delete.Visible = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (btn_Add.Text == "Update")
            {
                FrmMaintenanceUser.mode = "Update";
                new FrmMaintenanceUser().ShowDialog();

                DefaultInterface();
                return;
            }

            FrmMaintenanceUser.mode = "Add";
            new FrmMaintenanceUser().ShowDialog();
            DefaultInterface();
        }

        private void UsrConstudent_Load(object sender, EventArgs e)
        {
            DefaultInterface();
        }


        //Deleting student from database

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bool messageBoxVal = CsMessageBox.Show("Question: Are you sure you want to delete this user?", CsMessageBox.YESNO, "Question");

            if (messageBoxVal == true)
            {
                CsstudentObject.studentIDData = lv_User.SelectedItems[0].SubItems[1].Text;
                double fingerprintID = double.Parse( CsstudentObject.studentIDData.Replace("STUDENT-",""));

                string query = CsQueryObject.DeletestudentQuery();
                CsDatabaseDelete.PerformDelete(query, CsModeObject.DeleteEmpoyeeMode);

                query = CsQueryObject.DeleteAttendanceQuery();
                CsDatabaseDelete.PerformDelete(query, CsModeObject.DeleteAttendanceMode);

                CsInitializePort.serialPort.WriteLine("delete:" + fingerprintID.ToString("0"));

                CsMessageBox.Show("Message: User successfully deleted!", CsMessageBox.OK, "Success");
                DefaultInterface();

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            btn_Add.Text = "Add";
            btn_Cancel.Visible = false;
            btn_Delete.Visible = false;
        }


        private void lv_User_Click(object sender, EventArgs e)
        {
            if (lv_User.SelectedItems.Count == 1)
            {
                CsstudentObject.studentIDData = lv_User.SelectedItems[0].SubItems[1].Text;
                btn_Cancel.Visible = true;
                btn_Delete.Visible = true;
                btn_Add.Text = "Update";
            }
        }

        private void Lv_User_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
