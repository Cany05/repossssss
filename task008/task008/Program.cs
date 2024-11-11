using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x");
            var x = Double.Parse(Console.ReadLine());
            Console.WriteLine($"f({x}) = {FunctionCount(x)}");

            Console.ReadLine();
        }

        static double FunctionCount(double x)
        {
            if (Math.Cos(x) != 0)
                return Math.Tan(x);
            else if (Math.Sin(x) > 0)
                return (x / Math.PI) - 0.5;
            else if (Math.Sin(x) < 0)
                return (-x / Math.PI) - 0.5;
            else return Math.Tan(x);
        }
    }
}