using System;
using System.Collections.Generic;
using System.Text;

namespace HashgeonCrawler
{
    internal class Grid
    {
        public List<List<int>> things = new List<List<int>>(), colors = new List<List<int>>(), background = new List<List<int>>();
        public int sizeX, sizeY;
        public Grid(int sizeX,int sizeY)
        {
            this.sizeX = sizeX;this.sizeY = sizeY; 
        }
        
        public void ChangePosition(int toX,int toY, Object obj)
        {
            this.things[toX][toY] = this.things[obj.xPos][obj.yPos];
            this.things[obj.xPos][obj.yPos] = 0;
            obj.SetPosition(toX,toY);
        }
        public void ChangePosition(int toX, int toY, int fromX, int fromY)
        {
            this.things[toX][toY] = this.things[fromX][fromY];
            this.things[fromX][fromY] = 0;
        }
       
        public void SetPlanePoint(Point set,int value)
        { 
            if(IsInside(set.x,set.y)){ this.things[set.x][set.y] = value; }
        }
        public void SetColorPoint(Point set, int value)
        {
            if (IsInside(set.x, set.y)) { this.color[set.x][set.y] = value; }
        }
        public void SetBackPoint(Point set, int value)
        {
            if (IsInside(set.x, set.y)) { this.background[set.x][set.y] = value; }
        }
        public void SetSize(int sizeX,int sizeY)
        { this.sizeX = sizeX; this.sizeY = sizeY; }
        public void ResetGrid()
        {
            things.Clear(); colors.Clear();background.Clear();
            for(int i = 0; i < sizeX; i++)
            {
                things.Add(new List<int>(0));
                colors.Add(new List<int>(0));
                background.Add(new List<int>(0));

                for (int j = 0; j < sizeY; j++)
                {
                    things[i].Add(0);
                    colors[i].Add(1);
                    background[i].Add(2);
                }
            }
        }
        
        public bool IsInside(int X,int Y)
        {
            if (X < 0 || X >= this.sizeX || Y < 0 || Y >= this.sizeY) return false;
            else return true;
        }
        public Grid GetSection(Point center,int radius)
        {
            Grid toReturn= new Grid((radius*2)+1, (radius * 2) + 1);
            int list = 0;
            for (int j = center.x - radius; j < center.x + radius+1; j++)
            {
                toReturn.things.Add(new List<int>(0));
                toReturn.colors.Add(new List<int>(0));
                toReturn.background.Add(new List<int>(0));
                for (int i = center.y - radius; i < center.y +radius+1; i++)
                 {

                    if (IsInside(i, j))
                    {
                        toReturn.things[list].Add(this.things[j][i]);
                        toReturn.colors[list].Add(this.colors[j][i]);
                        toReturn.background[list].Add(this.background[j][i]);
                    }
                    else
                    {
                        toReturn.background[list].Add(11);
                        toReturn.things[list].Add(1);
                        toReturn.colors[list].Add(11);
                    }
                }
                list++;
            }
            return toReturn;

        }
        
    }
}
