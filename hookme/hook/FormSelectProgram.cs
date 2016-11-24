using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nektra.Deviare2;
using System.Collections;

namespace hook
{
    public partial class FormSelectProgram : Form
    {
        public NktProcess returnedValue = null;

        public FormSelectProgram()
        {
            InitializeComponent();
        }

        private void FormSelectProgram_Load(object sender, EventArgs e)
        {
            RefreshProcess();
            tbSearch.Select();
        }

        private void RefreshProcess()
        {
            lbProcess.Items.Clear();

            foreach (NktProcess process in Program.hook.spyMgr.Processes())
            {
                wrappers.ProcessWrapper processWr = new wrappers.ProcessWrapper(process);
                lbProcess.Items.Add(processWr);
            }

        }

        private void lbProcess_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            StartSelectedProcess();
        }

        private void StartSelectedProcess()
        {
            if (lbProcess.SelectedItem == null)
                return;

            wrappers.ProcessWrapper wrapper = (wrappers.ProcessWrapper)lbProcess.SelectedItem;
            returnedValue = wrapper.process;
            this.Close();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            RefreshProcess();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartSelectedProcess();
                e.Handled = true;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string search = tbSearch.Text;
            if (string.IsNullOrEmpty(search))
            {
                lbProcess.SelectedIndex = -1;
                return;
            }

            for (int i = 0; i < lbProcess.Items.Count; i++)
            {
                if (lbProcess.Items[i].ToString().ToLower().StartsWith(search.ToLower()))
                {
                    lbProcess.SelectedIndex = i;
                    return;
                }
            }

            lbProcess.SelectedIndex = -1;
        }
    }
}
