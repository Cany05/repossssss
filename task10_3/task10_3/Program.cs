using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberTwoAgo,numberOneAgo,n, EndResult;
           
            if (!TryInputNumber("Введите число n", out n))
            {
                Console.ReadKey();
                return;
            }
            numberTwoAgo = 1;
            numberOneAgo = 1;
          
            for (int i = 1; i <= n;)
            {
                numberTwoAgo = numberOneAgo;
                numberOneAgo = i;
                i = numberTwoAgo + numberOneAgo;
                Console.Write(i+" ");
                
            }
             EndResult = numberTwoAgo + numberOneAgo;
            Console.WriteLine();
            Console.WriteLine("Первое число последовательности, большее "+n+" это "+EndResult);
            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if ((!int.TryParse(input, out number)) | (number <= 0))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            return true;
        }

        
    }
}
