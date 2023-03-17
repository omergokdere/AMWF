using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsAttendanceObject
    {
        //This is all the attendance object.

        private static string studentID;
        public static string studentIDData
        {
            get { return studentID; }
            set { studentID = value; }
        }

        private static string timeIn;
        public static string timeInData
        {
            get { return timeIn; }
            set { timeIn = value; }
        }

        private static string timeOut;
        public static string timeOutnData
        {
            get { return timeOut; }
            set { timeOut = value; }
        }

        private static string timeInDate;
        public static string timeInDateData
        {
            get { return timeInDate; }
            set { timeInDate = value; }
        }
      
    }
}
