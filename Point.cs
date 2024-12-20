using System;
using System.Collections.Generic;
using System.Text;

namespace HashgeonCrawler
{
    internal class Point
    {
        public int x,y,lSpacer=0,uSpacer=0;
        public int color;
        public Point(int x,int y)
        {
            if (x < 0) { this.x = 0; }
            else this.x = x;
            if (y < 0) this.y = 0;
            else this.y = y;
        }
    }
}
