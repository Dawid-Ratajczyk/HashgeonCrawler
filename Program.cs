using System;
using System.Net;
using System.Runtime.InteropServices;

namespace HashgeonCrawler
{
    internal class Program
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct ConsoleFont
        {
            public uint Index;
            public short SizeX, SizeY;
        }
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
            ConsoleHelper.SetCurrentFont("Consolas", 29);
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
        }
    }
}
