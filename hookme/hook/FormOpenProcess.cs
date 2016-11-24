using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace hook
{
    public partial class FormOpenProcess : Form
    {
        public Process p = null;

        public FormOpenProcess()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            p = new Process();
            p.StartInfo.FileName = tbExPath.Text;
            p.StartInfo.Arguments = tbArguments.Text;

            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            p = null;
            this.Close();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = false;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbExPath.Text = ofd.FileName;
            }
        }
    }
}
