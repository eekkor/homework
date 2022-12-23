using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            double b = double.Parse(Console.ReadLine());
            double m = 0;
            double k = 0;
            while (a < b - 1)
            {
                m = (b - 1) * (b - 1);
                k = k + m;
                b--;
            }

            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
