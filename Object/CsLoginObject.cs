using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsLoginObject
    {

        //This is all the object for the user who login.

        private static Image picture = Properties.Resources.icon_noimageuser;

        public static Image pictureData
        {
            get { return picture; }
            set { picture = value; }
        }

        private static string studentID;
        public static string studentIDData
        {
            get { return studentID; }
            set { studentID = value; }
        }

        private static string fingerprintID;
        public static string fingerprintIDData
        {
            get { return fingerprintID; }
            set { fingerprintID = value; }
        }

        private static string firstname;
        public static string firstnameData
        {
            get { return firstname; }
            set { firstname = value; }
        }

        private static string lastname;
        public static string lastnameData
        {
            get { return lastname; }
            set { lastname = value; }
        }

        private static string username;
        public static string usernameData
        {
            get { return username; }
            set { username = value; }
        }

        private static string password;
        public static string passwordData
        {
            get { return password; }
            set { password = value; }
        }
    }
}
