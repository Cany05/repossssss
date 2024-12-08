using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n;
            if (!TryInputNumber("Введите положительное число n", out n))
            {
             Console.ReadKey();
            return;
            }
           
            double result = 0;
           
            for (int i = 1; i <= n; i++)
            {
                double a = 1;
                result += a/i;
               
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if ((!int.TryParse(input, out number))|(number <=0))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            return true;
        }
    }
}
