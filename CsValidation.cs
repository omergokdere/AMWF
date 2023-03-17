using System;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsValidation
    {

        public static bool PerformUserValidation()
        {
            if (String.IsNullOrWhiteSpace(CsstudentObject.firstnameData))
            {
                CsMessageBox.Show("Validation: Firstname is required!", CsMessageBox.OK, "Stop");
                return false;
            }
            if (String.IsNullOrWhiteSpace(CsstudentObject.lastnameData))
            {
                CsMessageBox.Show("Validation: Lastname is required!", CsMessageBox.OK, "Stop");
                return false;
            }

            if (String.IsNullOrWhiteSpace(CsstudentObject.usernameData) && FrmMaintenanceUser.frmUserMaintenance.combo_UserType.Text == "Administrator")
            {
                CsMessageBox.Show("Validation: Username is required!", CsMessageBox.OK, "Stop");
                return false;
            }

            if (String.IsNullOrWhiteSpace(CsstudentObject.passwordData) && FrmMaintenanceUser.frmUserMaintenance.combo_UserType.Text == "Administrator")
            {
                CsMessageBox.Show("Validation: Password is required!", CsMessageBox.OK, "Stop");
                return false;
            }

            if (String.IsNullOrWhiteSpace(CsstudentObject.passwordData) && FrmMaintenanceUser.frmUserMaintenance.combo_UserType.Text != "Administrator" && !FrmMaintenanceUser.isFingerprintAdded)
            {
                CsMessageBox.Show("Validation: Fingerprint is required!", CsMessageBox.OK, "Stop");
                return false;
            }

            return true;
        }
    }
}
