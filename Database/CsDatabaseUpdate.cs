using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsDatabaseUpdate : CsConnection
    {
        //Initialization of command for updating data in database.

        public static void PerformUpdate(string query, string mode)
        {
            try
            {
                EstablishConnection();
                MySqlCommand cmd = new CsParameterHandler(query, mode).GetCommand;
                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
