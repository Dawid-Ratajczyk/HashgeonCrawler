using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace HashgeonCrawler
{
    internal class Player
    {

        public int xPos, yPos, vision, moves;

        public Player()
        {

        }
        public void Action()
        {
            int moveX = 0, moveY = 0;
            string key = Technical.KeyPress();

            switch (key)
            {
                //movement
                case "W": moveY = -1; break;
                case "D": moveX = 1; break;
                case "S": moveY = 1; break;
                case "A": moveX = -1; break;
            }
            if(moveX != 0 || moveY != 0)
            {
                Move(moveX, moveY);
            }
            
        }
        public void Move(int moveX,int moveY)
        {
            int nextSpotX = moveX + Game.Player.xPos, nextSpotY = Game.Player.yPos + moveY;

            //move to empty spot
            if (Game.World.Plane.IsInside(nextSpotX, nextSpotY) )
            {

                Game.Player.xPos += moveX;
                Game.Player.yPos += moveY;
            }
        }
    }
}
