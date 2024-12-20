using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace HashgeonCrawler
{
    internal class RenderEngine
    {
        int renderX = 60, renderY = 29;
        List<List<string>> symbols = new List<List<string>>();
        List<List<int>> symbolColors = new List<List<int>>();
        List<List<int>> backColors = new List<List<int>>();
        public void SetBlankFrame(bool edges = false)
        {
            symbols.Clear(); symbolColors.Clear(); backColors.Clear();
            for (int i = 0; i < renderX; i++)
            {
                symbols.Add(new List<string>(0));
                symbolColors.Add(new List<int>(0));
                backColors.Add(new List<int>(0));
                for (int j = 0; j < renderY; j++)
                {
                    if (IsEdge(new Point(i,j)))
                    {
                        symbols[i].Add(Visual.symbols[1]);
                    }
                    else symbols[i].Add(" ");
                    
                    symbolColors[i].Add(1);
                    backColors[i].Add(0);
                }
            }
        }
        
        public void RenderFrame()
        {
           
            for (int Y = 0; Y < renderY; Y++)
            {
                for (int X = 0; X < renderX; X++)
                {
                    Visual.SetSymbolColour(symbolColors[X][Y]);
                    Visual.SetBackgroundColour(backColors[X][Y]);
                    Console.Write(symbols[X][Y]);
                }
                Visual.NewLine();
            }
        }
        public void ImprintGrid(Grid grid,Point corner)
        {
             for (int y = 0; y < grid.sizeY; y++)
            {
                for (int x = 0; x < grid.sizeX; x++)
                {
                    if(IsInside(new Point(x + corner.x,y + corner.y)))
                    {
                        this.symbols[x + corner.x][y + corner.y] = Visual.FromIntToStringTranslation(grid.things[x][y]);
                        this.symbolColors[x + corner.x][y + corner.y] = grid.colors[x][y];
                        this.backColors[x + corner.x][y + corner.y] = grid.background[x][y];    
                    }  
                }
            }
        }
        //check
        public bool IsInside(Point check)
        {
            if (check.x < 0 || check.x >= this.renderX || check.y < 0 || check.y >= this.renderY) return false;
            else return true;
        }
        public bool IsEdge(Point check)
        {
            if (check.x == 0 || check.y == 0 || check.y == this.renderY - 1 || check.x == this.renderX - 1) return true;
            else return false;
        }

    }
}
