using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsDatabaseInsert : CsConnection
    {
        //Initialization of command for inserting data in database.

        public static void PerformInsert(string query, string mode)
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
