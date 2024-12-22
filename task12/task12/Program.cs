using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк массива от 5 до 20");
            int m;

            if (!TryInputNumber(out m))
            {
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите количество столбцов массива от 5 до 20");
            int n;

            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }

            if (m < 5 || m > 20 || n < 5 || n > 20)
            {
                Console.WriteLine("Числа не удовлетворяют неравенству 5 <= m,n <= 20");
                Console.ReadKey();
                return;
            }
            var matrix = new int[m, n];
            var rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(100);

            Console.WriteLine();
            PrintMatrix(matrix);
            Console.WriteLine();

            var (rowNumber,colNumber)= AreNumbersLoweringInCols(matrix);
            if (rowNumber != -1 && colNumber != -1)

                Console.WriteLine($"Нарушение на строке {rowNumber + 1} и столбце {colNumber + 1}");
            else Console.WriteLine("Все элементы столбцов идут в порядке убывания");
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                double average = CalculateRowAverage(matrix, i);
                Console.WriteLine($"Среднее арифметическое строки {i + 1}: {average}");
            }
            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            number = n;
            return true;
        }


        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],2} ");

                Console.WriteLine();
            }
        }

        static (int, int) AreNumbersLoweringInCols(int[,] matrix)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
               
                for (var i = 1; i < matrix.GetLength(0); i++)
                    if (matrix[i, j] > matrix[i - 1, j])
                    {
                        return (i, j);
                    }
            }
            return (-1, -1);
        }
        static double CalculateRowAverage(int[,] matrix, int rowIndex)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[rowIndex, j];
            }
            return (double)sum / matrix.GetLength(1);
        }
    }
}
