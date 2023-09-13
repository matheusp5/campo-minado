using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampoMinado.Helpers
{
    public class Screen
    {
        public static void Home()
        {
            Console.WriteLine();
            Console.WriteLine("  Seja bem-vindo ao campo minado!");
            Console.WriteLine();
        }
        
        public static void Finish(DateTime startedTime)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("  Explosão! Você perdeu.");
            Console.WriteLine($"  Você durou {(DateTime.Now - startedTime).Seconds} segundos.");
            Console.WriteLine();
        }
        public static void Win(DateTime startedTime)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("  Vitória!");
            Console.WriteLine($"  Você completou em {(DateTime.Now - startedTime).Seconds} segundos.");
            Console.WriteLine();
        }


    }
}
