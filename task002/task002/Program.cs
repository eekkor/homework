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
            Console.WriteLine("Введите внешний диаметр кольца");
            double d1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите внутренний диаметр кольца");
            double d2 = double.Parse(Console.ReadLine());
            double s = Math.PI / 4 * (d1 * d1 - d2 * d2);

            Console.WriteLine("Площадь кольца: " + s);

            Console.ReadKey();

        }
    }
}
