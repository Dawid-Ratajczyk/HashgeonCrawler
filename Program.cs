using System;

namespace HashgeonCrawler
{
    internal class Program
    {
        public static Game game= new Game();
        public static RenderEngine renderEngine=new RenderEngine();
        static void Main(string[] args)
        {
            game.Start();
        }
    }
}
