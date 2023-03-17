using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsInitializePort
    {
        public static SerialPort serialPort;

        //Getting the port the you set in database configuration
        private static string GetPort()
        {
            string returnData = string.Empty;

            try
            {
                StreamReader file = new StreamReader(Directory.GetCurrentDirectory() + @"\databaseconfig.txt");

                returnData = file.ReadLine().Split('#')[5];
                file.Close();
            }
            catch { }
            return returnData;
        }

        //Opening the port.
        public static bool InittializedPort()
        {
            try
            {
                serialPort = new SerialPort();
                serialPort.BaudRate = 9600;
                serialPort.PortName = GetPort();
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.ReadTimeout = 300;
                serialPort.WriteTimeout = 300;
                serialPort.Open();
                return true;
            }
            catch (Exception)
            {
                CsMessageBox.Show("Fingerprint Sensor Port doesn't initialized!", CsMessageBox.OK, "Error");
                return false;
            }

        }
    }
}
