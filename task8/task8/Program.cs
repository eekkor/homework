using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            
            if (Math.Sin(x) > 0)
            {
                Console.WriteLine(Math.Cos(x));
            }
            else if (Math.Sin(x) < 0)
            {
                Console.WriteLine(-Math.Cos(x));
            }
            else 
            {
                Console.WriteLine(x / Math.PI);
            }
            
            Console.ReadKey();
        }
    }
}
