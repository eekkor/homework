using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "кратер";
            Console.WriteLine(s.Substring(0, 1) + s.Substring(2, 4));
            Console.WriteLine(s.Substring(5, 1) + s.Substring(4, 1) + s.Substring(0, 1) + s.Substring(2, 1));

            Console.ReadKey();
        }
    }
}
