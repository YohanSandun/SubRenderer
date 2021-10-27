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
        public bool IsItalic { get; set; }

        public bool IsUnderline { get; set; }

        public string Number { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string[] TextLines { get; set; }

        public string GetStartTime()
        {
            string[] nums = StartTime.Trim().Split(',');
            int i = (int.Parse(nums[1]) * 24) / 1000;
            return nums[0] + ":" + (i < 10 ? "0" + i : i + "");
        }

        public int[] GetStartTimeArray()
        {
            int[] array = new int[4];
            string[] nums = StartTime.Trim().Split(',');
            array[3] = (int.Parse(nums[1]) * 24) / 1000;
            string[] nums1 = nums[0].Split(':');
            array[0] = int.Parse(nums1[0]);
            array[1] = int.Parse(nums1[1]);
            array[2] = int.Parse(nums1[2]);
            return array;
        }

        public int[] GetEndTimeArray()
        {
            int[] array = new int[4];
            string[] nums = EndTime.Trim().Split(',');
            array[3] = (int.Parse(nums[1]) * 24) / 1000;
            string[] nums1 = nums[0].Split(':');
            array[0] = int.Parse(nums1[0]);
            array[1] = int.Parse(nums1[1]);
            array[2] = int.Parse(nums1[2]);
            return array;
        }

        public string GetEndTime()
        {
            string[] nums = EndTime.Trim().Split(',');
            int i = (int.Parse(nums[1]) * 24) / 1000;
            return nums[0] + ":" + (i < 10 ? "0" + i : i + "");
        }
    }
}
//---------------------------------------------------------------------------