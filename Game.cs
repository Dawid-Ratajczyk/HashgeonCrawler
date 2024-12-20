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
           
        }
        public void Menu()
        {
           
        }
        public void PlayLoop()
        {
            while (gameRunning)
            {
                //render
                Grid gameImage = World.Plane.GetSection(new Point(Player.xPos, Player.yPos), Player.vision);
                Program.renderEngine.ImprintGrid(gameImage, new Point(1,1));
                Program.renderEngine.RenderFrame();
                Console.WriteLine(Player.xPos + " " + Player.yPos);
                Player.Action();
      
                //refresh
                Technical.CleanBuffer();
                Thread.Sleep(100);
                Console.Clear();
            }
        }
    }
}
