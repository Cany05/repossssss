using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum, minNum, n, digit, x;

            if (!TryInputNumber("Введите число n", out n))
            {
                Console.ReadKey();
                return;
            }
            int digitCount = (int)Math.Log10(n) + 1;
            minNum = 9;
            maxNum = 0;
            x = 1;
            for (int i = 1; i <= digitCount; i++)
            {
                x = x * 10;
            }
           
            for (int i = digitCount; i >=1 ; i--)
            {  
                x = x / 10;
                if (x == 0)
                    x = 1;
                digit = n / x;
                n = n - n/x * x;
                if (digit < minNum)
                    minNum = digit;
                if (digit > maxNum)
                    maxNum = digit;
             
            }
           
            Console.WriteLine();
            Console.WriteLine("Минимальная цифра в числе = "+minNum + ", максимальная = " + maxNum);
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