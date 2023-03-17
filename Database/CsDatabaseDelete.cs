using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsDatabaseDelete: CsConnection
    {
        //Initialization of command for delete data in database.
        public static void PerformDelete(string query, string mode)
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
