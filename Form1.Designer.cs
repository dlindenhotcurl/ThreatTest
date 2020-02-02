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
            this.txrPathName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grpUID = new System.Windows.Forms.GroupBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.grpSpectrum = new System.Windows.Forms.GroupBox();
            this.txtSpectrum = new System.Windows.Forms.TextBox();
            this.grpFileName = new System.Windows.Forms.GroupBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.grpDirectory = new System.Windows.Forms.GroupBox();
            this.txtDirectory = new System.Windows.Forms.TextBox();
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
            this.grpPlay = new System.Windows.Forms.GroupBox();
            this.grpThreatCount = new System.Windows.Forms.GroupBox();
            this.txtThreatCnt = new System.Windows.Forms.TextBox();
            this.grpImageCount = new System.Windows.Forms.GroupBox();
            this.txtImgCnt = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pbRunning = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxXML.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpUID.SuspendLayout();
            this.grpSpectrum.SuspendLayout();
            this.grpFileName.SuspendLayout();
            this.grpDirectory.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.grpMulticast.SuspendLayout();
            this.grpBoxTTL.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpPlay.SuspendLayout();
            this.grpThreatCount.SuspendLayout();
            this.grpImageCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRunning)).BeginInit();
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
            this.txtPortSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(304, 67);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(57, 28);
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
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.rtxtThreatCmd.Location = new System.Drawing.Point(10, 84);
            this.rtxtThreatCmd.Name = "rtxtThreatCmd";
            this.rtxtThreatCmd.Size = new System.Drawing.Size(397, 218);
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
            this.grpBoxXML.Controls.Add(this.txrPathName);
            this.grpBoxXML.Controls.Add(this.btnOpen);
            this.grpBoxXML.Location = new System.Drawing.Point(6, 46);
            this.grpBoxXML.Name = "grpBoxXML";
            this.grpBoxXML.Size = new System.Drawing.Size(292, 59);
            this.grpBoxXML.TabIndex = 12;
            this.grpBoxXML.TabStop = false;
            this.grpBoxXML.Text = "Lv3 Image File";
            // 
            // txrPathName
            // 
            this.txrPathName.Location = new System.Drawing.Point(80, 22);
            this.txrPathName.Name = "txrPathName";
            this.txrPathName.ReadOnly = true;
            this.txrPathName.Size = new System.Drawing.Size(195, 20);
            this.txrPathName.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grpUID);
            this.groupBox4.Controls.Add(this.grpSpectrum);
            this.groupBox4.Controls.Add(this.grpFileName);
            this.groupBox4.Controls.Add(this.grpDirectory);
            this.groupBox4.Controls.Add(this.rtxtThreatCmd);
            this.groupBox4.Location = new System.Drawing.Point(6, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(413, 325);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Send";
            // 
            // grpUID
            // 
            this.grpUID.Controls.Add(this.txtUID);
            this.grpUID.Location = new System.Drawing.Point(336, 19);
            this.grpUID.Name = "grpUID";
            this.grpUID.Size = new System.Drawing.Size(71, 45);
            this.grpUID.TabIndex = 15;
            this.grpUID.TabStop = false;
            this.grpUID.Text = "Initial UID";
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(6, 15);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(58, 20);
            this.txtUID.TabIndex = 1;
            this.txtUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUID.TextChanged += new System.EventHandler(this.txtUID_TextChanged);
            // 
            // grpSpectrum
            // 
            this.grpSpectrum.Controls.Add(this.txtSpectrum);
            this.grpSpectrum.Location = new System.Drawing.Point(4, 19);
            this.grpSpectrum.Name = "grpSpectrum";
            this.grpSpectrum.Size = new System.Drawing.Size(101, 46);
            this.grpSpectrum.TabIndex = 14;
            this.grpSpectrum.TabStop = false;
            this.grpSpectrum.Text = "Lv3 Spectrum";
            // 
            // txtSpectrum
            // 
            this.txtSpectrum.Location = new System.Drawing.Point(16, 16);
            this.txtSpectrum.Name = "txtSpectrum";
            this.txtSpectrum.ReadOnly = true;
            this.txtSpectrum.Size = new System.Drawing.Size(74, 20);
            this.txtSpectrum.TabIndex = 0;
            this.txtSpectrum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpFileName
            // 
            this.grpFileName.Controls.Add(this.txtFileName);
            this.grpFileName.Location = new System.Drawing.Point(218, 19);
            this.grpFileName.Name = "grpFileName";
            this.grpFileName.Size = new System.Drawing.Size(93, 46);
            this.grpFileName.TabIndex = 13;
            this.grpFileName.TabStop = false;
            this.grpFileName.Text = "Lv3 File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(7, 16);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(74, 20);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpDirectory
            // 
            this.grpDirectory.Controls.Add(this.txtDirectory);
            this.grpDirectory.Location = new System.Drawing.Point(110, 19);
            this.grpDirectory.Name = "grpDirectory";
            this.grpDirectory.Size = new System.Drawing.Size(101, 46);
            this.grpDirectory.TabIndex = 12;
            this.grpDirectory.TabStop = false;
            this.grpDirectory.Text = "Lv3 Directory";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(6, 16);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(89, 20);
            this.txtDirectory.TabIndex = 0;
            this.txtDirectory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtPortListen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtMulticast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtTTL.Location = new System.Drawing.Point(10, 16);
            this.txtTTL.Name = "txtTTL";
            this.txtTTL.Size = new System.Drawing.Size(32, 20);
            this.txtTTL.TabIndex = 0;
            this.txtTTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtAdapter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpPlay
            // 
            this.grpPlay.Controls.Add(this.grpThreatCount);
            this.grpPlay.Controls.Add(this.grpImageCount);
            this.grpPlay.Controls.Add(this.btnStop);
            this.grpPlay.Controls.Add(this.btnPlay);
            this.grpPlay.Controls.Add(this.btnNext);
            this.grpPlay.Location = new System.Drawing.Point(6, 120);
            this.grpPlay.Name = "grpPlay";
            this.grpPlay.Size = new System.Drawing.Size(413, 67);
            this.grpPlay.TabIndex = 19;
            this.grpPlay.TabStop = false;
            this.grpPlay.Text = "Player Controls";
            // 
            // grpThreatCount
            // 
            this.grpThreatCount.Controls.Add(this.txtThreatCnt);
            this.grpThreatCount.Location = new System.Drawing.Point(330, 12);
            this.grpThreatCount.Name = "grpThreatCount";
            this.grpThreatCount.Size = new System.Drawing.Size(71, 48);
            this.grpThreatCount.TabIndex = 11;
            this.grpThreatCount.TabStop = false;
            this.grpThreatCount.Text = "Threat Cnt";
            // 
            // txtThreatCnt
            // 
            this.txtThreatCnt.Location = new System.Drawing.Point(10, 19);
            this.txtThreatCnt.Name = "txtThreatCnt";
            this.txtThreatCnt.ReadOnly = true;
            this.txtThreatCnt.Size = new System.Drawing.Size(48, 20);
            this.txtThreatCnt.TabIndex = 1;
            this.txtThreatCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpImageCount
            // 
            this.grpImageCount.Controls.Add(this.txtImgCnt);
            this.grpImageCount.Location = new System.Drawing.Point(253, 13);
            this.grpImageCount.Name = "grpImageCount";
            this.grpImageCount.Size = new System.Drawing.Size(71, 48);
            this.grpImageCount.TabIndex = 10;
            this.grpImageCount.TabStop = false;
            this.grpImageCount.Text = "Image Cnt";
            // 
            // txtImgCnt
            // 
            this.txtImgCnt.Location = new System.Drawing.Point(10, 19);
            this.txtImgCnt.Name = "txtImgCnt";
            this.txtImgCnt.ReadOnly = true;
            this.txtImgCnt.Size = new System.Drawing.Size(48, 20);
            this.txtImgCnt.TabIndex = 1;
            this.txtImgCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(172, 24);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 28);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(91, 24);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 28);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(10, 24);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 28);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pbRunning
            // 
            this.pbRunning.Image = global::threat_test.Properties.Resources.running;
            this.pbRunning.Location = new System.Drawing.Point(374, 54);
            this.pbRunning.Name = "pbRunning";
            this.pbRunning.Size = new System.Drawing.Size(66, 59);
            this.pbRunning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRunning.TabIndex = 20;
            this.pbRunning.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 545);
            this.Controls.Add(this.pbRunning);
            this.Controls.Add(this.grpPlay);
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
            this.grpUID.ResumeLayout(false);
            this.grpUID.PerformLayout();
            this.grpSpectrum.ResumeLayout(false);
            this.grpSpectrum.PerformLayout();
            this.grpFileName.ResumeLayout(false);
            this.grpFileName.PerformLayout();
            this.grpDirectory.ResumeLayout(false);
            this.grpDirectory.PerformLayout();
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
            this.grpPlay.ResumeLayout(false);
            this.grpThreatCount.ResumeLayout(false);
            this.grpThreatCount.PerformLayout();
            this.grpImageCount.ResumeLayout(false);
            this.grpImageCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRunning)).EndInit();
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
        private System.Windows.Forms.TextBox txrPathName;
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
        private System.Windows.Forms.GroupBox grpPlay;
        private System.Windows.Forms.GroupBox grpImageCount;
        private System.Windows.Forms.TextBox txtImgCnt;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox grpFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.GroupBox grpDirectory;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.GroupBox grpSpectrum;
        private System.Windows.Forms.TextBox txtSpectrum;
        private System.Windows.Forms.GroupBox grpThreatCount;
        private System.Windows.Forms.TextBox txtThreatCnt;
        private System.Windows.Forms.PictureBox pbRunning;
        private System.Windows.Forms.GroupBox grpUID;
        private System.Windows.Forms.TextBox txtUID;
    }
}

