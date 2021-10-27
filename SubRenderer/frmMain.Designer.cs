//---------------------------------------------------------------------------
//  Version 1.0.0
//  Copyright (C) 2020 Yohan Sandun (yohan99ysk@gmail.com)
//
//  This file is part of SubRenderer.
//
//  SubRenderer is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  SubRenderer is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with SubRenderer.  If not, see <https://www.gnu.org/licenses/>.
//
//---------------------------------------------------------------------------
namespace SubRenderer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtInputSub = new System.Windows.Forms.TextBox();
            this.grpInputFiles = new System.Windows.Forms.GroupBox();
            this.btnBrowseVideo = new System.Windows.Forms.Button();
            this.btnBrowseSub = new System.Windows.Forms.Button();
            this.lblVideo = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txtInputVideo = new System.Windows.Forms.TextBox();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.tbPosition = new System.Windows.Forms.TrackBar();
            this.cmbQuality = new System.Windows.Forms.ComboBox();
            this.lblSubQuality = new System.Windows.Forms.Label();
            this.cmbFps = new System.Windows.Forms.ComboBox();
            this.lblBorderSize = new System.Windows.Forms.Label();
            this.lblFPS = new System.Windows.Forms.Label();
            this.tbBorderWidth = new System.Windows.Forms.TrackBar();
            this.txtSample = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPreview = new System.Windows.Forms.Label();
            this.pBorderCol = new System.Windows.Forms.Panel();
            this.lblBorderCol = new System.Windows.Forms.Label();
            this.lblFontCol = new System.Windows.Forms.Label();
            this.pFontCol = new System.Windows.Forms.Panel();
            this.cmbFontSize = new System.Windows.Forms.ComboBox();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.pPreview = new System.Windows.Forms.Panel();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblCores = new System.Windows.Forms.Label();
            this.cmbCores = new System.Windows.Forms.ComboBox();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtSaveTo = new System.Windows.Forms.TextBox();
            this.dlgSub = new System.Windows.Forms.OpenFileDialog();
            this.dlgVideo = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.dlgSave = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSubFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVideoFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveLoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRender = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSinhala = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTamil = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.youTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrRender = new System.Windows.Forms.Timer(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpProgress = new System.Windows.Forms.GroupBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblPleaseWait = new System.Windows.Forms.Label();
            this.grpInputFiles.SuspendLayout();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBorderWidth)).BeginInit();
            this.grpOutput.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputSub
            // 
            this.txtInputSub.Location = new System.Drawing.Point(47, 62);
            this.txtInputSub.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputSub.Name = "txtInputSub";
            this.txtInputSub.ReadOnly = true;
            this.txtInputSub.Size = new System.Drawing.Size(576, 22);
            this.txtInputSub.TabIndex = 0;
            // 
            // grpInputFiles
            // 
            this.grpInputFiles.Controls.Add(this.btnBrowseVideo);
            this.grpInputFiles.Controls.Add(this.btnBrowseSub);
            this.grpInputFiles.Controls.Add(this.lblVideo);
            this.grpInputFiles.Controls.Add(this.lblSubtitle);
            this.grpInputFiles.Controls.Add(this.txtInputVideo);
            this.grpInputFiles.Controls.Add(this.txtInputSub);
            this.grpInputFiles.Location = new System.Drawing.Point(-12, 33);
            this.grpInputFiles.Margin = new System.Windows.Forms.Padding(4);
            this.grpInputFiles.Name = "grpInputFiles";
            this.grpInputFiles.Padding = new System.Windows.Forms.Padding(4);
            this.grpInputFiles.Size = new System.Drawing.Size(789, 505);
            this.grpInputFiles.TabIndex = 1;
            this.grpInputFiles.TabStop = false;
            // 
            // btnBrowseVideo
            // 
            this.btnBrowseVideo.Location = new System.Drawing.Point(630, 161);
            this.btnBrowseVideo.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseVideo.Name = "btnBrowseVideo";
            this.btnBrowseVideo.Size = new System.Drawing.Size(100, 28);
            this.btnBrowseVideo.TabIndex = 5;
            this.btnBrowseVideo.Text = "Browse...";
            this.btnBrowseVideo.UseVisualStyleBackColor = true;
            this.btnBrowseVideo.Click += new System.EventHandler(this.btnBrowseVideo_Click);
            // 
            // btnBrowseSub
            // 
            this.btnBrowseSub.Location = new System.Drawing.Point(631, 62);
            this.btnBrowseSub.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseSub.Name = "btnBrowseSub";
            this.btnBrowseSub.Size = new System.Drawing.Size(100, 28);
            this.btnBrowseSub.TabIndex = 4;
            this.btnBrowseSub.Text = "Browse...";
            this.btnBrowseSub.UseVisualStyleBackColor = true;
            this.btnBrowseSub.Click += new System.EventHandler(this.btnBrowseSub_Click);
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Location = new System.Drawing.Point(42, 141);
            this.lblVideo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(170, 17);
            this.lblVideo.TabIndex = 3;
            this.lblVideo.Text = "Input video file (Optional):";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(43, 41);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(114, 17);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Input subtitle file:";
            // 
            // txtInputVideo
            // 
            this.txtInputVideo.Location = new System.Drawing.Point(46, 161);
            this.txtInputVideo.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputVideo.Name = "txtInputVideo";
            this.txtInputVideo.ReadOnly = true;
            this.txtInputVideo.Size = new System.Drawing.Size(576, 22);
            this.txtInputVideo.TabIndex = 1;
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.tbPosition);
            this.grpMain.Controls.Add(this.cmbQuality);
            this.grpMain.Controls.Add(this.lblSubQuality);
            this.grpMain.Controls.Add(this.cmbFps);
            this.grpMain.Controls.Add(this.lblBorderSize);
            this.grpMain.Controls.Add(this.lblFPS);
            this.grpMain.Controls.Add(this.tbBorderWidth);
            this.grpMain.Controls.Add(this.txtSample);
            this.grpMain.Controls.Add(this.lblPosition);
            this.grpMain.Controls.Add(this.lblPreview);
            this.grpMain.Controls.Add(this.pBorderCol);
            this.grpMain.Controls.Add(this.lblBorderCol);
            this.grpMain.Controls.Add(this.lblFontCol);
            this.grpMain.Controls.Add(this.pFontCol);
            this.grpMain.Controls.Add(this.cmbFontSize);
            this.grpMain.Controls.Add(this.lblFontSize);
            this.grpMain.Controls.Add(this.cmbFont);
            this.grpMain.Controls.Add(this.lblFont);
            this.grpMain.Controls.Add(this.pPreview);
            this.grpMain.Enabled = false;
            this.grpMain.Location = new System.Drawing.Point(-12, 33);
            this.grpMain.Margin = new System.Windows.Forms.Padding(4);
            this.grpMain.Name = "grpMain";
            this.grpMain.Padding = new System.Windows.Forms.Padding(4);
            this.grpMain.Size = new System.Drawing.Size(789, 505);
            this.grpMain.TabIndex = 2;
            this.grpMain.TabStop = false;
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(598, 176);
            this.tbPosition.Maximum = 30;
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbPosition.Size = new System.Drawing.Size(56, 276);
            this.tbPosition.TabIndex = 33;
            this.tbPosition.Value = 15;
            this.tbPosition.Scroll += new System.EventHandler(this.tbPosition_Scroll);
            // 
            // cmbQuality
            // 
            this.cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuality.FormattingEnabled = true;
            this.cmbQuality.Location = new System.Drawing.Point(210, 115);
            this.cmbQuality.Margin = new System.Windows.Forms.Padding(4);
            this.cmbQuality.Name = "cmbQuality";
            this.cmbQuality.Size = new System.Drawing.Size(177, 24);
            this.cmbQuality.TabIndex = 32;
            this.cmbQuality.SelectedIndexChanged += new System.EventHandler(this.cmbQuality_SelectedIndexChanged);
            // 
            // lblSubQuality
            // 
            this.lblSubQuality.AutoSize = true;
            this.lblSubQuality.Location = new System.Drawing.Point(207, 93);
            this.lblSubQuality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubQuality.Name = "lblSubQuality";
            this.lblSubQuality.Size = new System.Drawing.Size(104, 17);
            this.lblSubQuality.TabIndex = 31;
            this.lblSubQuality.Text = "Subtitle quality:";
            // 
            // cmbFps
            // 
            this.cmbFps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFps.FormattingEnabled = true;
            this.cmbFps.Location = new System.Drawing.Point(45, 113);
            this.cmbFps.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFps.Name = "cmbFps";
            this.cmbFps.Size = new System.Drawing.Size(139, 24);
            this.cmbFps.TabIndex = 28;
            // 
            // lblBorderSize
            // 
            this.lblBorderSize.AutoSize = true;
            this.lblBorderSize.Location = new System.Drawing.Point(581, 26);
            this.lblBorderSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorderSize.Name = "lblBorderSize";
            this.lblBorderSize.Size = new System.Drawing.Size(84, 17);
            this.lblBorderSize.TabIndex = 28;
            this.lblBorderSize.Text = "Border size:";
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.Location = new System.Drawing.Point(42, 91);
            this.lblFPS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(38, 17);
            this.lblFPS.TabIndex = 27;
            this.lblFPS.Text = "FPS:";
            // 
            // tbBorderWidth
            // 
            this.tbBorderWidth.Location = new System.Drawing.Point(584, 46);
            this.tbBorderWidth.Maximum = 30;
            this.tbBorderWidth.Name = "tbBorderWidth";
            this.tbBorderWidth.Size = new System.Drawing.Size(147, 56);
            this.tbBorderWidth.TabIndex = 27;
            this.tbBorderWidth.Value = 15;
            this.tbBorderWidth.Scroll += new System.EventHandler(this.tbBorderWidth_Scroll);
            // 
            // txtSample
            // 
            this.txtSample.Location = new System.Drawing.Point(43, 472);
            this.txtSample.Margin = new System.Windows.Forms.Padding(4);
            this.txtSample.Name = "txtSample";
            this.txtSample.Size = new System.Drawing.Size(514, 22);
            this.txtSample.TabIndex = 26;
            this.txtSample.Text = "Sample සාම්පල්";
            this.txtSample.TextChanged += new System.EventHandler(this.txtSample_TextChanged);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(596, 156);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 17);
            this.lblPosition.TabIndex = 25;
            this.lblPosition.Text = "Position";
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(41, 156);
            this.lblPreview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(61, 17);
            this.lblPreview.TabIndex = 24;
            this.lblPreview.Text = "Preview:";
            // 
            // pBorderCol
            // 
            this.pBorderCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBorderCol.Location = new System.Drawing.Point(458, 48);
            this.pBorderCol.Margin = new System.Windows.Forms.Padding(4);
            this.pBorderCol.Name = "pBorderCol";
            this.pBorderCol.Size = new System.Drawing.Size(91, 25);
            this.pBorderCol.TabIndex = 23;
            // 
            // lblBorderCol
            // 
            this.lblBorderCol.AutoSize = true;
            this.lblBorderCol.Location = new System.Drawing.Point(454, 29);
            this.lblBorderCol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorderCol.Name = "lblBorderCol";
            this.lblBorderCol.Size = new System.Drawing.Size(90, 17);
            this.lblBorderCol.TabIndex = 22;
            this.lblBorderCol.Text = "Border color:";
            // 
            // lblFontCol
            // 
            this.lblFontCol.AutoSize = true;
            this.lblFontCol.Location = new System.Drawing.Point(329, 29);
            this.lblFontCol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFontCol.Name = "lblFontCol";
            this.lblFontCol.Size = new System.Drawing.Size(75, 17);
            this.lblFontCol.TabIndex = 21;
            this.lblFontCol.Text = "Font color:";
            // 
            // pFontCol
            // 
            this.pFontCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFontCol.Location = new System.Drawing.Point(333, 48);
            this.pFontCol.Margin = new System.Windows.Forms.Padding(4);
            this.pFontCol.Name = "pFontCol";
            this.pFontCol.Size = new System.Drawing.Size(91, 25);
            this.pFontCol.TabIndex = 19;
            // 
            // cmbFontSize
            // 
            this.cmbFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFontSize.FormattingEnabled = true;
            this.cmbFontSize.Location = new System.Drawing.Point(211, 48);
            this.cmbFontSize.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFontSize.Name = "cmbFontSize";
            this.cmbFontSize.Size = new System.Drawing.Size(91, 24);
            this.cmbFontSize.TabIndex = 18;
            this.cmbFontSize.SelectedIndexChanged += new System.EventHandler(this.cmbFontSize_SelectedIndexChanged);
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(207, 29);
            this.lblFontSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(69, 17);
            this.lblFontSize.TabIndex = 17;
            this.lblFontSize.Text = "Font size:";
            // 
            // cmbFont
            // 
            this.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Location = new System.Drawing.Point(45, 48);
            this.cmbFont.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(139, 24);
            this.cmbFont.TabIndex = 16;
            this.cmbFont.SelectedIndexChanged += new System.EventHandler(this.cmbFont_SelectedIndexChanged);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(41, 29);
            this.lblFont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(40, 17);
            this.lblFont.TabIndex = 15;
            this.lblFont.Text = "Font:";
            // 
            // pPreview
            // 
            this.pPreview.BackColor = System.Drawing.Color.White;
            this.pPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pPreview.Location = new System.Drawing.Point(45, 176);
            this.pPreview.Margin = new System.Windows.Forms.Padding(4);
            this.pPreview.Name = "pPreview";
            this.pPreview.Size = new System.Drawing.Size(512, 288);
            this.pPreview.TabIndex = 13;
            this.pPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pPreview_Paint);
            // 
            // dlgColor
            // 
            this.dlgColor.AnyColor = true;
            this.dlgColor.FullOpen = true;
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblCores);
            this.grpOutput.Controls.Add(this.cmbCores);
            this.grpOutput.Controls.Add(this.btnBrowseOutput);
            this.grpOutput.Controls.Add(this.lblOutput);
            this.grpOutput.Controls.Add(this.txtSaveTo);
            this.grpOutput.Enabled = false;
            this.grpOutput.Location = new System.Drawing.Point(-12, 33);
            this.grpOutput.Margin = new System.Windows.Forms.Padding(4);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding = new System.Windows.Forms.Padding(4);
            this.grpOutput.Size = new System.Drawing.Size(789, 505);
            this.grpOutput.TabIndex = 3;
            this.grpOutput.TabStop = false;
            // 
            // lblCores
            // 
            this.lblCores.AutoSize = true;
            this.lblCores.Location = new System.Drawing.Point(39, 41);
            this.lblCores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(160, 17);
            this.lblCores.TabIndex = 6;
            this.lblCores.Text = "Number of cores to use:";
            // 
            // cmbCores
            // 
            this.cmbCores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCores.FormattingEnabled = true;
            this.cmbCores.Location = new System.Drawing.Point(43, 61);
            this.cmbCores.Name = "cmbCores";
            this.cmbCores.Size = new System.Drawing.Size(70, 24);
            this.cmbCores.TabIndex = 5;
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(630, 151);
            this.btnBrowseOutput.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(100, 28);
            this.btnBrowseOutput.TabIndex = 4;
            this.btnBrowseOutput.Text = "Browse...";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(40, 132);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(128, 17);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Output destination:";
            // 
            // txtSaveTo
            // 
            this.txtSaveTo.Location = new System.Drawing.Point(44, 151);
            this.txtSaveTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaveTo.Name = "txtSaveTo";
            this.txtSaveTo.ReadOnly = true;
            this.txtSaveTo.Size = new System.Drawing.Size(578, 22);
            this.txtSaveTo.TabIndex = 0;
            // 
            // dlgSub
            // 
            this.dlgSub.Filter = "Subtitle (*.srt)|*.srt";
            // 
            // dlgVideo
            // 
            this.dlgVideo.Filter = "Matroska (*.mkv,*.mp4)|*.mkv;*.mp4";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(43, 74);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(688, 28);
            this.progressBar.TabIndex = 4;
            // 
            // dlgSave
            // 
            this.dlgSave.Description = "Destination";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuLanguage,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSubFile,
            this.mnuVideoFile,
            this.mnuSaveLoc,
            this.toolStripMenuItem1,
            this.mnuRender,
            this.toolStripMenuItem4,
            this.mnuRestore,
            this.toolStripMenuItem2,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuSubFile
            // 
            this.mnuSubFile.Name = "mnuSubFile";
            this.mnuSubFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuSubFile.Size = new System.Drawing.Size(256, 26);
            this.mnuSubFile.Text = "Load subtitle file";
            this.mnuSubFile.Click += new System.EventHandler(this.mnuSubFile_Click);
            // 
            // mnuVideoFile
            // 
            this.mnuVideoFile.Name = "mnuVideoFile";
            this.mnuVideoFile.Size = new System.Drawing.Size(256, 26);
            this.mnuVideoFile.Text = "Load video file";
            this.mnuVideoFile.Click += new System.EventHandler(this.mnuVideoFile_Click);
            // 
            // mnuSaveLoc
            // 
            this.mnuSaveLoc.Name = "mnuSaveLoc";
            this.mnuSaveLoc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuSaveLoc.Size = new System.Drawing.Size(256, 26);
            this.mnuSaveLoc.Text = "Save location";
            this.mnuSaveLoc.Click += new System.EventHandler(this.mnuSaveLoc_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(253, 6);
            // 
            // mnuRender
            // 
            this.mnuRender.Name = "mnuRender";
            this.mnuRender.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.mnuRender.Size = new System.Drawing.Size(256, 26);
            this.mnuRender.Text = "Start render";
            this.mnuRender.Click += new System.EventHandler(this.mnuRender_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(253, 6);
            // 
            // mnuRestore
            // 
            this.mnuRestore.Name = "mnuRestore";
            this.mnuRestore.Size = new System.Drawing.Size(256, 26);
            this.mnuRestore.Text = "Restore Defaults";
            this.mnuRestore.Click += new System.EventHandler(this.mnuRestore_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(253, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(256, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuLanguage
            // 
            this.mnuLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEnglish,
            this.mnuSinhala,
            this.mnuTamil});
            this.mnuLanguage.Name = "mnuLanguage";
            this.mnuLanguage.Size = new System.Drawing.Size(88, 24);
            this.mnuLanguage.Text = "Language";
            // 
            // mnuEnglish
            // 
            this.mnuEnglish.Checked = true;
            this.mnuEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuEnglish.Name = "mnuEnglish";
            this.mnuEnglish.Size = new System.Drawing.Size(201, 26);
            this.mnuEnglish.Text = "English";
            this.mnuEnglish.Click += new System.EventHandler(this.mnuEnglish_Click);
            // 
            // mnuSinhala
            // 
            this.mnuSinhala.Name = "mnuSinhala";
            this.mnuSinhala.Size = new System.Drawing.Size(201, 26);
            this.mnuSinhala.Text = "සිංහල (Sinhala)";
            this.mnuSinhala.Click += new System.EventHandler(this.mnuSinhala_Click);
            // 
            // mnuTamil
            // 
            this.mnuTamil.Name = "mnuTamil";
            this.mnuTamil.Size = new System.Drawing.Size(201, 26);
            this.mnuTamil.Text = "தமிழ் (Tamiḻ)";
            this.mnuTamil.Click += new System.EventHandler(this.mnuTamil_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.toolStripMenuItem3,
            this.youTubeToolStripMenuItem});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(55, 24);
            this.mnuHelp.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuAbout.Size = new System.Drawing.Size(157, 26);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(154, 6);
            // 
            // youTubeToolStripMenuItem
            // 
            this.youTubeToolStripMenuItem.Name = "youTubeToolStripMenuItem";
            this.youTubeToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.youTubeToolStripMenuItem.Text = "YouTube";
            // 
            // tmrRender
            // 
            this.tmrRender.Tick += new System.EventHandler(this.tmrRender_Tick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(619, 545);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(473, 545);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(113, 40);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "&Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(354, 545);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 40);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "< &Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpProgress
            // 
            this.grpProgress.Controls.Add(this.lblProgress);
            this.grpProgress.Controls.Add(this.lblPleaseWait);
            this.grpProgress.Controls.Add(this.progressBar);
            this.grpProgress.Location = new System.Drawing.Point(-12, 33);
            this.grpProgress.Name = "grpProgress";
            this.grpProgress.Size = new System.Drawing.Size(789, 505);
            this.grpProgress.TabIndex = 9;
            this.grpProgress.TabStop = false;
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(146, 115);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(585, 17);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = "0";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPleaseWait
            // 
            this.lblPleaseWait.AutoSize = true;
            this.lblPleaseWait.Location = new System.Drawing.Point(43, 41);
            this.lblPleaseWait.Name = "lblPleaseWait";
            this.lblPleaseWait.Size = new System.Drawing.Size(91, 17);
            this.lblPleaseWait.TabIndex = 5;
            this.lblPleaseWait.Text = "Please wait...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 593);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grpInputFiles);
            this.Controls.Add(this.grpProgress);
            this.Controls.Add(this.grpOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subtitle Renderer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpInputFiles.ResumeLayout(false);
            this.grpInputFiles.PerformLayout();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBorderWidth)).EndInit();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpProgress.ResumeLayout(false);
            this.grpProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputSub;
        private System.Windows.Forms.GroupBox grpInputFiles;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TextBox txtInputVideo;
        private System.Windows.Forms.Button btnBrowseVideo;
        private System.Windows.Forms.Button btnBrowseSub;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Panel pPreview;
        private System.Windows.Forms.ComboBox cmbFontSize;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label lblBorderCol;
        private System.Windows.Forms.Label lblFontCol;
        private System.Windows.Forms.Panel pFontCol;
        private System.Windows.Forms.Panel pBorderCol;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.TextBox txtSample;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtSaveTo;
        private System.Windows.Forms.OpenFileDialog dlgSub;
        private System.Windows.Forms.OpenFileDialog dlgVideo;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.FolderBrowserDialog dlgSave;
        private System.Windows.Forms.ComboBox cmbFps;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSubFile;
        private System.Windows.Forms.ToolStripMenuItem mnuVideoFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveLoc;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuRender;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.Timer tmrRender;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpProgress;
        private System.Windows.Forms.TrackBar tbPosition;
        private System.Windows.Forms.ComboBox cmbQuality;
        private System.Windows.Forms.Label lblSubQuality;
        private System.Windows.Forms.Label lblBorderSize;
        private System.Windows.Forms.TrackBar tbBorderWidth;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblPleaseWait;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.ComboBox cmbCores;
        private System.Windows.Forms.ToolStripMenuItem mnuLanguage;
        private System.Windows.Forms.ToolStripMenuItem mnuEnglish;
        private System.Windows.Forms.ToolStripMenuItem mnuSinhala;
        private System.Windows.Forms.ToolStripMenuItem mnuTamil;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem youTubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnuRestore;
    }
}

