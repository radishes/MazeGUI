using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MazeTools
{
    public struct Rect
    {
        public Point p;
        public Point offset;

        public Rect(Point p, Point offset)
        {
            this.p = p;
            this.offset = offset;
        }
    }




}
