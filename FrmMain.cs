using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring_With_Fingerprint
{
    public partial class FrmMain : Form
    {
        public static FrmMain frmMain;
        public FrmMain()
        {
            frmMain = this;
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //fade in effect
            this.FormClosing += MainPage_FormClosed; 
            CsFormFadeEffect.InitializedFadeEffect(this, tm_FadeEffect);
            pnl_Main.Controls.Add(new UsrConLogin());

            //try
            //{
            //    CsInitializePort.serialPort.WriteLine("cancel");

            //}
            //catch (Exception)
            //{
                
            //}

        }

        private void MainPage_FormClosed(object sender, FormClosingEventArgs e)
        {
            try
            {
                CsInitializePort.serialPort.WriteLine("cancel");
                CsInitializePort.serialPort.WriteLine("exit");

            }
            catch (Exception)
            {

            }
            

        }

        private void tm_FadeEffect_Tick(object sender, EventArgs e)
        {
            CsFormFadeEffect.Open(this, tm_FadeEffect);

        }

    }
}
