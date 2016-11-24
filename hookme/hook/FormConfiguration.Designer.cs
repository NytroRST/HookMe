namespace hook
{
    partial class FormConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguration));
            this.label1 = new System.Windows.Forms.Label();
            this.tbDeviareLicense = new System.Windows.Forms.TextBox();
            this.linkDeviare = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLicensing = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPlugins = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearchPath = new System.Windows.Forms.TextBox();
            this.btRemoveSearchPath = new System.Windows.Forms.Button();
            this.btAddSearchPath = new System.Windows.Forms.Button();
            this.lbSearchPath = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tabHooks = new System.Windows.Forms.TabPage();
            this.cbSend = new System.Windows.Forms.CheckBox();
            this.cbRecv = new System.Windows.Forms.CheckBox();
            this.cbSendTo = new System.Windows.Forms.CheckBox();
            this.cbRecvFrom = new System.Windows.Forms.CheckBox();
            this.cbWsaSend = new System.Windows.Forms.CheckBox();
            this.cbEncryptMessage = new System.Windows.Forms.CheckBox();
            this.cbDecryptMessage = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbWsaSendTo = new System.Windows.Forms.CheckBox();
            this.cbWsaRecv = new System.Windows.Forms.CheckBox();
            this.cbWsaRecvFrom = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabLicensing.SuspendLayout();
            this.tabPlugins.SuspendLayout();
            this.tabHooks.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deviare license (Base64)";
            // 
            // tbDeviareLicense
            // 
            this.tbDeviareLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeviareLicense.Location = new System.Drawing.Point(6, 19);
            this.tbDeviareLicense.Multiline = true;
            this.tbDeviareLicense.Name = "tbDeviareLicense";
            this.tbDeviareLicense.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDeviareLicense.Size = new System.Drawing.Size(660, 104);
            this.tbDeviareLicense.TabIndex = 1;
            // 
            // linkDeviare
            // 
            this.linkDeviare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkDeviare.AutoSize = true;
            this.linkDeviare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkDeviare.Location = new System.Drawing.Point(618, 3);
            this.linkDeviare.Name = "linkDeviare";
            this.linkDeviare.Size = new System.Drawing.Size(48, 13);
            this.linkDeviare.TabIndex = 5;
            this.linkDeviare.TabStop = true;
            this.linkDeviare.Text = "Get one!";
            this.linkDeviare.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDeviare_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabLicensing);
            this.tabControl1.Controls.Add(this.tabPlugins);
            this.tabControl1.Controls.Add(this.tabHooks);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(682, 236);
            this.tabControl1.TabIndex = 6;
            // 
            // tabLicensing
            // 
            this.tabLicensing.Controls.Add(this.label2);
            this.tabLicensing.Controls.Add(this.label1);
            this.tabLicensing.Controls.Add(this.linkDeviare);
            this.tabLicensing.Controls.Add(this.tbDeviareLicense);
            this.tabLicensing.Location = new System.Drawing.Point(4, 22);
            this.tabLicensing.Name = "tabLicensing";
            this.tabLicensing.Padding = new System.Windows.Forms.Padding(3);
            this.tabLicensing.Size = new System.Drawing.Size(674, 210);
            this.tabLicensing.TabIndex = 0;
            this.tabLicensing.Text = "Licensing";
            this.tabLicensing.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(660, 71);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // tabPlugins
            // 
            this.tabPlugins.Controls.Add(this.label5);
            this.tabPlugins.Controls.Add(this.label4);
            this.tabPlugins.Controls.Add(this.tbSearchPath);
            this.tabPlugins.Controls.Add(this.btRemoveSearchPath);
            this.tabPlugins.Controls.Add(this.btAddSearchPath);
            this.tabPlugins.Controls.Add(this.lbSearchPath);
            this.tabPlugins.Controls.Add(this.label3);
            this.tabPlugins.Location = new System.Drawing.Point(4, 22);
            this.tabPlugins.Name = "tabPlugins";
            this.tabPlugins.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlugins.Size = new System.Drawing.Size(674, 210);
            this.tabPlugins.TabIndex = 1;
            this.tabPlugins.Text = "Plugins";
            this.tabPlugins.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Local folder";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 65);
            this.label4.TabIndex = 5;
            this.label4.Text = "Folders where the python plugins will search for imports.\r\n\r\nExample:\r\nc:\\python2" +
                "6\\libs\r\nc:\\python27\\libs\r\n";
            // 
            // tbSearchPath
            // 
            this.tbSearchPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSearchPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSearchPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.tbSearchPath.Location = new System.Drawing.Point(74, 108);
            this.tbSearchPath.Name = "tbSearchPath";
            this.tbSearchPath.Size = new System.Drawing.Size(493, 20);
            this.tbSearchPath.TabIndex = 4;
            this.tbSearchPath.Text = "c:\\";
            // 
            // btRemoveSearchPath
            // 
            this.btRemoveSearchPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btRemoveSearchPath.Image = global::hook.Properties.Resources.delete;
            this.btRemoveSearchPath.Location = new System.Drawing.Point(627, 107);
            this.btRemoveSearchPath.Name = "btRemoveSearchPath";
            this.btRemoveSearchPath.Size = new System.Drawing.Size(39, 23);
            this.btRemoveSearchPath.TabIndex = 3;
            this.btRemoveSearchPath.UseVisualStyleBackColor = true;
            this.btRemoveSearchPath.Click += new System.EventHandler(this.btRemoveSearchPath_Click);
            // 
            // btAddSearchPath
            // 
            this.btAddSearchPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAddSearchPath.Image = global::hook.Properties.Resources.add;
            this.btAddSearchPath.Location = new System.Drawing.Point(582, 107);
            this.btAddSearchPath.Name = "btAddSearchPath";
            this.btAddSearchPath.Size = new System.Drawing.Size(39, 23);
            this.btAddSearchPath.TabIndex = 2;
            this.btAddSearchPath.UseVisualStyleBackColor = true;
            this.btAddSearchPath.Click += new System.EventHandler(this.btAddSearchPath_Click);
            // 
            // lbSearchPath
            // 
            this.lbSearchPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearchPath.FormattingEnabled = true;
            this.lbSearchPath.Location = new System.Drawing.Point(6, 19);
            this.lbSearchPath.Name = "lbSearchPath";
            this.lbSearchPath.Size = new System.Drawing.Size(662, 82);
            this.lbSearchPath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search paths";
            // 
            // btCancel
            // 
            this.btCancel.Image = global::hook.Properties.Resources.x;
            this.btCancel.Location = new System.Drawing.Point(608, 254);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(86, 27);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Cancel";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Image = global::hook.Properties.Resources.v2;
            this.btSave.Location = new System.Drawing.Point(12, 254);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(86, 27);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tabHooks
            // 
            this.tabHooks.Controls.Add(this.label10);
            this.tabHooks.Controls.Add(this.groupBox2);
            this.tabHooks.Controls.Add(this.groupBox1);
            this.tabHooks.Location = new System.Drawing.Point(4, 22);
            this.tabHooks.Name = "tabHooks";
            this.tabHooks.Size = new System.Drawing.Size(674, 210);
            this.tabHooks.TabIndex = 2;
            this.tabHooks.Text = "Hooks";
            this.tabHooks.UseVisualStyleBackColor = true;
            // 
            // cbSend
            // 
            this.cbSend.AutoSize = true;
            this.cbSend.Location = new System.Drawing.Point(19, 46);
            this.cbSend.Name = "cbSend";
            this.cbSend.Size = new System.Drawing.Size(107, 17);
            this.cbSend.TabIndex = 0;
            this.cbSend.Text = "WS2_32.dll!send";
            this.cbSend.UseVisualStyleBackColor = true;
            // 
            // cbRecv
            // 
            this.cbRecv.AutoSize = true;
            this.cbRecv.Location = new System.Drawing.Point(177, 46);
            this.cbRecv.Name = "cbRecv";
            this.cbRecv.Size = new System.Drawing.Size(105, 17);
            this.cbRecv.TabIndex = 1;
            this.cbRecv.Text = "WS2_32.dll!recv";
            this.cbRecv.UseVisualStyleBackColor = true;
            // 
            // cbSendTo
            // 
            this.cbSendTo.AutoSize = true;
            this.cbSendTo.Location = new System.Drawing.Point(19, 69);
            this.cbSendTo.Name = "cbSendTo";
            this.cbSendTo.Size = new System.Drawing.Size(116, 17);
            this.cbSendTo.TabIndex = 2;
            this.cbSendTo.Text = "WS2_32.dll!sendto";
            this.cbSendTo.UseVisualStyleBackColor = true;
            // 
            // cbRecvFrom
            // 
            this.cbRecvFrom.AutoSize = true;
            this.cbRecvFrom.Location = new System.Drawing.Point(177, 69);
            this.cbRecvFrom.Name = "cbRecvFrom";
            this.cbRecvFrom.Size = new System.Drawing.Size(125, 17);
            this.cbRecvFrom.TabIndex = 3;
            this.cbRecvFrom.Text = "WS2_32.dll!recvfrom";
            this.cbRecvFrom.UseVisualStyleBackColor = true;
            // 
            // cbWsaSend
            // 
            this.cbWsaSend.AutoSize = true;
            this.cbWsaSend.Location = new System.Drawing.Point(19, 92);
            this.cbWsaSend.Name = "cbWsaSend";
            this.cbWsaSend.Size = new System.Drawing.Size(134, 17);
            this.cbWsaSend.TabIndex = 4;
            this.cbWsaSend.Text = "WS2_32.dll!WSASend";
            this.cbWsaSend.UseVisualStyleBackColor = true;
            // 
            // cbEncryptMessage
            // 
            this.cbEncryptMessage.AutoSize = true;
            this.cbEncryptMessage.Location = new System.Drawing.Point(24, 46);
            this.cbEncryptMessage.Name = "cbEncryptMessage";
            this.cbEncryptMessage.Size = new System.Drawing.Size(161, 17);
            this.cbEncryptMessage.TabIndex = 5;
            this.cbEncryptMessage.Text = "Secur32.dll!EncryptMessage";
            this.cbEncryptMessage.UseVisualStyleBackColor = true;
            // 
            // cbDecryptMessage
            // 
            this.cbDecryptMessage.AutoSize = true;
            this.cbDecryptMessage.Location = new System.Drawing.Point(23, 111);
            this.cbDecryptMessage.Name = "cbDecryptMessage";
            this.cbDecryptMessage.Size = new System.Drawing.Size(162, 17);
            this.cbDecryptMessage.TabIndex = 6;
            this.cbDecryptMessage.Text = "Secur32.dll!DecryptMessage";
            this.cbDecryptMessage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbWsaRecvFrom);
            this.groupBox1.Controls.Add(this.cbWsaRecv);
            this.groupBox1.Controls.Add(this.cbWsaSendTo);
            this.groupBox1.Controls.Add(this.cbSend);
            this.groupBox1.Controls.Add(this.cbRecv);
            this.groupBox1.Controls.Add(this.cbWsaSend);
            this.groupBox1.Controls.Add(this.cbSendTo);
            this.groupBox1.Controls.Add(this.cbRecvFrom);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 146);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WS2_32 API";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbDecryptMessage);
            this.groupBox2.Controls.Add(this.cbEncryptMessage);
            this.groupBox2.Location = new System.Drawing.Point(385, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 146);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Secur32 API (SSL)";
            // 
            // cbWsaSendTo
            // 
            this.cbWsaSendTo.AutoSize = true;
            this.cbWsaSendTo.Enabled = false;
            this.cbWsaSendTo.Location = new System.Drawing.Point(19, 115);
            this.cbWsaSendTo.Name = "cbWsaSendTo";
            this.cbWsaSendTo.Size = new System.Drawing.Size(147, 17);
            this.cbWsaSendTo.TabIndex = 5;
            this.cbWsaSendTo.Text = "WS2_32.dll!WSASendTo";
            this.cbWsaSendTo.UseVisualStyleBackColor = true;
            // 
            // cbWsaRecv
            // 
            this.cbWsaRecv.AutoSize = true;
            this.cbWsaRecv.Location = new System.Drawing.Point(177, 92);
            this.cbWsaRecv.Name = "cbWsaRecv";
            this.cbWsaRecv.Size = new System.Drawing.Size(135, 17);
            this.cbWsaRecv.TabIndex = 6;
            this.cbWsaRecv.Text = "WS2_32.dll!WSARecv";
            this.cbWsaRecv.UseVisualStyleBackColor = true;
            // 
            // cbWsaRecvFrom
            // 
            this.cbWsaRecvFrom.AutoSize = true;
            this.cbWsaRecvFrom.Enabled = false;
            this.cbWsaRecvFrom.Location = new System.Drawing.Point(177, 115);
            this.cbWsaRecvFrom.Name = "cbWsaRecvFrom";
            this.cbWsaRecvFrom.Size = new System.Drawing.Size(158, 17);
            this.cbWsaRecvFrom.TabIndex = 7;
            this.cbWsaRecvFrom.Text = "WS2_32.dll!WSARecvFrom";
            this.cbWsaRecvFrom.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(174, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Incoming";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(16, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Outcoming";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(21, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Outcoming";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(20, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Incoming";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(8, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(653, 50);
            this.label10.TabIndex = 9;
            this.label10.Text = "IMPORTANT: If you change any API hook while a process is being hooked the changes" +
                " won\'t take effect until you hook again the process.";
            // 
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 293);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.FormConfiguration_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLicensing.ResumeLayout(false);
            this.tabLicensing.PerformLayout();
            this.tabPlugins.ResumeLayout(false);
            this.tabPlugins.PerformLayout();
            this.tabHooks.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDeviareLicense;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.LinkLabel linkDeviare;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLicensing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPlugins;
        private System.Windows.Forms.TextBox tbSearchPath;
        private System.Windows.Forms.Button btRemoveSearchPath;
        private System.Windows.Forms.Button btAddSearchPath;
        private System.Windows.Forms.ListBox lbSearchPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabHooks;
        private System.Windows.Forms.CheckBox cbDecryptMessage;
        private System.Windows.Forms.CheckBox cbEncryptMessage;
        private System.Windows.Forms.CheckBox cbWsaSend;
        private System.Windows.Forms.CheckBox cbRecvFrom;
        private System.Windows.Forms.CheckBox cbSendTo;
        private System.Windows.Forms.CheckBox cbRecv;
        private System.Windows.Forms.CheckBox cbSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbWsaRecvFrom;
        private System.Windows.Forms.CheckBox cbWsaRecv;
        private System.Windows.Forms.CheckBox cbWsaSendTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
    }
}