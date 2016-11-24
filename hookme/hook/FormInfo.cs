using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hook
{
    public partial class FormInfo : Form
    {
        public enum IconType
        {
            Error = 0,
            OK = 1,
            Info = 2
        }

        int speed = 10;
        private string message = string.Empty;
        double dec = 0.002;
        int retardoMS = 1;
        public IconType iconType = IconType.OK;


        public FormInfo(string message, int retardoMS, IconType iconType)
        {
            if (retardoMS == 0)
                retardoMS = 1;
            this.retardoMS = retardoMS;

            this.iconType = iconType;
            this.message = message;
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            timerDelay.Interval = retardoMS;
            timerClose.Interval = speed;
            this.lbMessage.Text = message;

            pcIcon.Image = imageList1.Images[(int)iconType];
        }

        private void timerDelay_Tick(object sender, EventArgs e)
        {
            timerClose.Enabled = true;
            timerDelay.Enabled = false;
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            this.Opacity -= dec;

            if (this.Opacity < 0.90)
            {
                this.dec = 0.10;
            }

            if (this.Opacity < 0.20)
            {
                this.Close();
            }
        }
    }
}
