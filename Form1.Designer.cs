namespace threat_test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPortSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.rtxtThreatReply = new System.Windows.Forms.RichTextBox();
            this.rtxtThreatCmd = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.grpBoxXML = new System.Windows.Forms.GroupBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbGJParsed = new System.Windows.Forms.RadioButton();
            this.rbGJRaw = new System.Windows.Forms.RadioButton();
            this.rbParsed = new System.Windows.Forms.RadioButton();
            this.rbRaw = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPortListen = new System.Windows.Forms.TextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpMulticast = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMulticast = new System.Windows.Forms.TextBox();
            this.chkMulticast = new System.Windows.Forms.CheckBox();
            this.grpBoxTTL = new System.Windows.Forms.GroupBox();
            this.txtTTL = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAdapter = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxXML.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.grpMulticast.SuspendLayout();
            this.grpBoxTTL.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPortSend);
            this.groupBox2.Location = new System.Drawing.Point(128, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(75, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send Port";
            // 
            // txtPortSend
            // 
            this.txtPortSend.Location = new System.Drawing.Point(10, 16);
            this.txtPortSend.Name = "txtPortSend";
            this.txtPortSend.Size = new System.Drawing.Size(56, 20);
            this.txtPortSend.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(304, 67);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 28);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(727, 67);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send to Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(10, 16);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(99, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // rtxtThreatReply
            // 
            this.rtxtThreatReply.Location = new System.Drawing.Point(450, 139);
            this.rtxtThreatReply.Name = "rtxtThreatReply";
            this.rtxtThreatReply.Size = new System.Drawing.Size(401, 365);
            this.rtxtThreatReply.TabIndex = 0;
            this.rtxtThreatReply.Text = "";
            this.rtxtThreatReply.WordWrap = false;
            // 
            // rtxtThreatCmd
            // 
            this.rtxtThreatCmd.Location = new System.Drawing.Point(10, 19);
            this.rtxtThreatCmd.Name = "rtxtThreatCmd";
            this.rtxtThreatCmd.Size = new System.Drawing.Size(397, 173);
            this.rtxtThreatCmd.TabIndex = 11;
            this.rtxtThreatCmd.Text = "";
            this.rtxtThreatCmd.WordWrap = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(10, 17);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(64, 29);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // grpBoxXML
            // 
            this.grpBoxXML.Controls.Add(this.txtFileName);
            this.grpBoxXML.Controls.Add(this.btnOpen);
            this.grpBoxXML.Location = new System.Drawing.Point(6, 46);
            this.grpBoxXML.Name = "grpBoxXML";
            this.grpBoxXML.Size = new System.Drawing.Size(292, 59);
            this.grpBoxXML.TabIndex = 12;
            this.grpBoxXML.TabStop = false;
            this.grpBoxXML.Text = "Lv3 Image File";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(80, 22);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(195, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtxtThreatCmd);
            this.groupBox4.Location = new System.Drawing.Point(6, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(413, 223);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Send";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbGJParsed);
            this.groupBox5.Controls.Add(this.rbGJRaw);
            this.groupBox5.Controls.Add(this.rbParsed);
            this.groupBox5.Controls.Add(this.rbRaw);
            this.groupBox5.Location = new System.Drawing.Point(441, 120);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(416, 413);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Receive";
            // 
            // rbGJParsed
            // 
            this.rbGJParsed.AutoSize = true;
            this.rbGJParsed.Location = new System.Drawing.Point(312, 390);
            this.rbGJParsed.Name = "rbGJParsed";
            this.rbGJParsed.Size = new System.Drawing.Size(98, 17);
            this.rbGJParsed.TabIndex = 22;
            this.rbGJParsed.TabStop = true;
            this.rbGJParsed.Text = "gJSON Parsed ";
            this.rbGJParsed.UseVisualStyleBackColor = true;
            this.rbGJParsed.CheckedChanged += new System.EventHandler(this.rbGJParsed_CheckedChanged);
            // 
            // rbGJRaw
            // 
            this.rbGJRaw.AutoSize = true;
            this.rbGJRaw.Location = new System.Drawing.Point(209, 390);
            this.rbGJRaw.Name = "rbGJRaw";
            this.rbGJRaw.Size = new System.Drawing.Size(84, 17);
            this.rbGJRaw.TabIndex = 21;
            this.rbGJRaw.TabStop = true;
            this.rbGJRaw.Text = "gJSON Raw";
            this.rbGJRaw.UseVisualStyleBackColor = true;
            this.rbGJRaw.CheckedChanged += new System.EventHandler(this.rbGJRaw_CheckedChanged);
            // 
            // rbParsed
            // 
            this.rbParsed.AutoSize = true;
            this.rbParsed.Location = new System.Drawing.Point(104, 390);
            this.rbParsed.Name = "rbParsed";
            this.rbParsed.Size = new System.Drawing.Size(86, 17);
            this.rbParsed.TabIndex = 20;
            this.rbParsed.TabStop = true;
            this.rbParsed.Text = "XML Parsed ";
            this.rbParsed.UseVisualStyleBackColor = true;
            this.rbParsed.CheckedChanged += new System.EventHandler(this.rbParsed_CheckedChanged);
            // 
            // rbRaw
            // 
            this.rbRaw.AutoSize = true;
            this.rbRaw.Location = new System.Drawing.Point(10, 390);
            this.rbRaw.Name = "rbRaw";
            this.rbRaw.Size = new System.Drawing.Size(75, 17);
            this.rbRaw.TabIndex = 19;
            this.rbRaw.TabStop = true;
            this.rbRaw.Text = "XML Raw ";
            this.rbRaw.UseVisualStyleBackColor = true;
            this.rbRaw.CheckedChanged += new System.EventHandler(this.rbRaw_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtPortListen);
            this.groupBox6.Location = new System.Drawing.Point(451, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(71, 46);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Listen Port";
            // 
            // txtPortListen
            // 
            this.txtPortListen.Location = new System.Drawing.Point(10, 16);
            this.txtPortListen.Name = "txtPortListen";
            this.txtPortListen.Size = new System.Drawing.Size(56, 20);
            this.txtPortListen.TabIndex = 0;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(451, 67);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(71, 28);
            this.btnListen.TabIndex = 15;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(533, 67);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 28);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Deaf";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpMulticast
            // 
            this.grpMulticast.Controls.Add(this.label1);
            this.grpMulticast.Controls.Add(this.txtMulticast);
            this.grpMulticast.Controls.Add(this.chkMulticast);
            this.grpMulticast.Location = new System.Drawing.Point(533, 2);
            this.grpMulticast.Name = "grpMulticast";
            this.grpMulticast.Size = new System.Drawing.Size(230, 46);
            this.grpMulticast.TabIndex = 17;
            this.grpMulticast.TabStop = false;
            this.grpMulticast.Text = "Multicast Receive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address";
            // 
            // txtMulticast
            // 
            this.txtMulticast.Enabled = false;
            this.txtMulticast.Location = new System.Drawing.Point(122, 16);
            this.txtMulticast.Name = "txtMulticast";
            this.txtMulticast.Size = new System.Drawing.Size(99, 20);
            this.txtMulticast.TabIndex = 1;
            // 
            // chkMulticast
            // 
            this.chkMulticast.AutoSize = true;
            this.chkMulticast.Location = new System.Drawing.Point(6, 19);
            this.chkMulticast.Name = "chkMulticast";
            this.chkMulticast.Size = new System.Drawing.Size(59, 17);
            this.chkMulticast.TabIndex = 0;
            this.chkMulticast.Text = "Enable";
            this.chkMulticast.UseVisualStyleBackColor = true;
            this.chkMulticast.CheckedChanged += new System.EventHandler(this.chkMulticast_CheckedChanged);
            // 
            // grpBoxTTL
            // 
            this.grpBoxTTL.Controls.Add(this.txtTTL);
            this.grpBoxTTL.Location = new System.Drawing.Point(209, 2);
            this.grpBoxTTL.Name = "grpBoxTTL";
            this.grpBoxTTL.Size = new System.Drawing.Size(50, 46);
            this.grpBoxTTL.TabIndex = 18;
            this.grpBoxTTL.TabStop = false;
            this.grpBoxTTL.Text = "TTL";
            // 
            // txtTTL
            // 
            this.txtTTL.Location = new System.Drawing.Point(10, 18);
            this.txtTTL.Name = "txtTTL";
            this.txtTTL.Size = new System.Drawing.Size(32, 20);
            this.txtTTL.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAdapter);
            this.groupBox3.Location = new System.Drawing.Point(265, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 46);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adapter Address";
            // 
            // txtAdapter
            // 
            this.txtAdapter.Location = new System.Drawing.Point(10, 16);
            this.txtAdapter.Name = "txtAdapter";
            this.txtAdapter.Size = new System.Drawing.Size(99, 20);
            this.txtAdapter.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 545);
            this.Controls.Add(this.rtxtThreatReply);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpBoxTTL);
            this.Controls.Add(this.grpMulticast);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpBoxXML);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Threat Test";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxXML.ResumeLayout(false);
            this.grpBoxXML.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.grpMulticast.ResumeLayout(false);
            this.grpMulticast.PerformLayout();
            this.grpBoxTTL.ResumeLayout(false);
            this.grpBoxTTL.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPortSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RichTextBox rtxtThreatReply;
        private System.Windows.Forms.RichTextBox rtxtThreatCmd;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox grpBoxXML;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtPortListen;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpMulticast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMulticast;
        private System.Windows.Forms.CheckBox chkMulticast;
        private System.Windows.Forms.GroupBox grpBoxTTL;
        private System.Windows.Forms.TextBox txtTTL;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAdapter;
        private System.Windows.Forms.RadioButton rbRaw;
        private System.Windows.Forms.RadioButton rbParsed;
        private System.Windows.Forms.RadioButton rbGJParsed;
        private System.Windows.Forms.RadioButton rbGJRaw;
    }
}

