using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение координат (x, y) через пробел");
            
            var input = Console.ReadLine();
            var k = input.IndexOf(' ');
            var x = double.Parse(input.Substring(0, k));
            var y = double.Parse(input.Substring(k+1));

            if (IsInArea(x, y))
                Console.WriteLine("Точка принадлежит данной области");
            else Console.WriteLine("Точка не принадлежит данной области");
            Console.ReadKey();
        }

        static bool IsInArea(double x, double y)
        {
            return (x <= -3 || x >= -1) && y >= -2;
        }
    }
}
