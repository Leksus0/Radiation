﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiation
{
    public class MyColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(50, 50, 50); }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(50, 50, 50); }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.FromArgb(50, 50, 50); }
        }

        public override Color MenuItemBorder
        {
            get { return Color.Black; }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.Black; }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.Black; }
        }

        public override Color MenuBorder
        {
            get { return Color.Black; }
        }

    }
}
