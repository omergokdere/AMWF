using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsListviewGridColor
    {

        //Setting listview row color.

        public static void SetGridColor(ListView lv_General)
        {

            for (int i = 0; i < lv_General.Items.Count; i++)
            {
                if (i % 2 != 1)
                {
                    lv_General.Items[i].BackColor = Color.FromArgb(255, 251, 232);
                }
            }
        }
    }
}
