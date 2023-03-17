using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsListViewItem
    {

        //All the method thats in here is for putting item in listviews.

        public static void UserItem(DataTable dataTable, ListView lv_User)
        {
            if (dataTable == null) return;

            lv_User.Items.Clear();
            ImageList imageList = new ImageList();
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            lv_User.SmallImageList = imageList;
            lv_User.SmallImageList.ImageSize = new System.Drawing.Size(50, 50);

            foreach (DataRow row in dataTable.Rows)
            {
                var imgbuf = (byte[])(row["image"]);
                MemoryStream ms = new MemoryStream(imgbuf, true);
                imageList.Images.Add(row["userKey"].ToString(), new Bitmap(ms));
                ms.Close();

                ListViewItem lvItem = new ListViewItem();
                lvItem.ImageKey = row["userKey"].ToString();
                lvItem.SubItems.Add(row["studentID"].ToString());
                lvItem.SubItems.Add(row["firstname"].ToString());
                lvItem.SubItems.Add(row["lastname"].ToString());
                lvItem.SubItems.Add(row["designation"].ToString());
                lv_User.Items.Add(lvItem);
            }
        }


        public static void AttendanceItem(DataTable dataTable, ListView lv_User)
        {
            if (dataTable == null) return;

            lv_User.Items.Clear();
            ImageList imageList = new ImageList();
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            lv_User.SmallImageList = imageList;
            lv_User.SmallImageList.ImageSize = new System.Drawing.Size(50, 50);

            foreach (DataRow row in dataTable.Rows)
            {
                string studentID = row["studentID"].ToString();
                string query = CsQueryObject.AllQuery("tbl_user WHERE studentID='" + studentID + "'", "userKey");
                DataTable dataTablestudent = new CsDatabaseGet(query, CsModeObject.AllMode).GetTable;

                string fullname = dataTablestudent.Rows[0]["firstname"].ToString() + " " + dataTablestudent.Rows[0]["lastname"].ToString();

                var imgbuf = (byte[])(dataTablestudent.Rows[0]["image"]);
                MemoryStream ms = new MemoryStream(imgbuf, true);
                imageList.Images.Add(dataTablestudent.Rows[0]["userKey"].ToString(), new Bitmap(ms));
                ms.Close();

                ListViewItem lvItem = new ListViewItem();
                lvItem.ImageKey = dataTablestudent.Rows[0]["userKey"].ToString();
                lvItem.SubItems.Add(studentID);
                lvItem.SubItems.Add(fullname);
                lvItem.SubItems.Add(dataTablestudent.Rows[0]["designation"].ToString());
                lvItem.SubItems.Add(row["timeIn"].ToString());
                lvItem.SubItems.Add(row["timeOut"].ToString());
                lv_User.Items.Add(lvItem);
            }
        }

        public static void AttendanceItemWithoutPic(DataTable dataTable, ListView lv_User)
        {
            if (dataTable == null) return;

            lv_User.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                string studentID = row["studentID"].ToString();
                string query = CsQueryObject.AllQuery("tbl_user WHERE studentID='" + studentID + "'", "userKey");
                DataTable dataTablestudent = new CsDatabaseGet(query, CsModeObject.AllMode).GetTable;

                string fullname = dataTablestudent.Rows[0]["firstname"].ToString() + " " + dataTablestudent.Rows[0]["lastname"].ToString();
                string timeInDate = DateTime.Parse(row["timeInDate"].ToString()).ToShortDateString();
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = studentID;
                lvItem.SubItems.Add(fullname);
                lvItem.SubItems.Add(dataTablestudent.Rows[0]["designation"].ToString());
                lvItem.SubItems.Add(row["timeIn"].ToString());
                lvItem.SubItems.Add(row["timeOut"].ToString());
                lvItem.SubItems.Add(timeInDate);
                lv_User.Items.Add(lvItem);
            }
        }

        public static void AttendanceItemWithoutPicSearchUser(DataTable dataTable, ListView lv_User, string txt_Search)
        {
            if (dataTable == null) return;

            lv_User.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {

                string studentID = row["studentID"].ToString().ToLower();

                string queryID = CsQueryObject.AllQuery("tbl_user WHERE studentID='" + studentID + "'", "userKey");
                DataTable dataTablestudent = new CsDatabaseGet(queryID, CsModeObject.AllMode).GetTable;

                string fullname = dataTablestudent.Rows[0]["firstname"].ToString() + " " + dataTablestudent.Rows[0]["lastname"].ToString();

                if (studentID.Contains(txt_Search.ToLower()) || fullname.ToLower().Contains(txt_Search.ToLower()))
                {
                    string timeInDate = DateTime.Parse(row["timeInDate"].ToString()).ToShortDateString();

                    ListViewItem lvItem = new ListViewItem();
                    lvItem.Text = row["studentID"].ToString();
                    lvItem.SubItems.Add(fullname);
                    lvItem.SubItems.Add(dataTablestudent.Rows[0]["designation"].ToString());
                    lvItem.SubItems.Add(row["timeIn"].ToString());
                    lvItem.SubItems.Add(row["timeOut"].ToString());
                    lvItem.SubItems.Add(timeInDate);
                    lv_User.Items.Add(lvItem);
                }
            }
        }
    }
}
