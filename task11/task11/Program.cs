using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,intPi;
            string subPi;


            Console.WriteLine("Введите количество элементов массива");
            if (!int.TryParse(Console.ReadLine(), out n)||(n < 0))
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }
            var numbers = new int[n];
            string piInString = Math.PI.ToString("F"+n);
           
            piInString = piInString.Substring(0, (n + 1));
             piInString = piInString.Remove(1, 1);
            
            for (int i = 1; i <= n; i++)
            {
                subPi = piInString.Substring((i - 1), 1);
                intPi = Convert.ToInt32(subPi);
                numbers[i-1]=intPi;
            }
            PrintArray(numbers);
            Console.WriteLine();
            PrintArray(SubtractFromNine(numbers));
            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine();
            int count = 0;
            foreach (var element in array)
            {
                Console.Write(element + " ");
                count++;

                if (count%10==0)
                Console.WriteLine();
            }
        }

        static int[] SubtractFromNine(int[] array)
        {
            int[] result = new int[array.Length];
            for (int i=0; i<array.Length;i++)
            {
                result[i] = 9-array[i];
            }
            return result;
        }
    }
}
