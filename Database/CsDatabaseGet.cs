using System;
using System.Collections.Generic;
using System.Data;
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
    class CsDatabaseGet: CsConnection
    {
        private DataTable dataTable;

        public virtual DataTable GetTable
        {
            get { return dataTable; }
        }


        public CsDatabaseGet(string query, string mode)
        {
            dataTable = FetchDatabase(query, mode);
        }

        //Initialization of command for fetching data in database.
        protected virtual DataTable FetchDatabase(string query, string mode)
        {
            DataTable returnVal = null;

            try
            {
                EstablishConnection();
                MySqlCommand cmd = new CsParameterHandler(query, mode).GetCommand;

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                returnVal = dataTable;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return returnVal;
        }
    }
}
