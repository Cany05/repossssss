using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительное число X");

            var x = double.Parse(Console.ReadLine());

            var y = MethodFunction(x);

            Console.WriteLine($"f(x) = {y}");

            Console.ReadKey();
        }

        static double MethodFunction(double x)
        {

           return (Math.Abs(2 * Math.Sin(-3 * Math.Abs((x+1)/2))));
        }
    }
}
