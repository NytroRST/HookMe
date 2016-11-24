namespace hook
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.hexBox = new Be.Windows.Forms.HexBox();
            this.cbIntercepting = new System.Windows.Forms.CheckBox();
            this.lbMatches = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabIntercept = new System.Windows.Forms.TabPage();
            this.tabLower = new System.Windows.Forms.TabControl();
            this.tabSearcher = new System.Windows.Forms.TabPage();
            this.hexBoxSearch = new Be.Windows.Forms.HexBox();
            this.lbFunction = new System.Windows.Forms.Label();
            this.tabMachReplace = new System.Windows.Forms.TabPage();
            this.dgvMatchAndReplace = new System.Windows.Forms.DataGridView();
            this.Enabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Match = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Replace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMatchReplace = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabFuzzer = new System.Windows.Forms.TabPage();
            this.tabRepeater = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btRepeaterSend = new System.Windows.Forms.Button();
            this.tbRepeaterSocketID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hexboxRepeater = new Be.Windows.Forms.HexBox();
            this.tabPlugins = new System.Windows.Forms.TabPage();
            this.tbInputTxtScripts = new System.Windows.Forms.TextBox();
            this.lbLoadedScripts = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apiOutputConsole = new System.Windows.Forms.TextBox();
            this.tabSponsors = new System.Windows.Forms.TabPage();
            this.wBrowser = new System.Windows.Forms.WebBrowser();
            this.linkSponsorUs = new System.Windows.Forms.LinkLabel();
            this.lbSponsors = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unhookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btForward = new System.Windows.Forms.Button();
            this.btDrop = new System.Windows.Forms.Button();
            this.newMatchReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMatchReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.btUnloadPlugin = new System.Windows.Forms.Button();
            this.btLoadPlugin = new System.Windows.Forms.Button();
            this.listViewLog = new FOCA.Search.ListViewEx();
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabIntercept.SuspendLayout();
            this.tabLower.SuspendLayout();
            this.tabSearcher.SuspendLayout();
            this.tabMachReplace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchAndReplace)).BeginInit();
            this.contextMatchReplace.SuspendLayout();
            this.tabRepeater.SuspendLayout();
            this.tabPlugins.SuspendLayout();
            this.tabSponsors.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.licenseToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(639, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // hexBox
            // 
            this.hexBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hexBox.BoldFont = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBox.LineInfoForeColor = System.Drawing.Color.Empty;
            this.hexBox.LineInfoVisible = true;
            this.hexBox.Location = new System.Drawing.Point(0, 39);
            this.hexBox.Name = "hexBox";
            this.hexBox.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBox.Size = new System.Drawing.Size(631, 132);
            this.hexBox.StringViewVisible = true;
            this.hexBox.TabIndex = 4;
            this.hexBox.VScrollBarVisible = true;
            // 
            // cbIntercepting
            // 
            this.cbIntercepting.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbIntercepting.Checked = true;
            this.cbIntercepting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIntercepting.Location = new System.Drawing.Point(210, 5);
            this.cbIntercepting.Name = "cbIntercepting";
            this.cbIntercepting.Size = new System.Drawing.Size(150, 28);
            this.cbIntercepting.TabIndex = 5;
            this.cbIntercepting.Text = "Intercept";
            this.cbIntercepting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbIntercepting.UseVisualStyleBackColor = true;
            this.cbIntercepting.CheckedChanged += new System.EventHandler(this.cbIntercepting_CheckedChanged);
            // 
            // lbMatches
            // 
            this.lbMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMatches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMatches.Location = new System.Drawing.Point(547, 8);
            this.lbMatches.Name = "lbMatches";
            this.lbMatches.Size = new System.Drawing.Size(72, 45);
            this.lbMatches.TabIndex = 11;
            this.lbMatches.Text = "0 matches";
            this.lbMatches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabIntercept);
            this.tabControl1.Controls.Add(this.tabMachReplace);
            this.tabControl1.Controls.Add(this.tabFuzzer);
            this.tabControl1.Controls.Add(this.tabRepeater);
            this.tabControl1.Controls.Add(this.tabPlugins);
            this.tabControl1.Controls.Add(this.tabSponsors);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 283);
            this.tabControl1.TabIndex = 12;
            // 
            // tabIntercept
            // 
            this.tabIntercept.Controls.Add(this.btForward);
            this.tabIntercept.Controls.Add(this.tabLower);
            this.tabIntercept.Controls.Add(this.hexBox);
            this.tabIntercept.Controls.Add(this.lbFunction);
            this.tabIntercept.Controls.Add(this.btDrop);
            this.tabIntercept.Controls.Add(this.cbIntercepting);
            this.tabIntercept.Location = new System.Drawing.Point(4, 22);
            this.tabIntercept.Name = "tabIntercept";
            this.tabIntercept.Padding = new System.Windows.Forms.Padding(3);
            this.tabIntercept.Size = new System.Drawing.Size(631, 257);
            this.tabIntercept.TabIndex = 0;
            this.tabIntercept.Text = "Proxy";
            this.tabIntercept.UseVisualStyleBackColor = true;
            // 
            // tabLower
            // 
            this.tabLower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLower.Controls.Add(this.tabSearcher);
            this.tabLower.Location = new System.Drawing.Point(0, 172);
            this.tabLower.Margin = new System.Windows.Forms.Padding(0);
            this.tabLower.Name = "tabLower";
            this.tabLower.Padding = new System.Drawing.Point(0, 0);
            this.tabLower.SelectedIndex = 0;
            this.tabLower.Size = new System.Drawing.Size(633, 86);
            this.tabLower.TabIndex = 15;
            // 
            // tabSearcher
            // 
            this.tabSearcher.Controls.Add(this.hexBoxSearch);
            this.tabSearcher.Controls.Add(this.lbMatches);
            this.tabSearcher.Location = new System.Drawing.Point(4, 22);
            this.tabSearcher.Name = "tabSearcher";
            this.tabSearcher.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearcher.Size = new System.Drawing.Size(625, 60);
            this.tabSearcher.TabIndex = 0;
            this.tabSearcher.Text = "Search";
            this.tabSearcher.UseVisualStyleBackColor = true;
            // 
            // hexBoxSearch
            // 
            this.hexBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hexBoxSearch.BoldFont = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBoxSearch.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBoxSearch.LineInfoForeColor = System.Drawing.Color.Empty;
            this.hexBoxSearch.Location = new System.Drawing.Point(6, 7);
            this.hexBoxSearch.Name = "hexBoxSearch";
            this.hexBoxSearch.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBoxSearch.Size = new System.Drawing.Size(535, 46);
            this.hexBoxSearch.StringViewVisible = true;
            this.hexBoxSearch.TabIndex = 13;
            this.hexBoxSearch.VScrollBarVisible = true;
            this.hexBoxSearch.CurrentPositionInLineChanged += new System.EventHandler(this.hexBoxSearch_CurrentPositionInLineChanged);
            // 
            // lbFunction
            // 
            this.lbFunction.AutoSize = true;
            this.lbFunction.Location = new System.Drawing.Point(366, 13);
            this.lbFunction.Name = "lbFunction";
            this.lbFunction.Size = new System.Drawing.Size(54, 13);
            this.lbFunction.TabIndex = 14;
            this.lbFunction.Text = "[Function]";
            // 
            // tabMachReplace
            // 
            this.tabMachReplace.Controls.Add(this.dgvMatchAndReplace);
            this.tabMachReplace.Location = new System.Drawing.Point(4, 22);
            this.tabMachReplace.Name = "tabMachReplace";
            this.tabMachReplace.Size = new System.Drawing.Size(631, 257);
            this.tabMachReplace.TabIndex = 2;
            this.tabMachReplace.Text = "Match and replace";
            this.tabMachReplace.UseVisualStyleBackColor = true;
            // 
            // dgvMatchAndReplace
            // 
            this.dgvMatchAndReplace.AllowUserToAddRows = false;
            this.dgvMatchAndReplace.AllowUserToDeleteRows = false;
            this.dgvMatchAndReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatchAndReplace.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatchAndReplace.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMatchAndReplace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMatchAndReplace.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMatchAndReplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatchAndReplace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Enabled,
            this.Type,
            this.name,
            this.Match,
            this.Replace});
            this.dgvMatchAndReplace.ContextMenuStrip = this.contextMatchReplace;
            this.dgvMatchAndReplace.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMatchAndReplace.Location = new System.Drawing.Point(0, 4);
            this.dgvMatchAndReplace.MultiSelect = false;
            this.dgvMatchAndReplace.Name = "dgvMatchAndReplace";
            this.dgvMatchAndReplace.RowHeadersVisible = false;
            this.dgvMatchAndReplace.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatchAndReplace.Size = new System.Drawing.Size(631, 255);
            this.dgvMatchAndReplace.TabIndex = 0;
            // 
            // Enabled
            // 
            this.Enabled.FillWeight = 40.60914F;
            this.Enabled.HeaderText = "Enabled";
            this.Enabled.Name = "Enabled";
            this.Enabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Type
            // 
            this.Type.FillWeight = 41.94869F;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // Match
            // 
            this.Match.FillWeight = 158.7211F;
            this.Match.HeaderText = "Match";
            this.Match.Name = "Match";
            // 
            // Replace
            // 
            this.Replace.FillWeight = 158.7211F;
            this.Replace.HeaderText = "Replace";
            this.Replace.Name = "Replace";
            // 
            // contextMatchReplace
            // 
            this.contextMatchReplace.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMatchReplace,
            this.removeMatchReplace});
            this.contextMatchReplace.Name = "contextMatchReplace";
            this.contextMatchReplace.Size = new System.Drawing.Size(118, 48);
            // 
            // tabFuzzer
            // 
            this.tabFuzzer.Location = new System.Drawing.Point(4, 22);
            this.tabFuzzer.Name = "tabFuzzer";
            this.tabFuzzer.Size = new System.Drawing.Size(631, 257);
            this.tabFuzzer.TabIndex = 3;
            this.tabFuzzer.Text = "Fuzzer";
            this.tabFuzzer.UseVisualStyleBackColor = true;
            // 
            // tabRepeater
            // 
            this.tabRepeater.Controls.Add(this.label2);
            this.tabRepeater.Controls.Add(this.btRepeaterSend);
            this.tabRepeater.Controls.Add(this.tbRepeaterSocketID);
            this.tabRepeater.Controls.Add(this.label1);
            this.tabRepeater.Controls.Add(this.hexboxRepeater);
            this.tabRepeater.Location = new System.Drawing.Point(4, 22);
            this.tabRepeater.Name = "tabRepeater";
            this.tabRepeater.Size = new System.Drawing.Size(631, 257);
            this.tabRepeater.TabIndex = 4;
            this.tabRepeater.Text = "Repeater";
            this.tabRepeater.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "[Function]";
            // 
            // btRepeaterSend
            // 
            this.btRepeaterSend.Location = new System.Drawing.Point(6, 6);
            this.btRepeaterSend.Name = "btRepeaterSend";
            this.btRepeaterSend.Size = new System.Drawing.Size(72, 35);
            this.btRepeaterSend.TabIndex = 8;
            this.btRepeaterSend.Text = "Go";
            this.btRepeaterSend.UseVisualStyleBackColor = true;
            // 
            // tbRepeaterSocketID
            // 
            this.tbRepeaterSocketID.Location = new System.Drawing.Point(147, 14);
            this.tbRepeaterSocketID.Name = "tbRepeaterSocketID";
            this.tbRepeaterSocketID.Size = new System.Drawing.Size(62, 20);
            this.tbRepeaterSocketID.TabIndex = 7;
            this.tbRepeaterSocketID.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Socket ID";
            // 
            // hexboxRepeater
            // 
            this.hexboxRepeater.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hexboxRepeater.BoldFont = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexboxRepeater.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexboxRepeater.LineInfoForeColor = System.Drawing.Color.Empty;
            this.hexboxRepeater.LineInfoVisible = true;
            this.hexboxRepeater.Location = new System.Drawing.Point(6, 60);
            this.hexboxRepeater.Name = "hexboxRepeater";
            this.hexboxRepeater.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexboxRepeater.Size = new System.Drawing.Size(660, 194);
            this.hexboxRepeater.StringViewVisible = true;
            this.hexboxRepeater.TabIndex = 5;
            // 
            // tabPlugins
            // 
            this.tabPlugins.Controls.Add(this.tbInputTxtScripts);
            this.tabPlugins.Controls.Add(this.btUnloadPlugin);
            this.tabPlugins.Controls.Add(this.lbLoadedScripts);
            this.tabPlugins.Controls.Add(this.label4);
            this.tabPlugins.Controls.Add(this.label3);
            this.tabPlugins.Controls.Add(this.apiOutputConsole);
            this.tabPlugins.Controls.Add(this.btLoadPlugin);
            this.tabPlugins.Location = new System.Drawing.Point(4, 22);
            this.tabPlugins.Name = "tabPlugins";
            this.tabPlugins.Size = new System.Drawing.Size(631, 257);
            this.tabPlugins.TabIndex = 5;
            this.tabPlugins.Text = "Plugins";
            this.tabPlugins.UseVisualStyleBackColor = true;
            // 
            // tbInputTxtScripts
            // 
            this.tbInputTxtScripts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInputTxtScripts.BackColor = System.Drawing.Color.Black;
            this.tbInputTxtScripts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInputTxtScripts.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputTxtScripts.ForeColor = System.Drawing.Color.Yellow;
            this.tbInputTxtScripts.Location = new System.Drawing.Point(3, 235);
            this.tbInputTxtScripts.Name = "tbInputTxtScripts";
            this.tbInputTxtScripts.Size = new System.Drawing.Size(620, 13);
            this.tbInputTxtScripts.TabIndex = 5;
            this.tbInputTxtScripts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInputTxtScripts_KeyDown);
            // 
            // lbLoadedScripts
            // 
            this.lbLoadedScripts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoadedScripts.FormattingEnabled = true;
            this.lbLoadedScripts.Location = new System.Drawing.Point(6, 21);
            this.lbLoadedScripts.Name = "lbLoadedScripts";
            this.lbLoadedScripts.Size = new System.Drawing.Size(528, 82);
            this.lbLoadedScripts.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loaded scripts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "API output console";
            // 
            // apiOutputConsole
            // 
            this.apiOutputConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.apiOutputConsole.BackColor = System.Drawing.Color.Black;
            this.apiOutputConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apiOutputConsole.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiOutputConsole.ForeColor = System.Drawing.Color.Yellow;
            this.apiOutputConsole.Location = new System.Drawing.Point(3, 122);
            this.apiOutputConsole.Multiline = true;
            this.apiOutputConsole.Name = "apiOutputConsole";
            this.apiOutputConsole.ReadOnly = true;
            this.apiOutputConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.apiOutputConsole.Size = new System.Drawing.Size(620, 113);
            this.apiOutputConsole.TabIndex = 0;
            // 
            // tabSponsors
            // 
            this.tabSponsors.Controls.Add(this.wBrowser);
            this.tabSponsors.Controls.Add(this.linkSponsorUs);
            this.tabSponsors.Controls.Add(this.lbSponsors);
            this.tabSponsors.Location = new System.Drawing.Point(4, 22);
            this.tabSponsors.Name = "tabSponsors";
            this.tabSponsors.Size = new System.Drawing.Size(631, 257);
            this.tabSponsors.TabIndex = 6;
            this.tabSponsors.Text = "Sponsors";
            this.tabSponsors.UseVisualStyleBackColor = true;
            // 
            // wBrowser
            // 
            this.wBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wBrowser.Location = new System.Drawing.Point(11, 57);
            this.wBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wBrowser.Name = "wBrowser";
            this.wBrowser.ScrollBarsEnabled = false;
            this.wBrowser.Size = new System.Drawing.Size(603, 173);
            this.wBrowser.TabIndex = 7;
            // 
            // linkSponsorUs
            // 
            this.linkSponsorUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkSponsorUs.AutoSize = true;
            this.linkSponsorUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkSponsorUs.Location = new System.Drawing.Point(8, 233);
            this.linkSponsorUs.Name = "linkSponsorUs";
            this.linkSponsorUs.Size = new System.Drawing.Size(63, 13);
            this.linkSponsorUs.TabIndex = 6;
            this.linkSponsorUs.TabStop = true;
            this.linkSponsorUs.Text = "Sponsor us!";
            this.linkSponsorUs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSponsorUs_LinkClicked);
            // 
            // lbSponsors
            // 
            this.lbSponsors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSponsors.Location = new System.Drawing.Point(8, 13);
            this.lbSponsors.Name = "lbSponsors";
            this.lbSponsors.Size = new System.Drawing.Size(615, 57);
            this.lbSponsors.TabIndex = 0;
            this.lbSponsors.Text = resources.GetString("lbSponsors.Text");
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.attachToolStripMenuItem,
            this.unhookToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::hook.Properties.Resources.application;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpening);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::hook.Properties.Resources.application_add;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // attachToolStripMenuItem
            // 
            this.attachToolStripMenuItem.Image = global::hook.Properties.Resources.application_get;
            this.attachToolStripMenuItem.Name = "attachToolStripMenuItem";
            this.attachToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.attachToolStripMenuItem.Text = "&Attach";
            this.attachToolStripMenuItem.Click += new System.EventHandler(this.attachToolStripMenuItem_Click);
            // 
            // unhookToolStripMenuItem
            // 
            this.unhookToolStripMenuItem.Image = global::hook.Properties.Resources.application_delete;
            this.unhookToolStripMenuItem.Name = "unhookToolStripMenuItem";
            this.unhookToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unhookToolStripMenuItem.Text = "&Unhook";
            this.unhookToolStripMenuItem.Click += new System.EventHandler(this.unhookToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::hook.Properties.Resources.application_go;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Image = global::hook.Properties.Resources.shape_ungroup;
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::hook.Properties.Resources.users_ico;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Image = global::hook.Properties.Resources.award_star_gold_1;
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.licenseToolStripMenuItem.Text = "License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // btForward
            // 
            this.btForward.AccessibleDescription = "";
            this.btForward.Image = global::hook.Properties.Resources.v2;
            this.btForward.Location = new System.Drawing.Point(0, 5);
            this.btForward.Name = "btForward";
            this.btForward.Size = new System.Drawing.Size(99, 28);
            this.btForward.TabIndex = 1;
            this.btForward.Text = "  Forward";
            this.btForward.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btForward.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btForward.UseVisualStyleBackColor = true;
            this.btForward.Click += new System.EventHandler(this.btForward_Click);
            // 
            // btDrop
            // 
            this.btDrop.Image = global::hook.Properties.Resources.x;
            this.btDrop.Location = new System.Drawing.Point(105, 5);
            this.btDrop.Name = "btDrop";
            this.btDrop.Size = new System.Drawing.Size(99, 28);
            this.btDrop.TabIndex = 3;
            this.btDrop.Text = "   Drop";
            this.btDrop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDrop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDrop.UseVisualStyleBackColor = true;
            this.btDrop.Click += new System.EventHandler(this.btDrop_Click);
            // 
            // newMatchReplace
            // 
            this.newMatchReplace.Image = global::hook.Properties.Resources.add;
            this.newMatchReplace.Name = "newMatchReplace";
            this.newMatchReplace.Size = new System.Drawing.Size(117, 22);
            this.newMatchReplace.Text = "&Add";
            this.newMatchReplace.Click += new System.EventHandler(this.newMatchReplace_Click);
            // 
            // removeMatchReplace
            // 
            this.removeMatchReplace.Image = global::hook.Properties.Resources.delete;
            this.removeMatchReplace.Name = "removeMatchReplace";
            this.removeMatchReplace.Size = new System.Drawing.Size(117, 22);
            this.removeMatchReplace.Text = "&Remove";
            this.removeMatchReplace.Click += new System.EventHandler(this.removeMatchReplace_Click);
            // 
            // btUnloadPlugin
            // 
            this.btUnloadPlugin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUnloadPlugin.Image = global::hook.Properties.Resources.delete;
            this.btUnloadPlugin.Location = new System.Drawing.Point(540, 63);
            this.btUnloadPlugin.Name = "btUnloadPlugin";
            this.btUnloadPlugin.Size = new System.Drawing.Size(83, 40);
            this.btUnloadPlugin.TabIndex = 6;
            this.btUnloadPlugin.Text = "Unload";
            this.btUnloadPlugin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUnloadPlugin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUnloadPlugin.UseVisualStyleBackColor = true;
            this.btUnloadPlugin.Click += new System.EventHandler(this.btUnloadPlugin_Click);
            // 
            // btLoadPlugin
            // 
            this.btLoadPlugin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoadPlugin.Image = global::hook.Properties.Resources.add;
            this.btLoadPlugin.Location = new System.Drawing.Point(540, 21);
            this.btLoadPlugin.Name = "btLoadPlugin";
            this.btLoadPlugin.Size = new System.Drawing.Size(83, 40);
            this.btLoadPlugin.TabIndex = 2;
            this.btLoadPlugin.Text = "Load";
            this.btLoadPlugin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLoadPlugin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLoadPlugin.UseVisualStyleBackColor = true;
            this.btLoadPlugin.Click += new System.EventHandler(this.btLoadPlugin_Click);
            // 
            // listViewLog
            // 
            this.listViewLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewLog.BackColor = System.Drawing.SystemColors.Menu;
            this.listViewLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTime,
            this.columnModule,
            this.columnMessage});
            this.listViewLog.FullRowSelect = true;
            this.listViewLog.GridLines = true;
            this.listViewLog.LabelWrap = false;
            this.listViewLog.Location = new System.Drawing.Point(0, 311);
            this.listViewLog.Name = "listViewLog";
            this.listViewLog.Size = new System.Drawing.Size(638, 110);
            this.listViewLog.TabIndex = 13;
            this.listViewLog.UseCompatibleStateImageBehavior = false;
            this.listViewLog.View = System.Windows.Forms.View.Details;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Time";
            // 
            // columnModule
            // 
            this.columnModule.Text = "Module";
            // 
            // columnMessage
            // 
            this.columnMessage.Text = "Message";
            this.columnMessage.Width = 500;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 422);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listViewLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MinimumSize = new System.Drawing.Size(650, 460);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabIntercept.ResumeLayout(false);
            this.tabIntercept.PerformLayout();
            this.tabLower.ResumeLayout(false);
            this.tabSearcher.ResumeLayout(false);
            this.tabMachReplace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchAndReplace)).EndInit();
            this.contextMatchReplace.ResumeLayout(false);
            this.tabRepeater.ResumeLayout(false);
            this.tabRepeater.PerformLayout();
            this.tabPlugins.ResumeLayout(false);
            this.tabPlugins.PerformLayout();
            this.tabSponsors.ResumeLayout(false);
            this.tabSponsors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btForward;
        private System.Windows.Forms.Button btDrop;
        private Be.Windows.Forms.HexBox hexBox;
        private System.Windows.Forms.CheckBox cbIntercepting;
        private System.Windows.Forms.Label lbMatches;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabIntercept;
        private System.Windows.Forms.TabPage tabMachReplace;
        private System.Windows.Forms.Label lbFunction;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabFuzzer;
        private System.Windows.Forms.TabPage tabRepeater;
        private Be.Windows.Forms.HexBox hexBoxSearch;
        private System.Windows.Forms.DataGridView dgvMatchAndReplace;
        private System.Windows.Forms.TextBox tbRepeaterSocketID;
        private System.Windows.Forms.Label label1;
        private Be.Windows.Forms.HexBox hexboxRepeater;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRepeaterSend;
        private System.Windows.Forms.ContextMenuStrip contextMatchReplace;
        private System.Windows.Forms.ToolStripMenuItem newMatchReplace;
        private System.Windows.Forms.ToolStripMenuItem removeMatchReplace;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Enabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Match;
        private System.Windows.Forms.DataGridViewTextBoxColumn Replace;
        private System.Windows.Forms.TabPage tabPlugins;
        private System.Windows.Forms.Button btLoadPlugin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apiOutputConsole;
        private System.Windows.Forms.ListBox lbLoadedScripts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInputTxtScripts;
        private System.Windows.Forms.Button btUnloadPlugin;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private FOCA.Search.ListViewEx listViewLog;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnModule;
        private System.Windows.Forms.ColumnHeader columnMessage;
        private System.Windows.Forms.TabControl tabLower;
        private System.Windows.Forms.TabPage tabSearcher;
        private System.Windows.Forms.TabPage tabSponsors;
        private System.Windows.Forms.Label lbSponsors;
        private System.Windows.Forms.LinkLabel linkSponsorUs;
        private System.Windows.Forms.WebBrowser wBrowser;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unhookToolStripMenuItem;
    }
}

