using CampoMinado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampoMinado.Helper
{
    public class Renderer 
    {
        public static void ShowGame(Game game)
        {
            string x = " x  ";
            string y = "";
            Console.WriteLine("  y");
            for (int j = 1; j <= game.Width; j++)
            {
                x += $"{j} ";
            }
            Console.WriteLine(x);
            for (int j = 1; j <= game.Height; j++)
            {
                Console.Write("  " + j + " ");

                for(int k = 1; k <= game.Width; k++)
                {
                    bool flag = game.Flags.Any(f => f.x == k && f.y == j);
                    bool point = game.Points.Any(p => p.x == k && p.y == j);

                    if (!flag && !point)
                    {
                        Console.Write("* ");
                    } else if(!flag && point)
                        {
                        Console.Write($"p{game.GetBombsAround(k, j)} ");
                    } else if (flag && !point)
                    {
                        Console.Write("f ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
