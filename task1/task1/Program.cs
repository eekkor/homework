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
            Console.WriteLine("А. С. Пушкин");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Евгений Онегин (отрывок)");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Мой дядя самых честных правил");
            Console.WriteLine("Когда не в шутку занемог");
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
