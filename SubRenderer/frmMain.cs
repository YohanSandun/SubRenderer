//---------------------------------------------------------------------------
//  Version 1.0.0
//  Copyright (C) 2020 Yohan Sandun (yohan99ysk@gmail.com)
//  Copyright (C) 2002 Alain Vielle (vielle@bigfoot.com)
//  Copyright (C) 2003 Petr Vyskocil (yusaku@anime.cz)
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
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics;
//---------------------------------------------------------------------------
namespace SubRenderer
{
    public partial class frmMain : Form
    {
        string mSubtitleFile     = "";
        string mSubtitleFilePath = "";
        string mVideoFile        = "";
        string mVideoFilePath    = "";
        string mWorkingDir       = ""; // A directory for store bitmaps.
        string mSaveDir          = "";

        Color mFontColor = Color.White;
        Color mBorderColor = Color.Black;

        Graphics mGPreview = null;

        Process mMkvMerge = new Process();

        public frmMain()
        {
            InitializeComponent();
            pFontCol.MouseClick += pFontCol_MouseClick;
            pBorderCol.MouseClick += pBorderCol_MouseClick;
        }

        void pBorderCol_MouseClick(object sender, MouseEventArgs e)
        {
            dlgColor.Color = mBorderColor;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                mBorderColor = dlgColor.Color;
                pBorderCol.BackColor = mBorderColor;
                RefreshPreview();
            }
        }

        void pFontCol_MouseClick(object sender, MouseEventArgs e)
        {
            dlgColor.Color = mFontColor;
            if (dlgColor.ShowDialog() == DialogResult.OK) {
                mFontColor = dlgColor.Color;
                pFontCol.BackColor = mFontColor;
                RefreshPreview();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PrepareResolutions();
            PrepareFonts();
            PrepareFPS();
            PreparePreview();

            pFontCol.BackColor = mFontColor;
            pBorderCol.BackColor = mBorderColor;
        }

        // Preparing FPS combo box.
        void PrepareFPS() {
            cmbFps.Items.AddRange(new string[] { 
            "23.976","24","25","29.97","30","50", "59.94", "60"
            });
            cmbFps.SelectedIndex = 0;
        }

        // Preparing resolution combo box.
        void PrepareResolutions() {
            cmbRes.Items.AddRange(new string[] { 
            "3840 x 2160 (4K)",
            "2560 x 1440 (Quad HD)",
            "1920 x 1080 (Full HD)",
            "1280 x 720 (HD)",
            "720 x 576 (MPEG-2 PAL)",
            "720 x 480 (MPEG-2 NTSC)",
            "Custom"});
            cmbRes.SelectedIndex = 3;
        }

        // Preparing fonts combo box.
        void PrepareFonts() {
            int i = 0;
            int fontIndex = 0;
            foreach (FontFamily item in FontFamily.Families)
            {
                cmbFont.Items.Add(item.Name);
                if (item.Name == "Iskoola Pota")
                    fontIndex = i;
                i++;
            }

            if (cmbFont.Items.Count > 0)
                cmbFont.SelectedIndex = fontIndex;

            cmbFontSize.Items.AddRange(new string[] { "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75" });
            cmbFontSize.SelectedIndex = 5;
        }

        // Preparing subtitle preview.
        void PreparePreview() {
            mGPreview = pPreview.CreateGraphics();
            SetPositionValues();
        }

        // Refresh subtitle preview.
        void RefreshPreview() {
            if (mGPreview == null)
                return;

            mGPreview.Clear(Color.Gray);
            int fontSize = int.Parse(cmbFontSize.SelectedItem.ToString()) / 2;
            Font fontFace = new Font(cmbFont.SelectedItem.ToString(), fontSize, FontStyle.Bold);

            mGPreview.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            mGPreview.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            mGPreview.InterpolationMode = InterpolationMode.High;

            // Following four lines are drawing out-line of the text.
            TextRenderer.DrawText(mGPreview, txtSample.Text, fontFace, new Point(pPreview.Width + 4, scrPos.Value * 225 / txtHeight.Value + 1), mBorderColor, TextFormatFlags.HorizontalCenter);
            TextRenderer.DrawText(mGPreview, txtSample.Text, fontFace, new Point(pPreview.Width - 4, scrPos.Value * 225 / txtHeight.Value - 1), mBorderColor, TextFormatFlags.HorizontalCenter);
            TextRenderer.DrawText(mGPreview, txtSample.Text, fontFace, new Point(pPreview.Width + 4, scrPos.Value * 225 / txtHeight.Value - 1), mBorderColor, TextFormatFlags.HorizontalCenter);
            TextRenderer.DrawText(mGPreview, txtSample.Text, fontFace, new Point(pPreview.Width - 4, scrPos.Value * 225 / txtHeight.Value + 1), mBorderColor, TextFormatFlags.HorizontalCenter);

            // Drawing the actual text.
            TextRenderer.DrawText(mGPreview, txtSample.Text, fontFace, new Point(pPreview.Width, scrPos.Value * 225 / txtHeight.Value), mFontColor, TextFormatFlags.HorizontalCenter);

            TextRenderer.DrawText(mGPreview, txtSample.Text, fontFace, new Point(pPreview.Width + 4, scrPos.Value * 225 / txtHeight.Value - fontSize + 1), mBorderColor, TextFormatFlags.HorizontalCenter);
            TextRenderer.DrawText(mGPreview, txtSample.Text, fontFace, new Point(pPreview.Width - 4, scrPos.Value * 225 / txtHeight.Value - fontSize - 1), mBorderColor, TextFormatFlags.HorizontalCenter);
            TextRenderer.DrawText(mGPreview, txtSample.Text, fontFace, new Point(pPreview.Width + 4, scrPos.Value * 225 / txtHeight.Value - fontSize - 1), mBorderColor, TextFormatFlags.HorizontalCenter);
            TextRenderer.DrawText(mGPreview, txtSample.Text, fontFace, new Point(pPreview.Width - 4, scrPos.Value * 225 / txtHeight.Value - fontSize + 1), mBorderColor, TextFormatFlags.HorizontalCenter);

            TextRenderer.DrawText(mGPreview, txtSample.Text, fontFace, new Point(pPreview.Width, scrPos.Value * 225 / txtHeight.Value - fontSize), mFontColor, TextFormatFlags.HorizontalCenter);

            mGPreview.Flush();
            fontFace.Dispose();
        }

        // Change width and height along with selected resolution.
        private void cmbRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbRes.SelectedIndex) { 
                case 0:
                    txtWidth.Value = 3840; txtHeight.Value = 2160;
                    break;
                case 1:
                    txtWidth.Value = 2560; txtHeight.Value = 1440;
                    break;
                case 2:
                    txtWidth.Value = 1920; txtHeight.Value = 1080;
                    break;
                case 3:
                    txtWidth.Value = 1280; txtHeight.Value = 720;
                    break;
                case 4:
                    txtWidth.Value = 720; txtHeight.Value = 576;
                    break;
                case 5:
                    txtWidth.Value = 720; txtHeight.Value = 480;
                    break;
            }
        }

        // Choose resolution by given width and height.
        void SelectResolution(int width, int height) {
            for (int i = 0; i < cmbRes.Items.Count; i++)
            {
                if (cmbRes.Items[i].ToString().StartsWith(width + " x " + height)) {
                    cmbRes.SelectedIndex = i;
                    return;
                }
            }
            cmbRes.SelectedIndex = 6;
        }

        // Recalculate and set vertical position values according to current width and height 
        void SetPositionValues() {
            try
            {
                scrPos.Maximum = txtHeight.Value - (txtHeight.Value * 90 / 720);
                scrPos.Minimum = 100;
                scrPos.Value = txtHeight.Value - (txtHeight.Value * 90 / 720);
            }
            catch { }
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            SelectResolution(txtWidth.Value, txtHeight.Value);
            SetPositionValues();
            RefreshPreview();
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            SelectResolution(txtWidth.Value, txtHeight.Value);
            SetPositionValues();
            RefreshPreview();
        }

        private void pPreview_Paint(object sender, PaintEventArgs e)
        {
            RefreshPreview();
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void cmbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void scrPos_Scroll(object sender, ScrollEventArgs e)
        {
            RefreshPreview();
        }

        private void txtSample_TextChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        
        private void btnBrowseSub_Click(object sender, EventArgs e)
        {
            BrowseSubtitle();
        }

        // Browsing for source subtitle file.
        // Currently only support for .srt files.
        void BrowseSubtitle() {
            if (dlgSub.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtInputSub.Text = dlgSub.FileName;
                mSubtitleFile = dlgSub.FileName;
                mSubtitleFilePath = mSubtitleFile.Replace(dlgSub.SafeFileName, "");
                string ext = dlgSub.SafeFileName.Substring(dlgSub.SafeFileName.LastIndexOf('.'));
                // If there is a video file with subtitle, then load it too.
                if (File.Exists(mSubtitleFilePath + dlgSub.SafeFileName.Replace(ext, ".mkv")))
                {
                    txtInputVideo.Text = mSubtitleFilePath + dlgSub.SafeFileName.Replace(ext, ".mkv");
                    mVideoFile = mSubtitleFilePath + dlgSub.SafeFileName.Replace(ext, ".mkv");
                    mVideoFilePath = mVideoFile.Replace(dlgSub.SafeFileName.Replace(ext, ".mkv"), "");
                }
                grpMain.Enabled = true;
                grpOutput.Enabled = true;
                if (mVideoFile.Trim() == "" || !File.Exists(mVideoFile))
                    btnRender.Enabled = false;
            }
        }

        private void btnBrowseVideo_Click(object sender, EventArgs e)
        {
            BrowseVideo();
        }

        // Browsing for source video file.
        // Currently only support for .mkv and .mp4 files.
        void BrowseVideo() {
            if (dlgVideo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtInputVideo.Text = dlgVideo.FileName;
                mVideoFile = dlgVideo.FileName;
                mVideoFilePath = mVideoFile.Replace(dlgVideo.SafeFileName, "");
                string ext = dlgVideo.SafeFileName.Substring(dlgVideo.SafeFileName.LastIndexOf('.'));
                // If there is a subtitle file with video, then load it too.
                if (File.Exists(mVideoFilePath + dlgVideo.SafeFileName.Replace(ext, ".srt")))
                {
                    txtInputSub.Text = mVideoFilePath + dlgVideo.SafeFileName.Replace(ext, ".srt");
                    mSubtitleFile = mVideoFilePath + dlgVideo.SafeFileName.Replace(ext, ".srt");
                    mSubtitleFilePath = mSubtitleFile.Replace(dlgVideo.SafeFileName.Replace(ext, ".srt"), "");
                }
                grpMain.Enabled = true;
                grpOutput.Enabled = true;
                btnRender.Enabled = true;
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            BrowseDestination();
        }

        // Browsing for destination.
        void BrowseDestination() {
            if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSaveTo.Text = dlgSave.SelectedPath;
                mWorkingDir = dlgSave.SelectedPath + "\\subrender_temp_dir\\";
                mSaveDir = dlgSave.SelectedPath + "\\";
            }
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            Render();
        }

        void Render() {
            if (mSubtitleFile.Trim() == "" | !File.Exists(mSubtitleFile))
            {
                MessageBox.Show("Please select a source subtitle file first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (mVideoFile.Trim() == "" | !File.Exists(mVideoFile))
            {
                MessageBox.Show("Please select a source video file first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (mWorkingDir.Trim() == "")
            {
                MessageBox.Show("Please select a location to save the file(s)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            grpInputFiles.Enabled = false;
            grpOutput.Enabled = false;
            grpMain.Enabled = false;
            GenerateBitmaps();
            GenerateSubFile();
            MergeMKV();
        }

        // Generating bitmap files for each text line in subtitle.
        void GenerateBitmaps() {
            if (!Directory.Exists(mWorkingDir))
                Directory.CreateDirectory(mWorkingDir);

            // Parse .srt file and store extracted data in SRTSegment array.
            SRTSegment[] segments = SRTParser.Parse(mSubtitleFile);

            lblProgress.Text = "Generating Bitmaps...";
            progressBar.Maximum = segments.Length;

            // Creating .son file and start writing into it.
            StreamWriter sw = new StreamWriter(File.OpenWrite(mWorkingDir + "subrenderer.son"));
            sw.WriteLine("Contrast	(0 15 15 15)");
            sw.WriteLine("Display_Area	(0 " + (txtHeight.Value - (txtHeight.Value * 90 / 720)) + " " + txtWidth.Value + " 715)");
            sw.WriteLine("Color	(0 0 2 0)");
            bool oldTwoLines = false;
            for (int i = 0; i < segments.Length; i++)
            {
                if (segments[i].TextLines.Length >= 2 && !oldTwoLines)
                {
                    sw.WriteLine("Display_Area	(0 " + (scrPos.Value - (30 * txtHeight.Value / 720)) + " " + txtWidth.Value + " 715)");
                    oldTwoLines = true;
                }
                else
                {
                    if (oldTwoLines)
                    {
                        sw.WriteLine("Display_Area	(0 " + (scrPos.Value) + " " + txtWidth.Value + " 715)");
                        oldTwoLines = false;
                    }
                }
                sw.WriteLine(segments[i].Number + "	" + segments[i].GetStartTime() + "	" + segments[i].GetEndTime() + "	" + segments[i].Number + ".bmp");
                GenerateBitmap(segments[i].Number, segments[i].TextLines, segments[i].IsItalic, segments[i].IsUnderline);
                progressBar.Value++;
                Application.DoEvents();
            }
            sw.Flush();
            sw.Close();
        }

        // Create a bitmap file with given text.
        void GenerateBitmap(string id, string[] lines, bool isItalic, bool isUnderline)
        {
            FontStyle fontStyle = FontStyle.Bold;
            if (isItalic) fontStyle = FontStyle.Italic;
            if (isUnderline) fontStyle = FontStyle.Underline;

            Font fontText = new Font(cmbFont.SelectedItem.ToString(), int.Parse(cmbFontSize.SelectedItem.ToString()), fontStyle);
            int lineHeight = (int)(fontText.Size + (fontText.Size * 9 / 40));
            
            Bitmap bmp = new Bitmap(txtWidth.Value, (lines.Length * lineHeight) + 25);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.Red);

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.High;

            for (int i = 0; i < lines.Length; i++)
            {
                // Following four lines are drawing out-line of the text.
                TextRenderer.DrawText(g, lines[i], fontText, new Point(txtWidth.Value + 4, i * lineHeight + 2), Color.Blue, TextFormatFlags.HorizontalCenter);
                TextRenderer.DrawText(g, lines[i], fontText, new Point(txtWidth.Value - 4, i * lineHeight - 2), Color.Blue, TextFormatFlags.HorizontalCenter);
                TextRenderer.DrawText(g, lines[i], fontText, new Point(txtWidth.Value + 4, i * lineHeight - 2), Color.Blue, TextFormatFlags.HorizontalCenter);
                TextRenderer.DrawText(g, lines[i], fontText, new Point(txtWidth.Value - 4, i * lineHeight + 2), Color.Blue, TextFormatFlags.HorizontalCenter);

                // Drawing the actual text.
                TextRenderer.DrawText(g, lines[i], fontText, new Point(txtWidth.Value, i * lineHeight), Color.Black, TextFormatFlags.HorizontalCenter);
            }

            g.Flush();
            g.Save();
            fontText.Dispose();

            // Following section is looping though all the pixels of drawn bitmap
            // and making darken blue pixels as pure blue pixels.
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData data = bmp.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);
            byte[] rgbs = new byte[Math.Abs(data.Stride) * bmp.Height];
            System.Runtime.InteropServices.Marshal.Copy((IntPtr)data.Scan0, rgbs, 0, rgbs.Length);
            for (int i = 0; i < rgbs.Length; i += 4)
            {
                if (rgbs[i] >= 10)
                    rgbs[i] = 255;
            }
            System.Runtime.InteropServices.Marshal.Copy(rgbs, 0, (IntPtr)data.Scan0, rgbs.Length);
            bmp.UnlockBits(data);
            bmp.Save(mWorkingDir + id + ".bmp", ImageFormat.Png); // Actually we are using png because it's small in size.
            bmp.Dispose();
        }

        long fileOffset = 0; // For tracking current offset of the .sub file.

        // Generaing the .sub and .idx files.
        void GenerateSubFile() {
            lblProgress.Text = "Merging bitmaps...";
            long offset = 0;			
            long timefrom;
            long timeto;
            int width = txtWidth.Value;
            int height = txtHeight.Value;
            float fps = float.Parse(cmbFps.SelectedItem.ToString());
            int x = 0;
            int y = 0;
            int[] palette = new int[16];
            char[] fileline = new char[4096];
            byte cont1 = 0;
            byte cont2 = 0;
            byte col1 = 0;
            byte col2 = 0;
            int c1, c2, c3, c4, c5, c6, c7, c8, c9;
            c1 = c2 = c3 = c4 = c5 = c6 = c7 = c8 = c9 = 0;
            string fileName = "";

            string[] sonLines = File.ReadAllLines(mWorkingDir + "subrenderer.son");

            // Creating .sub file and start writing into it.
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(mSaveDir + mSubtitleFile.Replace(mSubtitleFilePath, "").Replace(".srt", "") + ".sub"));
            // Creating .idx file and start writing into it.
            StreamWriter sw = new StreamWriter(File.OpenWrite(mSaveDir + mSubtitleFile.Replace(mSubtitleFilePath, "").Replace(".srt", "") + ".idx"));
            
            sw.WriteLine("# VobSub index file, v7 (do not modify this line!)");
            sw.WriteLine("size: " + txtWidth.Value + "x" + txtHeight.Value);
            sw.WriteLine("org: 0, 0");
            sw.WriteLine("scale: 100%, 100%");
            sw.WriteLine("alpha: 100%");
            sw.WriteLine("smooth: OFF");
            sw.WriteLine("fadein/out: 0, 0");
            sw.WriteLine("align: OFF at LEFT TOP");
            sw.WriteLine("time offset: 0");
            sw.WriteLine("forced subs: OFF");
            sw.WriteLine("palette: " + GetColorString(mFontColor) + ", ff0000, " + GetColorString(mBorderColor) + ", ffff00, ff8000, 000000, 000000, 000000, 000000, 000000, 000000, 000000, 000000, 000000, 000000, 000000");
            sw.WriteLine("custom colors: OFF, tridx: 1110, colors: 808080, ffffff, 000000, 000000");
            sw.WriteLine("langidx: 0");
            sw.WriteLine("id: --, index: 0");

            progressBar.Maximum = sonLines.Length;
            progressBar.Value = 0;

            foreach (string l in sonLines)
            {
                string line = l.Trim();
                c1 = c2 = c3 = c4 = c5 = c6 = c7 = c8 = c9 = 0;
                if (line.StartsWith("Contrast"))
                {
                    string[] data = line.Replace("Contrast", "").Replace("(", "").Replace(")", "").Trim().Split(' ');
                    c1 = int.Parse(data[0]);
                    c2 = int.Parse(data[1]);
                    c3 = int.Parse(data[2]);
                    c4 = int.Parse(data[3]);
                    cont1 = (byte)(16 * c4 + c3);
                    cont2 = (byte)(16 * c1 + c2);
                }
                else if (line.StartsWith("Display_Area"))
                {
                    string[] data = line.Replace("Display_Area", "").Replace("(", "").Replace(")", "").Trim().Split(' ');
                    x = int.Parse(data[0]);
                    y = int.Parse(data[1]);
                    c3 = int.Parse(data[2]);
                    c4 = int.Parse(data[3]);
                }
                else if (line.StartsWith("Color"))
                {
                    string[] data = line.Replace("Color", "").Replace("(", "").Replace(")", "").Trim().Split(' ');
                    c1 = int.Parse(data[0]);
                    c2 = int.Parse(data[1]);
                    c3 = int.Parse(data[2]);
                    c4 = int.Parse(data[3]);
                    col1 = (byte)(16 * c4 + c3);
                    col2 = (byte)(16 * c1 + c2);
                }
                else if (line.Trim().EndsWith(".bmp"))
                {
                    string[] data = line.Trim().Split('	');
                    c1 = int.Parse(data[0]);

                    string[] startTime = data[1].Trim().Split(':');
                    c2 = int.Parse(startTime[0]);
                    c3 = int.Parse(startTime[1]);
                    c4 = int.Parse(startTime[2]);
                    c5 = int.Parse(startTime[3]);

                    string[] endTime = data[2].Trim().Split(':');
                    c6 = int.Parse(endTime[0]);
                    c7 = int.Parse(endTime[1]);
                    c8 = int.Parse(endTime[2]);
                    c9 = int.Parse(endTime[3]);

                    fileName = mWorkingDir + data[3].Trim();

                    timefrom = (long)((c2 * 3600000) + (c3 * 60000) + (c4 * 1000) + (1.0f * c5 * 1000 / fps));
                    timeto = (long)((c6 * 3600000) + (c7 * 60000) + (c8 * 1000) + (1.0f * c9 * 1000 / fps));
                    
                    sw.WriteLine("timestamp: " + GetNumberString((timefrom) / 3600000, 2) + ":" + GetNumberString(((timefrom) / 60000) % 60, 2) + ":" + GetNumberString(((timefrom) / 1000) % 60, 2) + ":" + GetNumberString((timefrom) % 1000, 3) + ", filepos: " + GetHexNumberString(offset, 9));

                    Bitmap bmp = new Bitmap(fileName);

                    // Time used here is in 1/90000th second
                    offset += DumpSub(bmp, width, height, x, y, timefrom * 90, (timeto - timefrom) * 90, col1, col2, cont1, cont2, bw);
                    bmp.Dispose();
                }
                progressBar.Value++;
                Application.DoEvents();
            }
            bw.Flush();
            bw.Close();

            sw.Flush();
            sw.Close();

            // Removing created temp files and bitmaps.
            try
            {
                DirectoryInfo dInfo = new DirectoryInfo(mWorkingDir);
                foreach (FileInfo file in dInfo.GetFiles())
                    file.Delete();
                dInfo.Delete(true);
            }
            catch { }
        }

        // Returns a horizontal pixel line from given bitmap. 
        int[] ScanLine(BitmapData data, long y)
        {
            try
            {
                var ptr = (IntPtr)((long)data.Scan0 + data.Stride * y);
                var ret = new byte[data.Width * 4];
                System.Runtime.InteropServices.Marshal.Copy(ptr, ret, 0, ret.Length);

                var intarr = new int[data.Width];
                int j = 0;
                for (int i = 0; i < ret.Length; i += 4)
                {
                    // Encoding pixel data into a single integer. (ARGB)
                    int val = ((0x0 & 0xFF) << 24) + ((ret[i + 2] & 0xFF) << 16) + ((ret[i + 1] & 0xFF) << 8) + (ret[i] & 0xFF);
                    intarr[j++] = val;
                }
                return intarr;
            }
            catch { }
            return new int[1];
        }

        // Dump a bitmap in a VobSub v7 file.
        // The VobSub v7 sub file is really a stripped VOB containing
        // only the subtitle related blocks, so we have to emulate the
        // MPEG2 packet structure and the Subpicture format (yuk!!!).
        long DumpSub(Bitmap bmp, long width, long height, long x1, long y1, long timestart, long timelength, byte col1, byte col2, byte cont1, byte cont2, BinaryWriter bw)
        {
            long i, n, y;
            byte[] spu = new byte[width * height + 50]; // Create the SPU (Sub Picture Unit)
            long field1size = 0;
            long field2size = 0;

            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData data = bmp.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppRgb);
            // Run Length Encode (RLE) the bitmap
            // Lines have to be interlaced and reversed
            for (y = 0; y < bmp.Height; y += 2)
            {
                // Process field1
                fileOffset = 4 + field1size;
                field1size += RLELineEncode(ref spu, ScanLine(data, y), bmp.Width);
            }
            for (y = 1; y < bmp.Height; y += 2)
            {
                // Process field2
                fileOffset = 4 + field1size + field2size;
                field2size += RLELineEncode(ref spu, ScanLine(data, y), bmp.Width);
            }
            bmp.UnlockBits(data);

            // SPU Header
            long offset = 4 + field1size + field2size;
            long spusize = offset + 30;
            spu[0] = (byte)(spusize / 0x100);       // Size of SPU (byte 1)
            spu[1] = (byte)(spusize % 0x100);       // Size of SPU (byte 2)
            n = offset;
            spu[2] = (byte)(n / 0x100);             // Offset to DCSQT (byte 1)
            spu[3] = (byte)(n % 0x100);             // Offset to DCSQT (byte 2)

            // Control Header (DCSQT)
            // 1st Display Control Sequence (DCSQ)
            spu[offset + 0] = (byte)0x00;			// Start Time in (1024/90000)th sec (byte 1)
            spu[offset + 1] = (byte)0x00;			// Start Time in (1024/90000)th sec (byte 2)
            n = offset + 24;
            spu[offset + 2] = (byte)(n / 0x100);	// Offset to next DCSQ (byte 1)
            spu[offset + 3] = (byte)(n % 0x100);	// Offset to next DCSQ (byte 2)
            spu[offset + 4] = (byte)0x03;			// DCC 03 = Set Colors
            spu[offset + 5] = (byte)col1;			// Palette for the 4 colors (byte 1)
            spu[offset + 6] = (byte)col2;			// Palette for the 4 colors (byte 2)
            spu[offset + 7] = (byte)0x04;			// DCC 04 = Set Contrast
            spu[offset + 8] = (byte)cont1;			// Transparency values for the 4 colors (byte 1)
            spu[offset + 9] = (byte)cont2;			// Transparency values for the 4 colors (byte 2)
            spu[offset + 10] = (byte)0x05;			// DCC 05 = Set Position
            spu[offset + 11] = (byte)(x1 / 0x10);									// X1a X1b
            spu[offset + 12] = (byte)((x1 % 0x10) * 0x10 + ((x1 + bmp.Width) / 0x100));	// X1c X2a
            spu[offset + 13] = (byte)((x1 + bmp.Width) % 0x100);					// X2b X2c
            spu[offset + 14] = (byte)(y1 / 0x10);									// Y1a Y1b (reverse the lines)
            spu[offset + 15] = (byte)((y1 % 0x10) * 0x10 + ((y1 + bmp.Height) / 0x100)); // Y1c Y2a (reverse the lines)
            spu[offset + 16] = (byte)((y1 + bmp.Height) % 0x100); // Y2b Y2c (reverse the lines)
            spu[offset + 17] = (byte)0x06;			// DCC 06 = Set PX fields offsets
            spu[offset + 18] = (byte)0x00;			// Offset for first PX field (byte 1)
            spu[offset + 19] = (byte)0x04;			// Offset for first PX field (byte 2)
            n = 4 + field1size;
            spu[offset + 20] = (byte)(n / 0x100);	// Offset for second PX field (byte 1)
            spu[offset + 21] = (byte)(n % 0x100);	// Offset for second PX field (byte 2)
            spu[offset + 22] = (byte)0x01;			// DCC 01 = Start Display
            spu[offset + 23] = (byte)0xFF;			// DCC FF = End of Command

            // 2nd Display Control Sequence (DCSQ)
            n = timelength / 1024;
            spu[offset + 24] = (byte)(n / 0x100);	// Start Time in (1024/90000)th sec (byte 1)
            spu[offset + 25] = (byte)(n % 0x100);	// Start Time in (1024/90000)th sec (byte 2)
            n = offset + 24;
            spu[offset + 26] = (byte)(n / 0x100);	// Offset to next DCSQ (itself) (byte 1)
            spu[offset + 27] = (byte)(n % 0x100);	// Offset to next DCSQ (itself) (byte 2)
            spu[offset + 28] = (byte)0x02;			// DCC 02 = End Display
            spu[offset + 29] = (byte)0xFF;

            // Building & Dumping the Program Stream (PS) packets
            byte[] pspes = new byte[30];

            byte[] spublock;

            long spublocksize;
            long npackets = 0;
            long pos = 0;
            long headersize;
            bool padding;
            long paddingsize = 0;

            // Building PS Header
            pspes[0] = 0x00;
            pspes[1] = (byte)0x00;
            pspes[2] = (byte)0x01;
            pspes[3] = (byte)0xba;
            pspes[4] = (byte)0x44;  // dummy header to fool mkvmerge
            pspes[5] = (byte)0x02;
            pspes[6] = (byte)0xc4;
            pspes[7] = (byte)0x82;
            pspes[8] = (byte)0x04;
            pspes[9] = (byte)0xa9;
            pspes[10] = (byte)0x01;
            pspes[11] = (byte)0x89;
            pspes[12] = (byte)0xc3;
            pspes[13] = (byte)0xf8;
            // Building PES (Packetized Elementary Stream) Header : Private_Stream_1
            pspes[14] = (byte)0x00;
            pspes[15] = (byte)0x00;
            pspes[16] = (byte)0x01;
            pspes[17] = (byte)0xbd;
            pspes[20] = (byte)0x81;

            while (pos < spusize)
            {
                npackets++;
                if (npackets == 1)
                {
                    pspes[21] = (byte)0x80;	// 0x80 for first packet, 0x00 for the others
                    pspes[22] = (byte)0x05;	// 0x05 for first packet, 0x00 for the others
                    pspes[23] = (byte)((timestart >> 29) | 0x21);	// 0x20 for subtitles + TimeStamp (byte 1 - 4 first bits) + Marker(1)
                    pspes[24] = (byte)((timestart >> 22) & 0xFF);	// TimeStamp (byte 2)
                    pspes[25] = (byte)(((timestart >> 14) & 0xFF) | 1);	// TimeStamp (byte 3) + Marker(1)
                    pspes[26] = (byte)((timestart >> 7) & 0xFF);	// TimeStamp (byte 4)
                    pspes[27] = (byte)(((timestart << 1) & 0xFF) | 1);	// TimeStamp (byte 5) + Marker(1)
                    pspes[28] = (byte)0x20;	// Subtitle Id (0x20+id)
                    headersize = 29;
                }
                else
                {
                    pspes[21] = (byte)0x00;
                    pspes[22] = (byte)0x00;
                    pspes[23] = (byte)0x20;	// 0x20 for subtitles
                    headersize = 24;
                }

                spublock = new byte[spu.Length - pos];
                for (int z = (int)pos; z < spu.Length; z++)
                    spublock[z - pos] = (byte)spu[z];

                // Splitting the SPU block
                if ((spusize - pos) > (0x800 - headersize))
                {
                    spublocksize = (0x800 - headersize);
                    pos += (0x800 - headersize);
                    padding = false;
                }
                else
                {
                    if ((spusize - pos) > (0x800 - headersize - 6))
                    {
                        spublocksize = 0x800 - headersize - 6;
                        paddingsize = 0;
                        pos += spublocksize;
                    }
                    else
                    {
                        spublocksize = spusize - pos;
                        paddingsize = 0x800 - headersize - spublocksize - 6;
                        pos = spusize;
                    };
                    padding = true;
                }

                // Dump everything on disk
                n = (headersize - 20) + spublocksize;
                pspes[18] = (byte)(n / 0x100); // Size of the PES (byte 1)
                pspes[19] = (byte)(n % 0x100); // Size of the PES (byte 2)
                bw.Write(pspes, 0, (int)headersize);
                bw.Write(spublock, 0, (int)spublocksize);

                if (padding)
                {
                    // Packetized Elementary Stream (PES) : Padding
                    bw.Write((byte)0x00);
                    bw.Write((byte)0x00);
                    bw.Write((byte)0x01);
                    bw.Write((byte)0xbe);
                    bw.Write((byte)(paddingsize / 0x100)); // Padding Size (byte 1)
                    bw.Write((byte)(paddingsize % 0x100)); // Padding Size (byte 2)
                    for (i = 0; i < paddingsize; i++) 
                        bw.Write((byte)255); // Padding bits
                }
            }
            return npackets * 0x800;
        }

        // Dump a nibble in a buffer (Part of RLE processing)
        void DumpNibble(byte value, ref byte[] rle, ref long size, ref byte pos)
        {
            byte shift = (byte)(6 - (2 * (pos)));
            rle[size + fileOffset] = (byte)((rle[size + fileOffset] & (0xFC << shift)) | (value << shift));
            if ((pos) == 3)
            {
                (size)++;
                (pos) = 0;
            }
            else (pos)++;
        }

        // Run Length Encode (RLE) a (previously analyzed) line
        long RLELineEncode(ref byte[] rleline, int[] srcline, long width)
        {
            byte pos = 0;
            long size = 0;
            long x, i, n;
            byte px = 0;
            byte opx = 0;
            long cpx = 1;

            if (srcline[0] == 0) opx = 0;
            if (srcline[0] == 0xFF0000) opx = 1;
            if (srcline[0] == 0x0000FF) opx = 2;
            if (srcline[0] == 0xFFFFFF) opx = 3;

            for (x = 1; x < width; x++)
            {
                if (srcline[x] == 0) px = 0;
                if (srcline[x] == 0xFF0000) px = 1;
                if (srcline[x] == 0x0000FF) px = 2;
                if (srcline[x] == 0xFFFFFF) px = 3;

                if ((px == opx))
                    cpx++; // pixel is same the previous one, just account it
                else
                {
                    if (cpx > 255)
                    {
                        n = cpx / 255;
                        cpx = cpx % 255;
                        for (i = 0; i < n; i++)
                        {
                            DumpNibble(0, ref rleline, ref size, ref pos);
                            DumpNibble(0, ref rleline, ref size, ref pos);
                            DumpNibble(0, ref rleline, ref size, ref pos);
                            DumpNibble(3, ref rleline, ref size, ref pos);
                            DumpNibble(3, ref rleline, ref size, ref pos);
                            DumpNibble(3, ref rleline, ref size, ref pos);
                            DumpNibble(3, ref rleline, ref size, ref pos);
                            DumpNibble(opx, ref rleline, ref size, ref pos);
                        }
                    }
                    if (cpx > 63) n = 3;
                    else if (cpx > 15) n = 2;
                    else if (cpx > 3) n = 1;
                    else n = 0;
                    for (i = 0; i < n; i++)
                        DumpNibble(0, ref rleline, ref size, ref pos);
                    for (i = n; i >= 0; i--)
                        DumpNibble((byte)((cpx >> (int)(i * 2)) & 0x03), ref rleline, ref size, ref pos);
                    DumpNibble(opx, ref rleline, ref size, ref pos);
                    cpx = 1;
                }
                opx = px;
            }

            for (i = 0; i < 7; i++)
                DumpNibble(0, ref rleline, ref size, ref pos);
            DumpNibble(opx, ref rleline, ref size, ref pos); // dump pixel

            if (pos != 0)
                size++;
            return (size);
        }

        // Insert created subtitle file into the video file.
        // We are using mkvtoolnix to do this. TODO mkvtoolnix link
        void MergeMKV() {
            progressBar.Maximum = 100;
            progressBar.Value = 0;
            lblProgress.Text = "Generating MKV file...";

            mMkvMerge.EnableRaisingEvents = true;
            mMkvMerge.OutputDataReceived += mMkvMerge_OutputDataReceived;
            mMkvMerge.ErrorDataReceived += mMkvMerge_ErrorDataReceived;
            mMkvMerge.Exited += mMkvMerge_Exited;

            mMkvMerge.StartInfo.FileName = Application.StartupPath + "\\mkvmerge.exe";
            mMkvMerge.StartInfo.Arguments = "-o \"" + mSaveDir + mVideoFile.Replace(mVideoFilePath, "") + "\" -S \"" + mVideoFile + "\" \"" + mSaveDir + mSubtitleFile.Replace(mSubtitleFilePath, "").Replace(".srt", "") + ".idx\"";
            mMkvMerge.StartInfo.UseShellExecute = false;
            mMkvMerge.StartInfo.RedirectStandardError = true;
            mMkvMerge.StartInfo.RedirectStandardOutput = true;
            mMkvMerge.StartInfo.CreateNoWindow = true;

            mMkvMerge.Start();
            mMkvMerge.BeginErrorReadLine();
            mMkvMerge.BeginOutputReadLine();
        }

        void mMkvMerge_Exited(object sender, EventArgs e)
        {
            Invoke(new Action(() => { 
                MessageBox.Show("MKV file exported successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(1);
            }));
        }

        void mMkvMerge_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            //TODO
        }

        // Get the current progress from the mkvmerge.
        void mMkvMerge_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (e.Data != null)
                {
                    if (e.Data.ToLower().StartsWith("progress"))
                    {
                        try
                        {
                            int precent = int.Parse(e.Data.ToString().Split(' ')[1].Trim().Replace("%", ""));
                            progressBar.Value = precent;
                        }
                        catch { }
                    }
                }
            }));
            
        }

        // Convert number in to hex string
        string GetHexNumberString(long number, int count)
        {
            string hex = Convert.ToString(number, 16);
            return GetZeros(count - hex.Length) + hex;
        }

        string GetNumberString(long number, int count)
        {
            return GetZeros(count - number.ToString().Length) + number;
        }

        string GetColorString(Color col)
        {
            string str = Convert.ToString(col.ToArgb() & 0x00ffffff, 16);
            str = GetZeros(6 - str.Length) + str;
            return str;
        }

        string GetZeros(int count)
        {
            string str = "";
            for (int i = 0; i < count; i++) str += "0";
            return str;
        }

        private void btnExportSub_Click(object sender, EventArgs e)
        {
            ExportSubOnly();
        }

        void ExportSubOnly() {
            if (mSubtitleFile.Trim() == "" | !File.Exists(mSubtitleFile))
            {
                MessageBox.Show("Please select a source subtitle file first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (mWorkingDir.Trim() == "")
            {
                MessageBox.Show("Please select a location to save the file(s)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            grpInputFiles.Enabled = false;
            grpOutput.Enabled = false;
            grpMain.Enabled = false;
            GenerateBitmaps();
            GenerateSubFile();
            MessageBox.Show("Subtitle generated successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Environment.Exit(1);
        }

        private void mnuRender_Click(object sender, EventArgs e)
        {
            Render();
        }

        private void mnuExportSub_Click(object sender, EventArgs e)
        {
            ExportSubOnly();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void mnuSubFile_Click(object sender, EventArgs e)
        {
            BrowseSubtitle();
        }

        private void mnuVideoFile_Click(object sender, EventArgs e)
        {
            BrowseVideo();
        }

        private void mnuSaveLoc_Click(object sender, EventArgs e)
        {
            BrowseDestination();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

    }
}
//---------------------------------------------------------------------------
