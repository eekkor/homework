using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main()
        { 
            PrintSinnusCosinus(3 + (2 * 2 * 2));
            PrintSinnusCosinus(2 + (3 * 3));
            PrintSinnusCosinus(5 + (3 * 3 * 3 * 3 * 3));
            PrintSinnusCosinus(3 + (5 * 5 * 5));
            PrintSinnusCosinus(7 + (4 * 4 * 4 * 4 * 4 * 4 * 4));
            PrintSinnusCosinus(4 + (7 * 7 * 7 * 7));

            Console.ReadKey();
        }
        static void PrintSinnusCosinus(double z)
        {
            var y = Math.Log10(z);
            Console.WriteLine("x = " + (y + y) / (y + y) + (y + y) / (y + y) + (y + y) / (y + y));

        }
    }
}
