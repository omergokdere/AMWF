using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsOpenDialog
    {

        //Opening dialog box for choosing student image

        public static void ImportPicture(PictureBox picBox)
        {
            OpenFileDialog openfileD = new OpenFileDialog();
            openfileD.InitialDirectory = "C:/Picture/";
            openfileD.Filter = "PNG|*.png*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
            openfileD.FilterIndex = 1;

            DialogResult dialogResult = openfileD.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    Bitmap orignalImage = new Bitmap(Image.FromFile(openfileD.FileName));
                    Bitmap resizedImage = new Bitmap(orignalImage, new Size(250, 250));
                    picBox.Image = resizedImage;
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                catch (Exception)
                {
                    CsMessageBox.Show("Error: File type is not valid!",CsMessageBox.OK, "Error");
                }
            }
        }
    }
}
