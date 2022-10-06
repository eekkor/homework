using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Цветаева М. И.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Луч серебристый");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Эхо стонало, шумела река,");
            Console.WriteLine("Ливень стучал тяжело,");
            Console.WriteLine("Луч серебристый пронзил облака.");
            Console.WriteLine("Им любовались мы долго, пока");
            Console.WriteLine("Солнышко, солнце взошло!");
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
