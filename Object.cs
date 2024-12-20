using System;
using System.Collections.Generic;
using System.Text;

namespace HashgeonCrawler
{
    internal class Object
    {
        public Object() { }
        public int xPos, yPos;
        public string name,symbol;
        public void SetPosition(int X, int Y){  this.xPos = X; this.yPos = Y; }
        public void Move(int moveX, int moveY)
        {
            int nextSpotX = moveX + this.xPos, nextSpotY = this.yPos + moveY;
            if (Game.World.Plane.IsInside(nextSpotX, nextSpotY))
            {
                Game.World.Plane.ChangePosition(nextSpotX, nextSpotY, this);
            }
        }
    }
}
