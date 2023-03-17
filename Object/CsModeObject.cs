using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsModeObject
    {
        //This is all the mode object.

        private const string ALL = "All";
        public static string AllMode
        {
            get { return ALL; }
        }


        private const string Insertstudent = "InsertEmpoyee";
        public static string InsertstudentMode
        {
            get { return Insertstudent; }
        }

        private const string InsertAttendance = "InsertAttendance";
        public static string InsertAttendanceMode
        {
            get { return InsertAttendance; }
        }

        private const string Updatestudent = "UpdateEmpoyee";
        public static string UpdatestudentMode
        {
            get { return Updatestudent; }
        }


        private const string UpdateAttendance = "UpdateAttendance";
        public static string UpdateAttendanceMode
        {
            get { return UpdateAttendance; }
        }


        private const string DeleteAttendance = "DeleteAttendance";
        public static string DeleteAttendanceMode
        {
            get { return DeleteAttendance; }
        }

        private const string DeleteEmpoyee = "DeleteEmpoyee";
        public static string DeleteEmpoyeeMode
        {
            get { return DeleteEmpoyee; }
        }

        private const string SearchUserID = "SearchUserID";
        public static string SearchUserIDMode
        {
            get { return SearchUserID; }
        }


        private const string Login = "Login";
        public static string LoginMode
        {
            get { return Login; }
        }
    }
}
