using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Be.Windows.Forms;
using System.IO;

namespace hook
{
    public partial class FormMatchReplace : Form
    {
        public MatchAndReplace.MatchAndReplace returnedMatch = null;

        private DynamicFileByteProvider dynamicFileByteProviderMatch;
        private DynamicFileByteProvider dynamicFileByteProviderReplace;
        private MemoryStream mStreamMatch;
        private MemoryStream mStreamReplace;

        public FormMatchReplace()
        {
            InitializeComponent();
        }

        private void FormMatchReplace_Load(object sender, EventArgs e)
        {
            mStreamMatch = new MemoryStream();
            mStreamReplace = new MemoryStream();

            dynamicFileByteProviderReplace = new DynamicFileByteProvider(mStreamReplace);
            dynamicFileByteProviderMatch = new DynamicFileByteProvider(mStreamMatch);

            hbReplace.ByteProvider = dynamicFileByteProviderReplace;
            hbMatch.ByteProvider = dynamicFileByteProviderMatch;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            returnedMatch = null;
            this.Close();
        }

        private bool CreateMatch()
        {
            bool rIncomming = false;
            bool rOutcomming = false;
            string name = tbName.Text;

            if (cbType.Text.ToLower() == "In".ToLower())
                rIncomming = true;
            else if (cbType.Text.ToLower() == "Out".ToLower())
                rOutcomming = true;
            else
            {
                rIncomming = true;
                rOutcomming = true;
            }

            try
            {
                hbMatch.ByteProvider.ApplyChanges();
                hbReplace.ByteProvider.ApplyChanges();
                mStreamReplace.Seek(0, SeekOrigin.Begin);
                mStreamMatch.Seek(0, SeekOrigin.Begin);
                byte[] replace = new byte[mStreamReplace.Length];
                byte[] match = new byte[mStreamMatch.Length];
                mStreamMatch.Seek(0, SeekOrigin.Begin);
                mStreamReplace.Seek(0, SeekOrigin.Begin);
                mStreamReplace.Read(replace, 0, replace.Length);
                mStreamMatch.Read(match, 0, match.Length);
                returnedMatch = new MatchAndReplace.MatchAndReplace(name, match, replace, rIncomming, rOutcomming);
            }
            catch
            {
                return false;
            }

            return true; 
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Please, specify a name for this rule", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (CreateMatch())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void cbType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
