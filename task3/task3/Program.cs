using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону прямоугольника m");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону прямоугольника n");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата k");
            double k = double.Parse(Console.ReadLine());
            double s1 = m * n;
            double s2 = k * k;
            int x = 0;
            while (s1 - s2 >= 0)
            {
                int y = (int)(s1 - s2);
                x++;
            }


            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
