
using System.Windows.Forms;
namespace Attendance_Monitoring_With_Fingerprint
{
    class CsQueryObject
    {

        //This is all the query object.

        public static string AllQuery(string tableName, string keyField)
        {
            string returnQuery = string.Format("SELECT * FROM {0} ORDER BY {1}", tableName, keyField);
            return returnQuery;
        }


        public static string LoginQuery()
        {
            string parameters = @"WHERE username=@username AND password=@password AND designation='Administrator'";

            string returnQuery = string.Format("SELECT * FROM tbl_user {0}", parameters);
            return returnQuery;
        }

        public static string InsertUserQuery()
        {
            string parameters = @"VALUES  ( @studentID, @firstname, @lastname, @username, @password, @fingerprintID, @designation, @image)";

            string returnQuery = string.Format("INSERT INTO tbl_user (studentID,firstname,lastname,username, password, fingerprintID, designation, image) {0}", parameters);
            return returnQuery;
        }

        public static string InsertAttendanceQuery()
        {
            string parameters = @"VALUES  ( @studentID, @timeIn, @timeInDate)";

            string returnQuery = string.Format("INSERT INTO tbl_attendance (studentID,timeIn,timeInDate) {0}", parameters);
            return returnQuery;
        }
       

        public static string UpdatestudentQuery()
        {
            string parameters = @"SET  firstname=@firstname, lastname=@lastname, username=@username, password=@password, fingerprintID=@fingerprintID, designation=@designation, image=@image
                                    WHERE studentID=@studentID";

            string returnQuery = string.Format("UPDATE tbl_user {0}", parameters);
            return returnQuery;
        }

        public static string UpdateAttendance()
        {
            string parameters = @"SET timeOut=@timeOut
                                    WHERE studentID=@studentID";

            string returnQuery = string.Format("UPDATE tbl_attendance {0}", parameters);
            return returnQuery;
        }


        public static string DeletestudentQuery()
        {
            string parameters = @"WHERE studentID=@studentID";

            string returnQuery = string.Format("DELETE FROM tbl_user {0}", parameters);
            return returnQuery;
        }


        public static string DeleteAttendanceQuery()
        {
            string parameters = @"WHERE studentID=@studentID";

            string returnQuery = string.Format("DELETE FROM tbl_attendance {0}", parameters);
            return returnQuery;
        }

    }
}
