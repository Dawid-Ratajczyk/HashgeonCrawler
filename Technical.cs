using System;
using System.Collections.Generic;
using System.Text;

namespace HashgeonCrawler
{
    internal class Technical
    {
        static public void CleanBuffer() { while (Console.KeyAvailable) { Console.ReadKey(true); } }
        static public string KeyPress()
        {
            ConsoleKeyInfo press;
            press = Console.ReadKey();
            string key = press.Key.ToString();
            return key;

        }
    }
}
