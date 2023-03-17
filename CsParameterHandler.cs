using System;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;


namespace Attendance_Monitoring_With_Fingerprint
{
    class CsParameterHandler : CsConnection
    {
        private MySqlCommand command;
        public MySqlCommand GetCommand
        {
            get { return command; }
        }


        //Checking the mode you use for executing database

        public CsParameterHandler(string query, string mode)
        {
            if (mode == CsModeObject.AllMode) command = GetAllCommand(query);
            if (mode == CsModeObject.InsertstudentMode) command = InsertUser(query);
            if (mode == CsModeObject.InsertAttendanceMode) command = InsertAttendance(query);
            if (mode == CsModeObject.UpdatestudentMode) command = UpdateUser(query);
            if (mode == CsModeObject.DeleteEmpoyeeMode) command = DeleteUser(query);
            if (mode == CsModeObject.DeleteAttendanceMode) command = DeleteAttendane(query);
            if (mode == CsModeObject.LoginMode) command = Login(query);
            if (mode == CsModeObject.SearchUserIDMode) command = SearchstudentID(query);
            if (mode == CsModeObject.UpdateAttendanceMode) command = UpdateAttendance(query);


        }

        //All the codes below is method for deifferent modes.


        private MySqlCommand Login(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.Add(new MySqlParameter("@username", CsLoginObject.usernameData));
            cmd.Parameters.Add(new MySqlParameter("@password", CsLoginObject.passwordData));
            return cmd;
        }

        private MySqlCommand GetAllCommand(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            return cmd;
        }

        private MySqlCommand SearchstudentID(string query)
        {
            MessageBox.Show(CsstudentObject.studentIDData);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.Add(new MySqlParameter("@studentID", CsstudentObject.studentIDData));

            return cmd;
        }

        private MySqlCommand InsertUser(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.Add(new MySqlParameter("@studentID", CsstudentObject.studentIDData));
            cmd.Parameters.Add(new MySqlParameter("@firstname", CsstudentObject.firstnameData));
            cmd.Parameters.Add(new MySqlParameter("@lastname", CsstudentObject.lastnameData));
            cmd.Parameters.Add(new MySqlParameter("@username", CsstudentObject.usernameData));
            cmd.Parameters.Add(new MySqlParameter("@password", CsstudentObject.passwordData));
            cmd.Parameters.Add(new MySqlParameter("@fingerprintID", CsstudentObject.fingerprintIDData));
            cmd.Parameters.Add(new MySqlParameter("@designation", CsstudentObject.designationData));
            cmd.Parameters.Add(new MySqlParameter("@image", CsPictureConverter.ToBinary(CsstudentObject.pictureData)));
            return cmd;
        }

        private MySqlCommand InsertAttendance(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.Add(new MySqlParameter("@studentID", CsAttendanceObject.studentIDData));
            cmd.Parameters.Add(new MySqlParameter("@timeIn", CsAttendanceObject.timeInData));
            cmd.Parameters.Add(new MySqlParameter("@timeInDate", DateTime.Now));
            return cmd;
        }


        private MySqlCommand UpdateUser(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.Add(new MySqlParameter("@firstname", CsstudentObject.firstnameData));
            cmd.Parameters.Add(new MySqlParameter("@lastname", CsstudentObject.lastnameData));
            cmd.Parameters.Add(new MySqlParameter("@username", CsstudentObject.usernameData));
            cmd.Parameters.Add(new MySqlParameter("@password", CsstudentObject.passwordData));
            cmd.Parameters.Add(new MySqlParameter("@fingerprintID", CsstudentObject.fingerprintIDData));
            cmd.Parameters.Add(new MySqlParameter("@designation", CsstudentObject.designationData));
            cmd.Parameters.Add(new MySqlParameter("@image", CsPictureConverter.ToBinary(CsstudentObject.pictureData)));
            cmd.Parameters.Add(new MySqlParameter("@studentID", CsstudentObject.studentIDData));

            return cmd;
        }

        private MySqlCommand UpdateAttendance(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.Add(new MySqlParameter("@timeOut", CsAttendanceObject.timeOutnData));
            cmd.Parameters.Add(new MySqlParameter("@studentID", CsAttendanceObject.studentIDData));

            return cmd;
        }


        private MySqlCommand DeleteUser(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.Add(new MySqlParameter("@studentID", CsstudentObject.studentIDData));
            return cmd;
        }

        private MySqlCommand DeleteAttendane(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.Add(new MySqlParameter("@studentID", CsstudentObject.studentIDData));
            return cmd;
        }

    }
}
