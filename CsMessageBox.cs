using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsMessageBox
    {

        //Setting up messagebox data

        public const string YESNO = "YesNo";
        public const string OK = "Ok";
        public static bool Show(string message, string type, string iconType)
        {
            //FrmMain.frmMain.Opacity = .7;
            FrmMessageBox frmMessageBox = new FrmMessageBox();
            FrmMessageBox.messageBoxMessage = message;
            FrmMessageBox.messageBoxType = type;
            FrmMessageBox.messageBoxIcon = iconType;

            frmMessageBox.ShowDialog();
            //FrmMain.frmMain.Opacity = 1;
            return FrmMessageBox.messageBoxReturnVal;
        }
    }
}
