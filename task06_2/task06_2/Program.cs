using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "перевозка";

            Console.WriteLine("Изначальное слово: " + s);
            Console.WriteLine();

            var a = s.Substring(4, 1);
            var b = s.Substring(1, 4);
            var c = s.Substring(7, 2);

        var word1 = a + b + c;
            Console.WriteLine(word1);
            Console.WriteLine();

            var x = s.Substring(0, 1);
            var y = s.Substring(5, 1);
            var z = s.Substring(4, 5);

            var word2 = x + y + z;

            Console.WriteLine(word2);
            Console.ReadKey();
        }
    }
}
