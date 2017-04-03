namespace GraphiteClientGenerator
{
    partial class Form1
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
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.trvPerfs = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpConfig = new System.Windows.Forms.GroupBox();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMain.Controls.Add(this.splitContainer1);
            this.grpMain.Controls.Add(this.button1);
            this.grpMain.Controls.Add(this.label1);
            this.grpMain.Controls.Add(this.txtHostname);
            this.grpMain.Location = new System.Drawing.Point(12, 12);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(703, 596);
            this.grpMain.TabIndex = 0;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "MainConfig";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hostname :";
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(67, 19);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(157, 20);
            this.txtHostname.TabIndex = 1;
            this.txtHostname.Text = "localhost";
            // 
            // trvPerfs
            // 
            this.trvPerfs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvPerfs.CheckBoxes = true;
            this.trvPerfs.Location = new System.Drawing.Point(3, 3);
            this.trvPerfs.Name = "trvPerfs";
            this.trvPerfs.Size = new System.Drawing.Size(438, 538);
            this.trvPerfs.TabIndex = 0;
            this.trvPerfs.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvPerfs_AfterCheck);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 46);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvPerfs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpConfig);
            this.splitContainer1.Size = new System.Drawing.Size(691, 544);
            this.splitContainer1.SplitterDistance = 444;
            this.splitContainer1.TabIndex = 4;
            // 
            // grpConfig
            // 
            this.grpConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConfig.Location = new System.Drawing.Point(3, 3);
            this.grpConfig.Name = "grpConfig";
            this.grpConfig.Size = new System.Drawing.Size(237, 538);
            this.grpConfig.TabIndex = 0;
            this.grpConfig.TabStop = false;
            this.grpConfig.Text = "Config";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 620);
            this.Controls.Add(this.grpMain);
            this.Name = "Form1";
            this.Text = "Graphite Config Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.TreeView trvPerfs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpConfig;
    }
}

