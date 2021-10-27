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
using System.Collections.Generic;
using System.Text;
//---------------------------------------------------------------------------
namespace SubRenderer
{
    class Timestamp
    {
        public List<string> Lines { get; set; } = new List<string>();
        public List<long> Offsets { get; set; } = new List<long>();

        public long LastOffset { get; set; }

        public void WriteLine(string str, long offset)
        {
            Lines.Add(str);
            Offsets.Add(offset);
        }

        public string ToString(long offset)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Lines.Count; i++)
            {
                sb.Append(Lines[i]);
                sb.AppendLine(frmMain.GetHexNumberString(offset + Offsets[i], 9));
            }
            return sb.ToString();
        }
    }
}
//---------------------------------------------------------------------------