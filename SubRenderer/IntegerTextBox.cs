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
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
//---------------------------------------------------------------------------
namespace SubRenderer
{
    public partial class IntegerTextBox : TextBox
    {
        int oldValue = 0;

        public IntegerTextBox()
        {
            InitializeComponent();
            LostFocus += IntegerTextBox_LostFocus;
            GotFocus += IntegerTextBox_GotFocus;
        }

        void IntegerTextBox_GotFocus(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(Text.Trim());
                oldValue = i;
            }
            catch
            {

            }
            SelectAll();
        }

        void IntegerTextBox_LostFocus(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(Text.Trim());
            }
            catch
            {
                Text = oldValue.ToString();
            }
        }

        public int Value
        {
            get
            {
                try
                {
                    return int.Parse(Text.Trim());
                }
                catch
                {
                    oldValue = 0;
                    return 0;
                }
            }
            set
            {
                Text = value.ToString();
            }
        }
    }
}
//---------------------------------------------------------------------------