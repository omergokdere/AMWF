using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsConnection
    {
        public static MySqlConnection connection = null;

        //Connecting and openning the database to the system.
        public static void EstablishConnection()
        {

            try
            {
                connection = new MySqlConnection(string.Format("SERVER={0}; PORT={1}; USERNAME={2}; PASSWORD={3}; DATABASE={4};",
                    FetchDatabaseLocation()[0], FetchDatabaseLocation()[1], FetchDatabaseLocation()[2], FetchDatabaseLocation()[3], FetchDatabaseLocation()[4]));
                connection.Open();

            }
            catch(Exception){}
        }

        //Read the text file of the system database configuration
        public static string[] FetchDatabaseLocation()
        {
            string[] returnData = new string[5];

            try
            {
                StreamReader file = new StreamReader(Directory.GetCurrentDirectory() + @"\databaseconfig.txt");

                returnData = file.ReadLine().Split('#');
                file.Close();
            }
            catch {}
            return returnData;

        }
    }
}
