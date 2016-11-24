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
    public partial class FormLicense : Form
    {
        public FormLicense()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
