﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIProject
{
    public class DrawingBoard : Panel
    {
        public DrawingBoard()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }
    }
}
