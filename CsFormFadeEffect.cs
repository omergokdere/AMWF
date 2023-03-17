using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring_With_Fingerprint
{
    class CsFormFadeEffect
    {
        //This method is for setting the opacity of the form to 0 and initialize the fade-in effect
        public static void InitializedFadeEffect(Form toFadeForm, Timer tm_General)
        {
            toFadeForm.Opacity = 0;
            tm_General.Start();
        }

        //This method is for incrementing the opacity of the form for fade-in effect.
        public static void Open(Form toFadeForm, Timer tm_General)
        {
            if (toFadeForm.Opacity <= 1.00)
            {
                toFadeForm.Opacity += .050;
                return;
            }

            tm_General.Stop();
        }
    }
}
