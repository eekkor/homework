using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            double y;
            y = (double)Math.Abs((1 + Math.Sqrt(x + 1)) / (1 - Math.Sqrt(x - 1)));

            Console.WriteLine("y = " + y);

            Console.ReadKey();

        }
    }
}
