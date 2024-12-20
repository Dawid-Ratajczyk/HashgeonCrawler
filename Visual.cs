using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Xml;

namespace HashgeonCrawler
{
    internal class Visual
    {
        public static List<string> symbols = new List<string>() { " ", "█" };
        public static void SetBackgroundColour(int id)
        {
            switch (id)
            {
                case 0: Console.BackgroundColor = ConsoleColor.Black; break;
                case 1: Console.BackgroundColor = ConsoleColor.White; break;
                case 2: Console.BackgroundColor = ConsoleColor.Green; break;
                case 3: Console.BackgroundColor = ConsoleColor.Blue; break;
                case 4: Console.BackgroundColor = ConsoleColor.Red; break;
                case 5: Console.BackgroundColor = ConsoleColor.Yellow; break;
                case 6: Console.BackgroundColor = ConsoleColor.DarkRed; break;
                case 7: Console.BackgroundColor = ConsoleColor.DarkGray; break;
                case 8: Console.BackgroundColor = ConsoleColor.Magenta; break;
                case 9: Console.BackgroundColor = ConsoleColor.DarkYellow; break;
                case 10: Console.BackgroundColor = ConsoleColor.Yellow; break;
                case 11: Console.BackgroundColor = ConsoleColor.Gray; break;
            }
        }
        public static void SetSymbolColour(int id)
        {
            switch (id)
            {
                case 0: Console.ForegroundColor = ConsoleColor.Black; break;
                case 1: Console.ForegroundColor = ConsoleColor.White; break;
                case 2: Console.ForegroundColor = ConsoleColor.Green; break;
                case 3: Console.ForegroundColor = ConsoleColor.Blue; break;
                case 4: Console.ForegroundColor = ConsoleColor.Red; break;
                case 5: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case 6: Console.ForegroundColor = ConsoleColor.DarkRed; break;
                case 7: Console.ForegroundColor = ConsoleColor.DarkGray; break;
                case 8: Console.ForegroundColor = ConsoleColor.Magenta; break;
                case 9: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                case 10: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case 11: Console.ForegroundColor = ConsoleColor.Gray; break;
            }
        }
        public static void NewLine() { Console.WriteLine(); }
        public static string FromIntToStringTranslation(int id)
        {
            if (id >= 0 && id < symbols.Count)
            {
                return symbols[id];
            }
            else return "X";
        }
    }
}
