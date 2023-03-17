using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsAutoID
    {
        //This method is for auto increment of the user ID to prevent double entry.
        public static string GetIncrementedID(DataTable dataTable, string stringFormat, string ID)
        {
            string returnID = stringFormat + "0001";

            if (dataTable == null) return returnID;

            foreach (DataRow row in dataTable.Rows)
            {
                string userID = row[ID].ToString();

                int extractedDigit = int.Parse(userID.Substring(stringFormat.Length));
                int incrementedID = extractedDigit + 1;

                returnID = stringFormat + incrementedID.ToString("0000");
                FrmMaintenanceUser.frmUserMaintenance.lbl_FingerprintID.Text = incrementedID.ToString();

            }

            return returnID;
        }
    }

}
