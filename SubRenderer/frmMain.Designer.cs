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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtInputSub = new System.Windows.Forms.TextBox();
            this.grpInputFiles = new System.Windows.Forms.GroupBox();
            this.btnBrowseVideo = new System.Windows.Forms.Button();
            this.btnBrowseSub = new System.Windows.Forms.Button();
            this.lblVideo = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txtInputVideo = new System.Windows.Forms.TextBox();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.cmbFps = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSample = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pBorderCol = new System.Windows.Forms.Panel();
            this.lblBorderCol = new System.Windows.Forms.Label();
            this.lblFontCol = new System.Windows.Forms.Label();
            this.pFontCol = new System.Windows.Forms.Panel();
            this.cmbFontSize = new System.Windows.Forms.ComboBox();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.scrPos = new System.Windows.Forms.VScrollBar();
            this.pPreview = new System.Windows.Forms.Panel();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.cmbRes = new System.Windows.Forms.ComboBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.btnExportSub = new System.Windows.Forms.Button();
            this.btnRender = new System.Windows.Forms.Button();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSaveTo = new System.Windows.Forms.TextBox();
            this.dlgSub = new System.Windows.Forms.OpenFileDialog();
            this.dlgVideo = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.dlgSave = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSubFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVideoFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveLoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExportSub = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRender = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.txtHeight = new SubRenderer.IntegerTextBox();
            this.txtWidth = new SubRenderer.IntegerTextBox();
            this.grpInputFiles.SuspendLayout();
            this.grpMain.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputSub
            // 
            this.txtInputSub.Location = new System.Drawing.Point(6, 33);
            this.txtInputSub.Name = "txtInputSub";
            this.txtInputSub.ReadOnly = true;
            this.txtInputSub.Size = new System.Drawing.Size(301, 20);
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
            this.grpInputFiles.Location = new System.Drawing.Point(12, 27);
            this.grpInputFiles.Name = "grpInputFiles";
            this.grpInputFiles.Size = new System.Drawing.Size(399, 119);
            this.grpInputFiles.TabIndex = 1;
            this.grpInputFiles.TabStop = false;
            // 
            // btnBrowseVideo
            // 
            this.btnBrowseVideo.Location = new System.Drawing.Point(313, 80);
            this.btnBrowseVideo.Name = "btnBrowseVideo";
            this.btnBrowseVideo.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseVideo.TabIndex = 5;
            this.btnBrowseVideo.Text = "Browse...";
            this.btnBrowseVideo.UseVisualStyleBackColor = true;
            this.btnBrowseVideo.Click += new System.EventHandler(this.btnBrowseVideo_Click);
            // 
            // btnBrowseSub
            // 
            this.btnBrowseSub.Location = new System.Drawing.Point(313, 31);
            this.btnBrowseSub.Name = "btnBrowseSub";
            this.btnBrowseSub.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSub.TabIndex = 4;
            this.btnBrowseSub.Text = "Browse...";
            this.btnBrowseSub.UseVisualStyleBackColor = true;
            this.btnBrowseSub.Click += new System.EventHandler(this.btnBrowseSub_Click);
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Location = new System.Drawing.Point(3, 66);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(79, 13);
            this.lblVideo.TabIndex = 3;
            this.lblVideo.Text = "Input video file:";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(3, 16);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(86, 13);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Input subtitle file:";
            // 
            // txtInputVideo
            // 
            this.txtInputVideo.Location = new System.Drawing.Point(6, 82);
            this.txtInputVideo.Name = "txtInputVideo";
            this.txtInputVideo.ReadOnly = true;
            this.txtInputVideo.Size = new System.Drawing.Size(301, 20);
            this.txtInputVideo.TabIndex = 1;
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.cmbFps);
            this.grpMain.Controls.Add(this.label3);
            this.grpMain.Controls.Add(this.txtSample);
            this.grpMain.Controls.Add(this.label2);
            this.grpMain.Controls.Add(this.label1);
            this.grpMain.Controls.Add(this.pBorderCol);
            this.grpMain.Controls.Add(this.lblBorderCol);
            this.grpMain.Controls.Add(this.lblFontCol);
            this.grpMain.Controls.Add(this.pFontCol);
            this.grpMain.Controls.Add(this.cmbFontSize);
            this.grpMain.Controls.Add(this.lblFontSize);
            this.grpMain.Controls.Add(this.cmbFont);
            this.grpMain.Controls.Add(this.lblFont);
            this.grpMain.Controls.Add(this.scrPos);
            this.grpMain.Controls.Add(this.pPreview);
            this.grpMain.Controls.Add(this.txtHeight);
            this.grpMain.Controls.Add(this.lblHeight);
            this.grpMain.Controls.Add(this.txtWidth);
            this.grpMain.Controls.Add(this.lblWidth);
            this.grpMain.Controls.Add(this.cmbRes);
            this.grpMain.Controls.Add(this.lblRes);
            this.grpMain.Enabled = false;
            this.grpMain.Location = new System.Drawing.Point(417, 27);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(477, 401);
            this.grpMain.TabIndex = 2;
            this.grpMain.TabStop = false;
            // 
            // cmbFps
            // 
            this.cmbFps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFps.FormattingEnabled = true;
            this.cmbFps.Location = new System.Drawing.Point(397, 31);
            this.cmbFps.Name = "cmbFps";
            this.cmbFps.Size = new System.Drawing.Size(69, 21);
            this.cmbFps.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "FPS:";
            // 
            // txtSample
            // 
            this.txtSample.Location = new System.Drawing.Point(9, 372);
            this.txtSample.Name = "txtSample";
            this.txtSample.Size = new System.Drawing.Size(400, 20);
            this.txtSample.TabIndex = 26;
            this.txtSample.Text = "Sample සාම්පල්";
            this.txtSample.TextChanged += new System.EventHandler(this.txtSample_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Preview:";
            // 
            // pBorderCol
            // 
            this.pBorderCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBorderCol.Location = new System.Drawing.Point(397, 88);
            this.pBorderCol.Name = "pBorderCol";
            this.pBorderCol.Size = new System.Drawing.Size(69, 21);
            this.pBorderCol.TabIndex = 23;
            // 
            // lblBorderCol
            // 
            this.lblBorderCol.AutoSize = true;
            this.lblBorderCol.Location = new System.Drawing.Point(394, 72);
            this.lblBorderCol.Name = "lblBorderCol";
            this.lblBorderCol.Size = new System.Drawing.Size(67, 13);
            this.lblBorderCol.TabIndex = 22;
            this.lblBorderCol.Text = "Border color:";
            // 
            // lblFontCol
            // 
            this.lblFontCol.AutoSize = true;
            this.lblFontCol.Location = new System.Drawing.Point(294, 72);
            this.lblFontCol.Name = "lblFontCol";
            this.lblFontCol.Size = new System.Drawing.Size(57, 13);
            this.lblFontCol.TabIndex = 21;
            this.lblFontCol.Text = "Font color:";
            // 
            // pFontCol
            // 
            this.pFontCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFontCol.Location = new System.Drawing.Point(297, 88);
            this.pFontCol.Name = "pFontCol";
            this.pFontCol.Size = new System.Drawing.Size(69, 21);
            this.pFontCol.TabIndex = 19;
            // 
            // cmbFontSize
            // 
            this.cmbFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFontSize.FormattingEnabled = true;
            this.cmbFontSize.Location = new System.Drawing.Point(196, 88);
            this.cmbFontSize.Name = "cmbFontSize";
            this.cmbFontSize.Size = new System.Drawing.Size(69, 21);
            this.cmbFontSize.TabIndex = 18;
            this.cmbFontSize.SelectedIndexChanged += new System.EventHandler(this.cmbFontSize_SelectedIndexChanged);
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(193, 72);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(52, 13);
            this.lblFontSize.TabIndex = 17;
            this.lblFontSize.Text = "Font size:";
            // 
            // cmbFont
            // 
            this.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Location = new System.Drawing.Point(9, 88);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(160, 21);
            this.cmbFont.TabIndex = 16;
            this.cmbFont.SelectedIndexChanged += new System.EventHandler(this.cmbFont_SelectedIndexChanged);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(6, 72);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(31, 13);
            this.lblFont.TabIndex = 15;
            this.lblFont.Text = "Font:";
            // 
            // scrPos
            // 
            this.scrPos.Location = new System.Drawing.Point(435, 141);
            this.scrPos.Name = "scrPos";
            this.scrPos.Size = new System.Drawing.Size(17, 225);
            this.scrPos.TabIndex = 14;
            this.scrPos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrPos_Scroll);
            // 
            // pPreview
            // 
            this.pPreview.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pPreview.Location = new System.Drawing.Point(9, 141);
            this.pPreview.Name = "pPreview";
            this.pPreview.Size = new System.Drawing.Size(400, 225);
            this.pPreview.TabIndex = 13;
            this.pPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pPreview_Paint);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(294, 16);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(193, 17);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width:";
            // 
            // cmbRes
            // 
            this.cmbRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRes.FormattingEnabled = true;
            this.cmbRes.Location = new System.Drawing.Point(9, 32);
            this.cmbRes.Name = "cmbRes";
            this.cmbRes.Size = new System.Drawing.Size(160, 21);
            this.cmbRes.TabIndex = 1;
            this.cmbRes.SelectedIndexChanged += new System.EventHandler(this.cmbRes_SelectedIndexChanged);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(6, 16);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(60, 13);
            this.lblRes.TabIndex = 0;
            this.lblRes.Text = "Resolution:";
            // 
            // dlgColor
            // 
            this.dlgColor.AnyColor = true;
            this.dlgColor.FullOpen = true;
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.btnExportSub);
            this.grpOutput.Controls.Add(this.btnRender);
            this.grpOutput.Controls.Add(this.btnBrowseOutput);
            this.grpOutput.Controls.Add(this.label4);
            this.grpOutput.Controls.Add(this.txtSaveTo);
            this.grpOutput.Enabled = false;
            this.grpOutput.Location = new System.Drawing.Point(12, 309);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(399, 119);
            this.grpOutput.TabIndex = 3;
            this.grpOutput.TabStop = false;
            // 
            // btnExportSub
            // 
            this.btnExportSub.Location = new System.Drawing.Point(9, 72);
            this.btnExportSub.Name = "btnExportSub";
            this.btnExportSub.Size = new System.Drawing.Size(133, 41);
            this.btnExportSub.TabIndex = 6;
            this.btnExportSub.Text = "Export subtitle only";
            this.btnExportSub.UseVisualStyleBackColor = true;
            this.btnExportSub.Click += new System.EventHandler(this.btnExportSub_Click);
            // 
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(255, 72);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(133, 41);
            this.btnRender.TabIndex = 5;
            this.btnRender.Text = "Start render";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(313, 30);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutput.TabIndex = 4;
            this.btnBrowseOutput.Text = "Browse...";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Output destination:";
            // 
            // txtSaveTo
            // 
            this.txtSaveTo.Location = new System.Drawing.Point(9, 32);
            this.txtSaveTo.Name = "txtSaveTo";
            this.txtSaveTo.ReadOnly = true;
            this.txtSaveTo.Size = new System.Drawing.Size(298, 20);
            this.txtSaveTo.TabIndex = 0;
            // 
            // dlgSub
            // 
            this.dlgSub.Filter = "Subtitle (*.srt)|*.srt";
            // 
            // dlgVideo
            // 
            this.dlgVideo.Filter = "Matroska (*.mkv)|*.mkv;*.mp4";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 457);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(881, 23);
            this.progressBar.TabIndex = 4;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(9, 441);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(48, 13);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Text = "Progress";
            // 
            // dlgSave
            // 
            this.dlgSave.Description = "Destination";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
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
            this.mnuExportSub,
            this.mnuRender,
            this.toolStripMenuItem2,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuSubFile
            // 
            this.mnuSubFile.Name = "mnuSubFile";
            this.mnuSubFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuSubFile.Size = new System.Drawing.Size(204, 22);
            this.mnuSubFile.Text = "Load subtitle file";
            this.mnuSubFile.Click += new System.EventHandler(this.mnuSubFile_Click);
            // 
            // mnuVideoFile
            // 
            this.mnuVideoFile.Name = "mnuVideoFile";
            this.mnuVideoFile.Size = new System.Drawing.Size(204, 22);
            this.mnuVideoFile.Text = "Load video file";
            this.mnuVideoFile.Click += new System.EventHandler(this.mnuVideoFile_Click);
            // 
            // mnuSaveLoc
            // 
            this.mnuSaveLoc.Name = "mnuSaveLoc";
            this.mnuSaveLoc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuSaveLoc.Size = new System.Drawing.Size(204, 22);
            this.mnuSaveLoc.Text = "Save location";
            this.mnuSaveLoc.Click += new System.EventHandler(this.mnuSaveLoc_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 6);
            // 
            // mnuExportSub
            // 
            this.mnuExportSub.Name = "mnuExportSub";
            this.mnuExportSub.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.mnuExportSub.Size = new System.Drawing.Size(204, 22);
            this.mnuExportSub.Text = "Export subtitle only";
            this.mnuExportSub.Click += new System.EventHandler(this.mnuExportSub_Click);
            // 
            // mnuRender
            // 
            this.mnuRender.Name = "mnuRender";
            this.mnuRender.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.mnuRender.Size = new System.Drawing.Size(204, 22);
            this.mnuRender.Text = "Start render";
            this.mnuRender.Click += new System.EventHandler(this.mnuRender_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(201, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(204, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuAbout.Size = new System.Drawing.Size(126, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(297, 32);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(69, 20);
            this.txtHeight.TabIndex = 5;
            this.txtHeight.Text = "0";
            this.txtHeight.Value = 0;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(196, 33);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(69, 20);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.Text = "0";
            this.txtWidth.Value = 0;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 492);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grpInputFiles);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subtitle Renderer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpInputFiles.ResumeLayout(false);
            this.grpInputFiles.PerformLayout();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.ComboBox cmbRes;
        private IntegerTextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private IntegerTextBox txtWidth;
        private System.Windows.Forms.VScrollBar scrPos;
        private System.Windows.Forms.Panel pPreview;
        private System.Windows.Forms.ComboBox cmbFontSize;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label lblBorderCol;
        private System.Windows.Forms.Label lblFontCol;
        private System.Windows.Forms.Panel pFontCol;
        private System.Windows.Forms.Panel pBorderCol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSample;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Button btnExportSub;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSaveTo;
        private System.Windows.Forms.OpenFileDialog dlgSub;
        private System.Windows.Forms.OpenFileDialog dlgVideo;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.FolderBrowserDialog dlgSave;
        private System.Windows.Forms.ComboBox cmbFps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSubFile;
        private System.Windows.Forms.ToolStripMenuItem mnuVideoFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveLoc;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExportSub;
        private System.Windows.Forms.ToolStripMenuItem mnuRender;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
    }
}

