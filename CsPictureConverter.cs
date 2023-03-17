using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsPictureConverter
    {

        //Convert image to binary to store in database

        public static byte[] ToBinary(Image picBox)
        {
            MemoryStream mStream = new MemoryStream();
            picBox.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] convertedImage = mStream.GetBuffer();
            mStream.Close();

            return convertedImage;
        }


        //Convert binary to image to show in the system
        public static Bitmap ToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream(blob);
            Bitmap bm = new Bitmap(Image.FromStream(mStream));
            mStream.SetLength(0);
            mStream.Close();
            return bm;
        }
    }
}
