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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvPerfs = new System.Windows.Forms.TreeView();
            this.grpKeyTemplate = new System.Windows.Forms.GroupBox();
            this.txtKeyTemplate = new System.Windows.Forms.TextBox();
            this.lblKeyTemplateExpl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDefaultInterval = new System.Windows.Forms.TextBox();
            this.grpGraphiteConfig = new System.Windows.Forms.GroupBox();
            this.cmbGraphiteTransport = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGraphitePort = new System.Windows.Forms.TextBox();
            this.txtGraphiteAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpConfig = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfigPath = new System.Windows.Forms.TextBox();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpKeyTemplate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpGraphiteConfig.SuspendLayout();
            this.grpConfig.SuspendLayout();
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
            this.grpMain.Location = new System.Drawing.Point(16, 15);
            this.grpMain.Margin = new System.Windows.Forms.Padding(4);
            this.grpMain.Name = "grpMain";
            this.grpMain.Padding = new System.Windows.Forms.Padding(4);
            this.grpMain.Size = new System.Drawing.Size(1169, 778);
            this.grpMain.TabIndex = 0;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "MainConfig";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(8, 57);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvPerfs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpKeyTemplate);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.grpGraphiteConfig);
            this.splitContainer1.Panel2.Controls.Add(this.grpConfig);
            this.splitContainer1.Size = new System.Drawing.Size(1153, 714);
            this.splitContainer1.SplitterDistance = 740;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // trvPerfs
            // 
            this.trvPerfs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvPerfs.CheckBoxes = true;
            this.trvPerfs.Location = new System.Drawing.Point(4, 4);
            this.trvPerfs.Margin = new System.Windows.Forms.Padding(4);
            this.trvPerfs.Name = "trvPerfs";
            this.trvPerfs.Size = new System.Drawing.Size(731, 705);
            this.trvPerfs.TabIndex = 0;
            this.trvPerfs.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvPerfs_AfterCheck);
            this.trvPerfs.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.trvPerfs_AfterExpand);
            // 
            // grpKeyTemplate
            // 
            this.grpKeyTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKeyTemplate.Controls.Add(this.txtKeyTemplate);
            this.grpKeyTemplate.Controls.Add(this.lblKeyTemplateExpl);
            this.grpKeyTemplate.Controls.Add(this.label7);
            this.grpKeyTemplate.Location = new System.Drawing.Point(4, 313);
            this.grpKeyTemplate.Name = "grpKeyTemplate";
            this.grpKeyTemplate.Size = new System.Drawing.Size(398, 197);
            this.grpKeyTemplate.TabIndex = 3;
            this.grpKeyTemplate.TabStop = false;
            this.grpKeyTemplate.Text = "Key Template";
            // 
            // txtKeyTemplate
            // 
            this.txtKeyTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyTemplate.Location = new System.Drawing.Point(12, 157);
            this.txtKeyTemplate.Name = "txtKeyTemplate";
            this.txtKeyTemplate.Size = new System.Drawing.Size(376, 20);
            this.txtKeyTemplate.TabIndex = 2;
            this.txtKeyTemplate.Text = "$hostname.$category.$instance.$counter";
            // 
            // lblKeyTemplateExpl
            // 
            this.lblKeyTemplateExpl.Location = new System.Drawing.Point(10, 59);
            this.lblKeyTemplateExpl.Name = "lblKeyTemplateExpl";
            this.lblKeyTemplateExpl.Size = new System.Drawing.Size(383, 95);
            this.lblKeyTemplateExpl.TabIndex = 1;
            this.lblKeyTemplateExpl.Text = "Possible fields :\r\n$hostname\r\n$category\r\n$instance\r\n$counter";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(10, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(378, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Use this to specify the pattern used for the field \'key\'";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDefaultInterval);
            this.groupBox1.Location = new System.Drawing.Point(4, 218);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(398, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Config";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "default interval :";
            // 
            // txtDefaultInterval
            // 
            this.txtDefaultInterval.Location = new System.Drawing.Point(13, 53);
            this.txtDefaultInterval.Margin = new System.Windows.Forms.Padding(4);
            this.txtDefaultInterval.Name = "txtDefaultInterval";
            this.txtDefaultInterval.Size = new System.Drawing.Size(141, 20);
            this.txtDefaultInterval.TabIndex = 4;
            this.txtDefaultInterval.Text = "10";
            // 
            // grpGraphiteConfig
            // 
            this.grpGraphiteConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGraphiteConfig.Controls.Add(this.cmbGraphiteTransport);
            this.grpGraphiteConfig.Controls.Add(this.label6);
            this.grpGraphiteConfig.Controls.Add(this.txtGraphitePort);
            this.grpGraphiteConfig.Controls.Add(this.txtGraphiteAddress);
            this.grpGraphiteConfig.Controls.Add(this.label4);
            this.grpGraphiteConfig.Controls.Add(this.label3);
            this.grpGraphiteConfig.Location = new System.Drawing.Point(4, 4);
            this.grpGraphiteConfig.Margin = new System.Windows.Forms.Padding(4);
            this.grpGraphiteConfig.Name = "grpGraphiteConfig";
            this.grpGraphiteConfig.Padding = new System.Windows.Forms.Padding(4);
            this.grpGraphiteConfig.Size = new System.Drawing.Size(398, 191);
            this.grpGraphiteConfig.TabIndex = 1;
            this.grpGraphiteConfig.TabStop = false;
            this.grpGraphiteConfig.Text = "Graphite Config";
            // 
            // cmbGraphiteTransport
            // 
            this.cmbGraphiteTransport.FormattingEnabled = true;
            this.cmbGraphiteTransport.Items.AddRange(new object[] {
            "tcp",
            "udp"});
            this.cmbGraphiteTransport.Location = new System.Drawing.Point(13, 160);
            this.cmbGraphiteTransport.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGraphiteTransport.Name = "cmbGraphiteTransport";
            this.cmbGraphiteTransport.Size = new System.Drawing.Size(141, 21);
            this.cmbGraphiteTransport.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "transport :";
            // 
            // txtGraphitePort
            // 
            this.txtGraphitePort.Location = new System.Drawing.Point(13, 101);
            this.txtGraphitePort.Margin = new System.Windows.Forms.Padding(4);
            this.txtGraphitePort.Name = "txtGraphitePort";
            this.txtGraphitePort.Size = new System.Drawing.Size(141, 20);
            this.txtGraphitePort.TabIndex = 3;
            this.txtGraphitePort.Text = "2003";
            // 
            // txtGraphiteAddress
            // 
            this.txtGraphiteAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGraphiteAddress.Location = new System.Drawing.Point(13, 46);
            this.txtGraphiteAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtGraphiteAddress.Name = "txtGraphiteAddress";
            this.txtGraphiteAddress.Size = new System.Drawing.Size(375, 20);
            this.txtGraphiteAddress.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "port :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "address :";
            // 
            // grpConfig
            // 
            this.grpConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConfig.Controls.Add(this.label2);
            this.grpConfig.Controls.Add(this.txtConfigPath);
            this.grpConfig.Controls.Add(this.btnSaveConfig);
            this.grpConfig.Location = new System.Drawing.Point(4, 588);
            this.grpConfig.Margin = new System.Windows.Forms.Padding(4);
            this.grpConfig.Name = "grpConfig";
            this.grpConfig.Padding = new System.Windows.Forms.Padding(4);
            this.grpConfig.Size = new System.Drawing.Size(388, 122);
            this.grpConfig.TabIndex = 0;
            this.grpConfig.TabStop = false;
            this.grpConfig.Text = "Config File";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Config File Path :";
            // 
            // txtConfigPath
            // 
            this.txtConfigPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfigPath.Location = new System.Drawing.Point(8, 55);
            this.txtConfigPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfigPath.Name = "txtConfigPath";
            this.txtConfigPath.Size = new System.Drawing.Size(371, 20);
            this.txtConfigPath.TabIndex = 1;
            this.txtConfigPath.Text = "C:\\Dan\\Temp";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveConfig.Location = new System.Drawing.Point(280, 87);
            this.btnSaveConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(100, 28);
            this.btnSaveConfig.TabIndex = 0;
            this.btnSaveConfig.Text = "Save Config";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hostname :";
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(89, 23);
            this.txtHostname.Margin = new System.Windows.Forms.Padding(4);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(208, 20);
            this.txtHostname.TabIndex = 1;
            this.txtHostname.Text = "localhost";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1201, 807);
            this.Controls.Add(this.grpMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Graphite Config Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpKeyTemplate.ResumeLayout(false);
            this.grpKeyTemplate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpGraphiteConfig.ResumeLayout(false);
            this.grpGraphiteConfig.PerformLayout();
            this.grpConfig.ResumeLayout(false);
            this.grpConfig.PerformLayout();
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
        private System.Windows.Forms.TextBox txtConfigPath;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDefaultInterval;
        private System.Windows.Forms.GroupBox grpGraphiteConfig;
        private System.Windows.Forms.TextBox txtGraphitePort;
        private System.Windows.Forms.TextBox txtGraphiteAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGraphiteTransport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpKeyTemplate;
        private System.Windows.Forms.TextBox txtKeyTemplate;
        private System.Windows.Forms.Label lblKeyTemplateExpl;
        private System.Windows.Forms.Label label7;
    }
}

