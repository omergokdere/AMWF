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
    public partial class UsrConPDF : UserControl
    {
        public static UsrConPDF ucPDF;
        public UsrConPDF()
        {
            ucPDF = this;
            InitializeComponent();
        }

        private void combo_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Filter.Text == "All")
            {
                datePick_From.Visible = false;
                datePick_To.Visible = false;
                lbl_Dash.Visible = false;
                panel_Search.Visible = false;
                btn_Search.Visible = false;

                combo_MonthDistance.Visible = false;

                //Getting data to database
                string query = CsQueryObject.AllQuery("tbl_attendance", "timeInDate DESC");
                DataTable dataTable = new CsDatabaseGet(query, CsModeObject.AllMode).GetTable;

                //Put in the listview
                CsListViewItem.AttendanceItemWithoutPic(dataTable, lv_User);
                CsListviewGridColor.SetGridColor(lv_User);
                CsAutoComplete.SetTextBoxAutoComplete(txt_Search, "tbl_User", "studentID");

            }

            if (combo_Filter.Text == "student")
            {
                datePick_From.Visible = false;
                datePick_To.Visible = false;
                lbl_Dash.Visible = false;
                combo_MonthDistance.Visible = false;

                panel_Search.Visible = true;
                btn_Search.Visible = true;

            }

            if (combo_Filter.Text == "Day")
            {
                datePick_From.Visible = true;
                datePick_To.Visible = false;
                lbl_Dash.Visible = false;
                panel_Search.Visible = false;
                btn_Search.Visible = false;

                combo_MonthDistance.Visible = false;
            }

            if (combo_Filter.Text == "Week")
            {
                datePick_To.Value = datePick_From.Value.AddDays(7);
                datePick_From.Visible = true;
                datePick_To.Visible = true;
                lbl_Dash.Visible = true;
                panel_Search.Visible = false;
                btn_Search.Visible = false;

                combo_MonthDistance.Visible = false;
            }


            if (combo_Filter.Text == "Month")
            {
                datePick_From.Visible = false;
                datePick_To.Visible = false;
                lbl_Dash.Visible = false;
                combo_MonthDistance.Visible = true;
                panel_Search.Visible = false;
                btn_Search.Visible = false;

                combo_MonthDistance.Items.Clear();
                combo_MonthDistance.Text = "";

                combo_MonthDistance.Items.Add("January");
                combo_MonthDistance.Items.Add("February");
                combo_MonthDistance.Items.Add("March");
                combo_MonthDistance.Items.Add("April");
                combo_MonthDistance.Items.Add("May");
                combo_MonthDistance.Items.Add("June");
                combo_MonthDistance.Items.Add("July");
                combo_MonthDistance.Items.Add("August");
                combo_MonthDistance.Items.Add("September");
                combo_MonthDistance.Items.Add("October");
                combo_MonthDistance.Items.Add("November");
                combo_MonthDistance.Items.Add("December");
            }
        }

        private static string GetMonthIndex(string monthString)
        {
            if (monthString == "January") { return "01"; }
            if (monthString == "February") { return "02"; }
            if (monthString == "March") { return "03"; }
            if (monthString == "April") { return "04"; }
            if (monthString == "May") { return "05"; }
            if (monthString == "June") { return "06"; }
            if (monthString == "July") { return "07"; }
            if (monthString == "August") { return "08"; }
            if (monthString == "September") { return "09"; }
            if (monthString == "October") { return "10"; }
            if (monthString == "November") { return "11"; }
            if (monthString == "December") { return "12"; }

            return "0";
        }

        private void UsrConPDF_Load(object sender, EventArgs e)
        {
            combo_Filter.SelectedIndex = 0;
        }

        private void datePick_From_ValueChanged(object sender, EventArgs e)
        {
            if (combo_Filter.Text == "Day")
            {
                //Getting data to database
                string query = CsQueryObject.AllQuery("tbl_attendance WHERE timeInDate='"+datePick_From.Value.ToString("yyyy-MM-dd")+"'", "timeInDate DESC");
                DataTable dataTable = new CsDatabaseGet(query, CsModeObject.AllMode).GetTable;

                //Put in the listview
                CsListViewItem.AttendanceItemWithoutPic(dataTable, lv_User);
                CsListviewGridColor.SetGridColor(lv_User);


            }

            if (combo_Filter.Text == "Week")
            {
                datePick_To.Value = datePick_From.Value.AddDays(6);

                //Getting data to database
                string query = CsQueryObject.AllQuery("tbl_attendance WHERE timeInDate>='" + datePick_From.Value.ToString("yyyy-MM-dd") + "' AND timeInDate<='" + datePick_To.Value.ToString("yyyy-MM-dd") + "'", "timeInDate DESC");
                DataTable dataTable = new CsDatabaseGet(query, CsModeObject.AllMode).GetTable;

                //Put in the listview
                CsListViewItem.AttendanceItemWithoutPic(dataTable, lv_User);
                CsListviewGridColor.SetGridColor(lv_User);
            }
        }

        private void combo_MonthDistance_SelectedIndexChanged(object sender, EventArgs e)
        {
            string finalDate = DateTime.Now.Year.ToString() + "-" + GetMonthIndex(combo_MonthDistance.Text) + "-" + DateTime.Now.Day.ToString();

            var firstDayOfMonth = new DateTime(DateTime.Parse(finalDate).Year, DateTime.Parse(finalDate).Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            //Getting data to database
            string query = CsQueryObject.AllQuery("tbl_attendance WHERE timeInDate>='" + firstDayOfMonth.ToString("yyyy-MM-dd") + "' AND timeInDate<='" + lastDayOfMonth.ToString("yyyy-MM-dd") + "'", "timeInDate DESC");
            DataTable dataTable = new CsDatabaseGet(query, CsModeObject.AllMode).GetTable;

            //Put in the listview
            CsListViewItem.AttendanceItemWithoutPic(dataTable, lv_User);
            CsListviewGridColor.SetGridColor(lv_User);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //Getting data to database
            string query = CsQueryObject.AllQuery("tbl_attendance", "timeInDate DESC");
            DataTable dataTable = new CsDatabaseGet(query, CsModeObject.AllMode).GetTable;

            //Put in the listview
            CsListViewItem.AttendanceItemWithoutPicSearchUser(dataTable, lv_User,txt_Search.Text);
            CsListviewGridColor.SetGridColor(lv_User);
        }

        private void btn_GeneratePDF_Click(object sender, EventArgs e)
        {
            if (lv_User.Items.Count > 0)
            {
                CsGeneratePDF.PerformGenerate();
                return;
            }

            CsMessageBox.Show("Message: There's no data in the list!", CsMessageBox.OK, "Stop");

        }
    }
}
