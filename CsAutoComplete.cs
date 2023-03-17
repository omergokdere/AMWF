using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsAutoComplete
    {

        //This method is for populating the search textbox of names and user ID for autocomplete feature.
        public static void  SetTextBoxAutoComplete(TextBox txt_Search, string table, string ID)
        {
            txt_Search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_Search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            
            string query = CsQueryObject.AllQuery(table, ID + " DESC");
            DataTable dataTable = new CsDatabaseGet(query, CsModeObject.AllMode).GetTable;

            foreach (DataRow row in dataTable.Rows)
            {
                string studentID = row[ID].ToString();


                string queryID = CsQueryObject.AllQuery("tbl_user WHERE studentID='" + studentID + "'", "userKey");
                DataTable dataTablestudent = new CsDatabaseGet(queryID, CsModeObject.AllMode).GetTable;

                string fullname = dataTablestudent.Rows[0]["firstname"].ToString() + " " + dataTablestudent.Rows[0]["lastname"].ToString();
                
                collection.Add(row[ID].ToString());
                collection.Add(fullname);
            }

            txt_Search.AutoCompleteCustomSource = collection;
        }
    }
}
