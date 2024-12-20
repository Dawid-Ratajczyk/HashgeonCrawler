using System;
using System.Collections.Generic;
using System.Text;

namespace HashgeonCrawler
{
    internal class Map
    {
       public Grid Plane=new Grid(20,20);
        public int sizeX,sizeY;
        
        public bool IsInside(int X, int Y)
        {
            if (X < 0 || X >= this.sizeX || Y < 0 || Y >= this.sizeY) return false;
            else return true;
        }
    }
}
