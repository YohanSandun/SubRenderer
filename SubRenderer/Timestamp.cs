using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
