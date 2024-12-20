using System;
using System.Net;

namespace HashgeonCrawler
{
    internal class Program
    {
        public static Game game= new Game();
        public static RenderEngine renderEngine=new RenderEngine();
        static void Main(string[] args)
        {
            Setup();
            game.Start();
        }
        static void Setup()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
        }
    }
}
