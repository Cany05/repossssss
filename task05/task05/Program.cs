using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x =Math.Round( MathF(1, 2) + MathF(2, 2) + MathF(3, 5) + MathF(4, 3),3);

            Console.WriteLine(x);
            Console.ReadKey();
        }
        static double MathF(double a, double b)
        {
            return ((a + Math.Pow(Math.E, -a)) / b);
        }
    }
}
