using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  n, numberRemainder, numberDivisor;
          
            if (!TryInputNumber("Введите натуральное число", out n))
            {
                Console.ReadKey();
                return;
            }
            numberDivisor = n;

            for (int i = 1; i<=n; i++)
            {
                numberRemainder = n % i;
                if ((numberRemainder == 0) && (i != 1) && (i <= numberDivisor))
                    numberDivisor = i;
            }
            Console.WriteLine();
            Console.WriteLine("Наименьший делитель числа "+n+" = "+numberDivisor);
            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            return true;
        }


    }
}