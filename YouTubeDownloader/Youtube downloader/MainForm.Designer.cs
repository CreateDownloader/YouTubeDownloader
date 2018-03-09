namespace Youtube_downloader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblSave = new System.Windows.Forms.Label();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.groupBoxQlty = new System.Windows.Forms.GroupBox();
            this.link0 = new System.Windows.Forms.LinkLabel();
            this.link1 = new System.Windows.Forms.LinkLabel();
            this.rdb4k = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbmaxqlty = new System.Windows.Forms.RadioButton();
            this.rdbsd360 = new System.Windows.Forms.RadioButton();
            this.rdbsd480 = new System.Windows.Forms.RadioButton();
            this.rdbhd720 = new System.Windows.Forms.RadioButton();
            this.rdbhd1080 = new System.Windows.Forms.RadioButton();
            this.linkgit = new System.Windows.Forms.LinkLabel();
            this.groupBoxFtype = new System.Windows.Forms.GroupBox();
            this.rdbmp3 = new System.Windows.Forms.RadioButton();
            this.rdbwebm = new System.Windows.Forms.RadioButton();
            this.rdbmp4 = new System.Windows.Forms.RadioButton();
            this.chkDefLoc = new System.Windows.Forms.CheckBox();
            this.chkPlaylst = new System.Windows.Forms.CheckBox();
            this.lblPLstart = new System.Windows.Forms.Label();
            this.txtPLstart = new System.Windows.Forms.TextBox();
            this.lblPLend = new System.Windows.Forms.Label();
            this.txtPLend = new System.Windows.Forms.TextBox();
            this.btndwnld = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnHideSt = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRld = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.prgrsbr = new System.Windows.Forms.ProgressBar();
            this.YTtitlebackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.lblRetrv = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lstQ = new System.Windows.Forms.ListBox();
            this.btnAddQ = new System.Windows.Forms.Button();
            this.btnRmvQ = new System.Windows.Forms.Button();
            this.btnRmvAll = new System.Windows.Forms.Button();
            this.groupBoxQlty.SuspendLayout();
            this.groupBoxFtype.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblURL
            // 
            this.lblURL.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblURL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblURL.Location = new System.Drawing.Point(12, 67);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(107, 32);
            this.lblURL.TabIndex = 0;
            this.lblURL.Text = "URL Of The Video :";
            this.lblURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtURL.Location = new System.Drawing.Point(124, 72);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(568, 22);
            this.txtURL.TabIndex = 1;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // lblSave
            // 
            this.lblSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSave.Location = new System.Drawing.Point(7, 109);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(77, 32);
            this.lblSave.TabIndex = 2;
            this.lblSave.Text = "Save TO :";
            this.lblSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdir
            // 
            this.txtdir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtdir.Location = new System.Drawing.Point(94, 117);
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(518, 21);
            this.txtdir.TabIndex = 2;
            this.txtdir.TextChanged += new System.EventHandler(this.txtdir_TextChanged);
            // 
            // groupBoxQlty
            // 
            this.groupBoxQlty.Controls.Add(this.link0);
            this.groupBoxQlty.Controls.Add(this.link1);
            this.groupBoxQlty.Controls.Add(this.rdb4k);
            this.groupBoxQlty.Controls.Add(this.label1);
            this.groupBoxQlty.Controls.Add(this.rdbmaxqlty);
            this.groupBoxQlty.Controls.Add(this.rdbsd360);
            this.groupBoxQlty.Controls.Add(this.rdbsd480);
            this.groupBoxQlty.Controls.Add(this.rdbhd720);
            this.groupBoxQlty.Controls.Add(this.rdbhd1080);
            this.groupBoxQlty.Controls.Add(this.linkgit);
            this.groupBoxQlty.Location = new System.Drawing.Point(289, 189);
            this.groupBoxQlty.Name = "groupBoxQlty";
            this.groupBoxQlty.Size = new System.Drawing.Size(428, 198);
            this.groupBoxQlty.TabIndex = 8;
            this.groupBoxQlty.TabStop = false;
            this.groupBoxQlty.Text = "Quality (depends on availability)";
            this.toolTip1.SetToolTip(this.groupBoxQlty, resources.GetString("groupBoxQlty.ToolTip"));
            // 
            // link0
            // 
            this.link0.AutoSize = true;
            this.link0.BackColor = System.Drawing.Color.Transparent;
            this.link0.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.link0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link0.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.link0.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.link0.Location = new System.Drawing.Point(115, 18);
            this.link0.Name = "link0";
            this.link0.Size = new System.Drawing.Size(173, 15);
            this.link0.TabIndex = 34;
            this.link0.TabStop = true;
            this.link0.Text = "Github.com/mohamedosama914";
            this.link0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.link0, "Go to the GitHub page of the developer.");
            this.link0.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link0_LinkClicked);
            // 
            // link1
            // 
            this.link1.AutoSize = true;
            this.link1.BackColor = System.Drawing.Color.Transparent;
            this.link1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.link1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.link1.LinkColor = System.Drawing.Color.Black;
            this.link1.Location = new System.Drawing.Point(242, 68);
            this.link1.Name = "link1";
            this.link1.Size = new System.Drawing.Size(101, 13);
            this.link1.TabIndex = 24;
            this.link1.TabStop = true;
            this.link1.Text = "Download FFmpeg";
            this.link1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.link1, "Go to DASH requires ffmpeg to be installed.");
            this.link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link1_LinkClicked);
            // 
            // rdb4k
            // 
            this.rdb4k.AutoSize = true;
            this.rdb4k.Location = new System.Drawing.Point(245, 103);
            this.rdb4k.Name = "rdb4k";
            this.rdb4k.Size = new System.Drawing.Size(74, 17);
            this.rdb4k.TabIndex = 10;
            this.rdb4k.TabStop = true;
            this.rdb4k.Text = "4k (DASH)";
            this.rdb4k.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "DASH Requires ffmpeg to be installed :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbmaxqlty
            // 
            this.rdbmaxqlty.AutoSize = true;
            this.rdbmaxqlty.Checked = true;
            this.rdbmaxqlty.Location = new System.Drawing.Point(51, 102);
            this.rdbmaxqlty.Name = "rdbmaxqlty";
            this.rdbmaxqlty.Size = new System.Drawing.Size(188, 17);
            this.rdbmaxqlty.TabIndex = 9;
            this.rdbmaxqlty.TabStop = true;
            this.rdbmaxqlty.Text = "Max. available quality (non DASH)";
            this.rdbmaxqlty.UseVisualStyleBackColor = true;
            // 
            // rdbsd360
            // 
            this.rdbsd360.AutoSize = true;
            this.rdbsd360.Location = new System.Drawing.Point(51, 148);
            this.rdbsd360.Name = "rdbsd360";
            this.rdbsd360.Size = new System.Drawing.Size(65, 17);
            this.rdbsd360.TabIndex = 14;
            this.rdbsd360.TabStop = true;
            this.rdbsd360.Text = "SD 360p";
            this.rdbsd360.UseVisualStyleBackColor = true;
            // 
            // rdbsd480
            // 
            this.rdbsd480.AutoSize = true;
            this.rdbsd480.Location = new System.Drawing.Point(245, 148);
            this.rdbsd480.Name = "rdbsd480";
            this.rdbsd480.Size = new System.Drawing.Size(103, 17);
            this.rdbsd480.TabIndex = 13;
            this.rdbsd480.TabStop = true;
            this.rdbsd480.Text = "SD 480p (DASH)";
            this.rdbsd480.UseVisualStyleBackColor = true;
            // 
            // rdbhd720
            // 
            this.rdbhd720.AutoSize = true;
            this.rdbhd720.Location = new System.Drawing.Point(51, 125);
            this.rdbhd720.Name = "rdbhd720";
            this.rdbhd720.Size = new System.Drawing.Size(66, 17);
            this.rdbhd720.TabIndex = 12;
            this.rdbhd720.TabStop = true;
            this.rdbhd720.Text = "HD 720p";
            this.rdbhd720.UseVisualStyleBackColor = true;
            // 
            // rdbhd1080
            // 
            this.rdbhd1080.AutoSize = true;
            this.rdbhd1080.Location = new System.Drawing.Point(245, 126);
            this.rdbhd1080.Name = "rdbhd1080";
            this.rdbhd1080.Size = new System.Drawing.Size(110, 17);
            this.rdbhd1080.TabIndex = 11;
            this.rdbhd1080.TabStop = true;
            this.rdbhd1080.Text = "HD 1080p (DASH)";
            this.rdbhd1080.UseVisualStyleBackColor = true;
            // 
            // linkgit
            // 
            this.linkgit.AutoSize = true;
            this.linkgit.BackColor = System.Drawing.Color.Transparent;
            this.linkgit.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.linkgit.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkgit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkgit.Location = new System.Drawing.Point(76, 39);
            this.linkgit.Name = "linkgit";
            this.linkgit.Size = new System.Drawing.Size(247, 14);
            this.linkgit.TabIndex = 23;
            this.linkgit.TabStop = true;
            this.linkgit.Text = "Github.com/CreateDownloader/YouTubeDownloader";
            this.linkgit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.linkgit, "Go to the GitHub page of the developer.");
            this.linkgit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkgit_LinkClicked);
            // 
            // groupBoxFtype
            // 
            this.groupBoxFtype.Controls.Add(this.rdbmp3);
            this.groupBoxFtype.Controls.Add(this.rdbwebm);
            this.groupBoxFtype.Controls.Add(this.rdbmp4);
            this.groupBoxFtype.Controls.Add(this.chkDefLoc);
            this.groupBoxFtype.Controls.Add(this.chkPlaylst);
            this.groupBoxFtype.Controls.Add(this.lblPLstart);
            this.groupBoxFtype.Controls.Add(this.txtPLstart);
            this.groupBoxFtype.Controls.Add(this.lblPLend);
            this.groupBoxFtype.Controls.Add(this.txtPLend);
            this.groupBoxFtype.Location = new System.Drawing.Point(12, 189);
            this.groupBoxFtype.Name = "groupBoxFtype";
            this.groupBoxFtype.Size = new System.Drawing.Size(271, 198);
            this.groupBoxFtype.TabIndex = 15;
            this.groupBoxFtype.TabStop = false;
            this.groupBoxFtype.Text = "File type";
            // 
            // rdbmp3
            // 
            this.rdbmp3.AutoSize = true;
            this.rdbmp3.Location = new System.Drawing.Point(6, 39);
            this.rdbmp3.Name = "rdbmp3";
            this.rdbmp3.Size = new System.Drawing.Size(106, 17);
            this.rdbmp3.TabIndex = 17;
            this.rdbmp3.TabStop = true;
            this.rdbmp3.Text = "MP3 (Audio only)";
            this.rdbmp3.UseVisualStyleBackColor = true;
            // 
            // rdbwebm
            // 
            this.rdbwebm.AutoSize = true;
            this.rdbwebm.Location = new System.Drawing.Point(57, 20);
            this.rdbwebm.Name = "rdbwebm";
            this.rdbwebm.Size = new System.Drawing.Size(55, 17);
            this.rdbwebm.TabIndex = 16;
            this.rdbwebm.Text = "Webm";
            this.rdbwebm.UseVisualStyleBackColor = true;
            // 
            // rdbmp4
            // 
            this.rdbmp4.AutoSize = true;
            this.rdbmp4.Checked = true;
            this.rdbmp4.Location = new System.Drawing.Point(6, 19);
            this.rdbmp4.Name = "rdbmp4";
            this.rdbmp4.Size = new System.Drawing.Size(45, 17);
            this.rdbmp4.TabIndex = 15;
            this.rdbmp4.TabStop = true;
            this.rdbmp4.Text = "MP4";
            this.rdbmp4.UseVisualStyleBackColor = true;
            // 
            // chkDefLoc
            // 
            this.chkDefLoc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkDefLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkDefLoc.Location = new System.Drawing.Point(6, 62);
            this.chkDefLoc.Name = "chkDefLoc";
            this.chkDefLoc.Size = new System.Drawing.Size(131, 19);
            this.chkDefLoc.TabIndex = 4;
            this.chkDefLoc.Text = "Set as default location";
            this.chkDefLoc.UseVisualStyleBackColor = true;
            this.chkDefLoc.CheckedChanged += new System.EventHandler(this.chkDefLoc_CheckedChanged);
            // 
            // chkPlaylst
            // 
            this.chkPlaylst.AutoSize = true;
            this.chkPlaylst.Location = new System.Drawing.Point(6, 87);
            this.chkPlaylst.Name = "chkPlaylst";
            this.chkPlaylst.Size = new System.Drawing.Size(160, 17);
            this.chkPlaylst.TabIndex = 18;
            this.chkPlaylst.Text = "URL is for a youtube playlist";
            this.toolTip1.SetToolTip(this.chkPlaylst, "Check if the URL you have entered is for a playlist.");
            this.chkPlaylst.UseVisualStyleBackColor = true;
            this.chkPlaylst.CheckedChanged += new System.EventHandler(this.chkPlaylst_CheckedChanged);
            // 
            // lblPLstart
            // 
            this.lblPLstart.Enabled = false;
            this.lblPLstart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPLstart.Location = new System.Drawing.Point(12, 110);
            this.lblPLstart.Name = "lblPLstart";
            this.lblPLstart.Size = new System.Drawing.Size(194, 18);
            this.lblPLstart.TabIndex = 19;
            this.lblPLstart.Text = "Start from number (Default is 1):";
            this.lblPLstart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPLstart
            // 
            this.txtPLstart.Enabled = false;
            this.txtPLstart.Location = new System.Drawing.Point(212, 110);
            this.txtPLstart.Multiline = true;
            this.txtPLstart.Name = "txtPLstart";
            this.txtPLstart.Size = new System.Drawing.Size(54, 26);
            this.txtPLstart.TabIndex = 20;
            // 
            // lblPLend
            // 
            this.lblPLend.Enabled = false;
            this.lblPLend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPLend.Location = new System.Drawing.Point(15, 142);
            this.lblPLend.Name = "lblPLend";
            this.lblPLend.Size = new System.Drawing.Size(191, 18);
            this.lblPLend.TabIndex = 21;
            this.lblPLend.Text = "End at number (Default is last):";
            this.lblPLend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPLend
            // 
            this.txtPLend.Enabled = false;
            this.txtPLend.Location = new System.Drawing.Point(212, 142);
            this.txtPLend.Multiline = true;
            this.txtPLend.Name = "txtPLend";
            this.txtPLend.Size = new System.Drawing.Size(54, 23);
            this.txtPLend.TabIndex = 22;
            // 
            // btndwnld
            // 
            this.btndwnld.Location = new System.Drawing.Point(223, 394);
            this.btndwnld.Name = "btndwnld";
            this.btndwnld.Size = new System.Drawing.Size(123, 27);
            this.btndwnld.TabIndex = 17;
            this.btndwnld.Text = "Download";
            this.toolTip1.SetToolTip(this.btndwnld, "Click to download the video(s).");
            this.btndwnld.UseVisualStyleBackColor = true;
            this.btndwnld.Click += new System.EventHandler(this.btndwnld_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(15, 461);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(705, 42);
            this.txtStatus.TabIndex = 24;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStatus.Visible = false;
            // 
            // btnHideSt
            // 
            this.btnHideSt.Location = new System.Drawing.Point(94, 393);
            this.btnHideSt.Name = "btnHideSt";
            this.btnHideSt.Size = new System.Drawing.Size(123, 27);
            this.btnHideSt.TabIndex = 25;
            this.btnHideSt.Text = "Hide queue";
            this.toolTip1.SetToolTip(this.btnHideSt, "Display or hide the queue.");
            this.btnHideSt.UseVisualStyleBackColor = true;
            this.btnHideSt.Visible = false;
            this.btnHideSt.Click += new System.EventHandler(this.btnHideSt_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 32767;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // btnRld
            // 
            this.btnRld.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRld.BackgroundImage")));
            this.btnRld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRld.Location = new System.Drawing.Point(694, 66);
            this.btnRld.Name = "btnRld";
            this.btnRld.Size = new System.Drawing.Size(31, 32);
            this.btnRld.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnRld, "Reload URL from clipboard.");
            this.btnRld.UseVisualStyleBackColor = true;
            this.btnRld.Click += new System.EventHandler(this.btnRld_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbrowse.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.ForeColor = System.Drawing.Color.White;
            this.btnbrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnbrowse.Image")));
            this.btnbrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbrowse.Location = new System.Drawing.Point(646, 106);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(67, 39);
            this.btnbrowse.TabIndex = 3;
            this.btnbrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnbrowse, "Browse for a folder");
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // prgrsbr
            // 
            this.prgrsbr.Location = new System.Drawing.Point(15, 427);
            this.prgrsbr.Maximum = 1000;
            this.prgrsbr.Name = "prgrsbr";
            this.prgrsbr.Size = new System.Drawing.Size(705, 28);
            this.prgrsbr.TabIndex = 27;
            this.prgrsbr.Visible = false;
            // 
            // YTtitlebackgroundWorker
            // 
            this.YTtitlebackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.YTtitlebackgroundWorker_DoWork);
            this.YTtitlebackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.YTtitlebackgroundWorker_RunWorkerCompleted);
            // 
            // txtfilename
            // 
            this.txtfilename.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtfilename.Location = new System.Drawing.Point(91, 151);
            this.txtfilename.Multiline = true;
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(619, 32);
            this.txtfilename.TabIndex = 7;
            // 
            // lblRetrv
            // 
            this.lblRetrv.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRetrv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRetrv.Location = new System.Drawing.Point(94, 159);
            this.lblRetrv.Name = "lblRetrv";
            this.lblRetrv.Size = new System.Drawing.Size(221, 15);
            this.lblRetrv.TabIndex = 11;
            this.lblRetrv.Text = "Retrieving title...";
            this.lblRetrv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRetrv.Visible = false;
            // 
            // lblFileName
            // 
            this.lblFileName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFileName.Location = new System.Drawing.Point(9, 151);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(79, 32);
            this.lblFileName.TabIndex = 12;
            this.lblFileName.Text = "File Name:";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(223, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 27);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel download";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(356, 394);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(123, 27);
            this.btnPause.TabIndex = 29;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lstQ
            // 
            this.lstQ.FormattingEnabled = true;
            this.lstQ.Location = new System.Drawing.Point(15, 509);
            this.lstQ.Name = "lstQ";
            this.lstQ.Size = new System.Drawing.Size(705, 134);
            this.lstQ.TabIndex = 30;
            this.lstQ.Visible = false;
            this.lstQ.SelectedIndexChanged += new System.EventHandler(this.lstQ_SelectedIndexChanged);
            // 
            // btnAddQ
            // 
            this.btnAddQ.Location = new System.Drawing.Point(485, 394);
            this.btnAddQ.Name = "btnAddQ";
            this.btnAddQ.Size = new System.Drawing.Size(123, 27);
            this.btnAddQ.TabIndex = 31;
            this.btnAddQ.Text = "Add to queue";
            this.btnAddQ.UseVisualStyleBackColor = true;
            this.btnAddQ.Click += new System.EventHandler(this.btnAddQ_Click);
            // 
            // btnRmvQ
            // 
            this.btnRmvQ.Location = new System.Drawing.Point(598, 509);
            this.btnRmvQ.Name = "btnRmvQ";
            this.btnRmvQ.Size = new System.Drawing.Size(122, 24);
            this.btnRmvQ.TabIndex = 32;
            this.btnRmvQ.Text = "Remove selected item";
            this.btnRmvQ.UseVisualStyleBackColor = true;
            this.btnRmvQ.Visible = false;
            this.btnRmvQ.Click += new System.EventHandler(this.btnRmvQ_Click);
            // 
            // btnRmvAll
            // 
            this.btnRmvAll.Location = new System.Drawing.Point(625, 620);
            this.btnRmvAll.Name = "btnRmvAll";
            this.btnRmvAll.Size = new System.Drawing.Size(95, 23);
            this.btnRmvAll.TabIndex = 33;
            this.btnRmvAll.Text = "Remove all items";
            this.btnRmvAll.UseVisualStyleBackColor = true;
            this.btnRmvAll.Visible = false;
            this.btnRmvAll.Click += new System.EventHandler(this.btnRmvAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 671);
            this.Controls.Add(this.btnRmvAll);
            this.Controls.Add(this.btnRmvQ);
            this.Controls.Add(this.btnAddQ);
            this.Controls.Add(this.lstQ);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.prgrsbr);
            this.Controls.Add(this.lblRetrv);
            this.Controls.Add(this.btnRld);
            this.Controls.Add(this.btnHideSt);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btndwnld);
            this.Controls.Add(this.groupBoxFtype);
            this.Controls.Add(this.groupBoxQlty);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.txtdir);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURL);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.Text = "YouTube Downloader 2.3.1.5";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxQlty.ResumeLayout(false);
            this.groupBoxQlty.PerformLayout();
            this.groupBoxFtype.ResumeLayout(false);
            this.groupBoxFtype.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.GroupBox groupBoxQlty;
        private System.Windows.Forms.RadioButton rdbsd360;
        private System.Windows.Forms.RadioButton rdbsd480;
        private System.Windows.Forms.RadioButton rdbhd720;
        private System.Windows.Forms.RadioButton rdbhd1080;
        private System.Windows.Forms.GroupBox groupBoxFtype;
        private System.Windows.Forms.RadioButton rdbwebm;
        private System.Windows.Forms.RadioButton rdbmp4;
        private System.Windows.Forms.Button btndwnld;
        private System.Windows.Forms.RadioButton rdbmaxqlty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDefLoc;
        private System.Windows.Forms.RadioButton rdb4k;
        private System.Windows.Forms.CheckBox chkPlaylst;
        private System.Windows.Forms.Label lblPLstart;
        private System.Windows.Forms.TextBox txtPLstart;
        private System.Windows.Forms.Label lblPLend;
        private System.Windows.Forms.TextBox txtPLend;
        private System.Windows.Forms.LinkLabel linkgit;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnHideSt;
        private System.Windows.Forms.Button btnRld;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ProgressBar prgrsbr;
        private System.ComponentModel.BackgroundWorker YTtitlebackgroundWorker;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label lblRetrv;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.RadioButton rdbmp3;
        private System.Windows.Forms.ListBox lstQ;
        private System.Windows.Forms.Button btnAddQ;
        private System.Windows.Forms.Button btnRmvQ;
        private System.Windows.Forms.Button btnRmvAll;
        private System.Windows.Forms.LinkLabel link1;
        private System.Windows.Forms.LinkLabel link0;
    }
}

