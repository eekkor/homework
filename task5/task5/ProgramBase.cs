using System;

namespace task5
{
    internal class ProgramBase
    {
        static void PrintSinnusCosinus(double z)
        {
            var y = Math.Log10(z);
            Console.WriteLine("x = " + (y + y) / (y + y) + (y + y) / (y + y) + (y + y) / (y + y));

        }
    }
}