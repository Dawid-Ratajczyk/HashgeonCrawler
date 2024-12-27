using System;
using System.Collections.Generic;
using System.Text;

namespace HashgeonCrawler
{
    static class Technical
    {
        static Random randomizer = new Random();
        static public void CleanBuffer() { while (Console.KeyAvailable) { Console.ReadKey(true); } }
        static public string KeyPress()
        {
            ConsoleKeyInfo press;
            press = Console.ReadKey();
            string key = press.Key.ToString();
            return key;

        }
        static public int RandomNumber(int min, int max){ return randomizer.Next(min, max+1);}

    }
}
