using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;

namespace HashgeonCrawler
{
    public class NPC : Object
    {
        public static List<NPC> list = new List<NPC>();
        public NPC(int X, int Y)
        {
            list.Add(this);
            this.xPos = X;
            this.yPos = Y;
        }
        public NPC()
        {
            list.Add(this);
        }

        public int health, damage, vision;
       
      
        public static void PlaceUnits()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Game.World.Plane.SetPlanePoint(new Point(NPC.list[i].xPos, NPC.list[i].yPos), NPC.list[i].id);

            }
        }
        public static void NpcActions()
        {
            for (int i = 0; i < list.Count; i++)
            {
                NPC.list[i].Action();
            }
        }

        public class Enemy : NPC
        {
            int moveX = 0, moveY = 0;
            bool sawPlayer = false;

            public class Soldier : Enemy
            {
                public Soldier()
                {
                    this.id = 3;
                    
                }

                    
                
                public override void Action()
                {
                    if (sawPlayer)
                    {
                        this.id = 3;
                    }
                    else
                    {
                        moveX = Technical.RandomNumber(-1, 1);
                        moveY = Technical.RandomNumber(-1, 1);
                    }
                    this.Move(moveX, moveY);
                }
            }
        }


    }
}
