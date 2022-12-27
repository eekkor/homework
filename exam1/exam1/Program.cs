using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum;
            string str;
            while (true)
            {
                Console.WriteLine("Введите сумму: ");
                str = Console.ReadLine();
                if (!int.TryParse(str, out sum))
                {
                    Console.WriteLine("Ошибка ввода, вы ввели не число, повторите поыптку!");
                }
                else
                {
                    if (int.Parse(str) <= 0 || int.Parse(str) >= 50000 || int.Parse(str) % 100 != 0)
                    {
                        Console.WriteLine("Ошибка ввода, введите сумму от 0 до 50 000, кратную 100");
                    }
                    else
                    {
                        sum = int.Parse(str);
                        Console.WriteLine("Успешный ввод!");
                        break;
                    }
                }
            }

            while (sum % 100 != 0 && sum > 50000);
            sum = sum / 100;
            int answer = 0;

            for ( int number100 = 0; number100 <= sum; number100++ )
                for (int number200 = 0; number200 <= sum; number200++ )
                    for (int number500 = 0; number500 <= sum; number500++)
                        for (int number1000 = 0; number1000 <= sum; number1000++)
                            for (int number2000 = 0; number2000 <= sum; number2000++)
                                for (int number5000 = 0; number5000 <= sum; number5000++)
                                    if ((number100 + 2 * number200 + 5 * number500 + 10 * number1000 + 20 * number2000 + 50 * number5000) == sum)
                                        answer++;
            Console.WriteLine("Способы набора суммы: " + answer);
            Console.ReadKey();
        }
    }
}
