namespace hook
{
    partial class FormOpenProcess
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbExPath = new System.Windows.Forms.TextBox();
            this.tbArguments = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Executable path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arguments";
            // 
            // tbExPath
            // 
            this.tbExPath.Location = new System.Drawing.Point(16, 29);
            this.tbExPath.Name = "tbExPath";
            this.tbExPath.Size = new System.Drawing.Size(255, 20);
            this.tbExPath.TabIndex = 2;
            // 
            // tbArguments
            // 
            this.tbArguments.Location = new System.Drawing.Point(16, 71);
            this.tbArguments.Name = "tbArguments";
            this.tbArguments.Size = new System.Drawing.Size(367, 20);
            this.tbArguments.TabIndex = 3;
            // 
            // btCancel
            // 
            this.btCancel.Image = global::hook.Properties.Resources.x;
            this.btCancel.Location = new System.Drawing.Point(211, 111);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(88, 26);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancel";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btStart
            // 
            this.btStart.Image = global::hook.Properties.Resources.v2;
            this.btStart.Location = new System.Drawing.Point(117, 111);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(88, 28);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Start";
            this.btStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btSearch
            // 
            this.btSearch.Image = global::hook.Properties.Resources.magnifier;
            this.btSearch.Location = new System.Drawing.Point(277, 26);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(106, 26);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "Search";
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // FormOpenProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 154);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbArguments);
            this.Controls.Add(this.tbExPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormOpenProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Run a new process";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbExPath;
        private System.Windows.Forms.TextBox tbArguments;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btCancel;
    }
}