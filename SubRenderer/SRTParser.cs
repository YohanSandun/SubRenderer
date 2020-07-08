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
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
//---------------------------------------------------------------------------
namespace SubRenderer
{
    class SRTParser
    {
        // Parse srt file using regex.
        public static SRTSegment[] Parse(string file) {
            List<SRTSegment> segments = new List<SRTSegment>();
            Regex regex = new Regex(@"(?<number>\d+)\r\n(?<start>\S+)\s-->\s(?<end>\S+)\r\n(?<text>(.|[\r\n])+?)\r\n\r\n");
            MatchCollection match = regex.Matches(File.ReadAllText(file));
            foreach (Match m in match)
            {
                segments.Add(new SRTSegment()
                {
                    Number = m.Groups["number"].Value,
                    StartTime = m.Groups["start"].Value,
                    EndTime = m.Groups["end"].Value,
                    TextLines = Regex.Split(Regex.Replace(Regex.Replace(m.Groups["text"].Value, "{.*?}", String.Empty), "<.*?>", String.Empty), "\r\n"),
                    IsItalic = m.Groups["text"].Value.ToString().ToLower().StartsWith("<i>"),
                    IsUnderline = m.Groups["text"].Value.ToString().ToLower().StartsWith("<u>")
                });
            }
            return segments.ToArray();
        }
    }

    public class SRTSegment {
        string mNumber;
        string mStart;
        string mEnd;
        string[] mTextLines;
        bool mItalic, mUnderline;

        public bool IsItalic {
            get { return mItalic; }
            set { mItalic = value; }
        }

        public bool IsUnderline {
            get { return mUnderline; }
            set { mUnderline = value; }
        }

        public string Number {
            get { return mNumber; }
            set { mNumber = value; }
        }

        public string StartTime
        {
            get { return mStart; }
            set { mStart = value; }
        }

        public string EndTime
        {
            get { return mEnd; }
            set { mEnd = value; }
        }

        public string[] TextLines
        {
            get { return mTextLines; }
            set { mTextLines = value; }
        }

        public string GetStartTime()
        {
            string[] nums = mStart.Trim().Split(',');
            int i = (int.Parse(nums[1]) * 24) / 1000;
            return nums[0] + ":" + (i < 10 ? "0" + i : i + "");
        }

        public string GetEndTime()
        {
            string[] nums = mEnd.Trim().Split(',');
            int i = (int.Parse(nums[1]) * 24) / 1000;
            return nums[0] + ":" + (i < 10 ? "0" + i : i + "");
        }
    }
}
//---------------------------------------------------------------------------