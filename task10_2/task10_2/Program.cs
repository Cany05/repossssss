using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            int k;
            if (!TryInputNumber("Введите количество студентов", out m))
            {
                Console.ReadKey();
                return;
            }
            if (!TryInputNumber("Введите количество экзаменов", out k))
            {
                Console.ReadKey();
                return;
            }

            int examGrade;
            int baseGrade = 0;

            for (int i = 1; i <= m; i++)
            {
                baseGrade = 0;
                Console.WriteLine("Оценки студента номер "+i);
                for (int j = 1; j <= k; j++)
                {
                    Console.WriteLine();
                     if (!TryInputNumber("Введите оценку по экзамену номер "+j, out examGrade))
                    {
                        Console.ReadKey();
                        return;
                    }
                     baseGrade= baseGrade+examGrade;
                }
                Console.WriteLine("Сумма баллов студента номер "+i+" = "+baseGrade);
                Console.WriteLine();
            }
           
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

        static bool TryInputNumberHundered(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if ((!int.TryParse(input, out number)) | (number <= 0) | (number<=100))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            return true;
        }
    }
}