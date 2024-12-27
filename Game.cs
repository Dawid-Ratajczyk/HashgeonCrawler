using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HashgeonCrawler
{
    class Game
    {
        public static Player Player = new Player();
        public static Map World =new Map();
        public static int tick = 0;
        public static Point RenderPoint = new Point(0, 0);
        bool gameRunning = true;
        int refreshRate = 500;

        public void Start()
        {
            Setup();
            Menu();
            PlayLoop();
        }
        public void Setup()
        {
            World.Plane.SetSize(100,100);
            World.Plane.ResetGrid();
          
            Player.xPos = 0; Player.yPos = 0; Player.vision=13;
            
            World.Plane.SetPlanePoint(new Point(Player.xPos, Player.yPos), 2);
            Program.renderEngine.SetBlankFrame(true);

            NPC.list.Add(new NPC.Enemy.Soldier());
            NPC.list[0].SetPosition(4, 4);
            NPC.PlaceUnits();


        }
        public void Menu()
        {
           
        }
        public void PlayLoop()
        {
            while (gameRunning)
            {
                //render
                Render();
                NPC.NpcActions();
                Player.Action();
                AfterRender();
            }
        }
        public void AfterRender()
        { 
            Technical.CleanBuffer();
            Thread.Sleep(100);
            Console.Clear();
            tick++;
        }
        public void Render()
        {
            RenderPoint.Set(Player.xPos, Player.yPos);
            Grid gameImage = World.Plane.GetSection(RenderPoint, Player.vision);
            Program.renderEngine.ImprintGrid(gameImage, new Point(1, 1));
            Program.renderEngine.RenderFrame();
        }
    }
}
