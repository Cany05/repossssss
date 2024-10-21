using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var k = GetNum("k");
            var m = GetNum("m");
            var n = GetNum("n");

            if (CheckTriangle(k, m, n))
                Console.WriteLine("Утверждение истинно");
            else 
                Console.WriteLine("Утверждение ложно");

            Console.ReadKey();
        }


        static int GetNum(string number)
        {
            Console.WriteLine("Введите число "+number);
             return int.Parse(Console.ReadLine());
        }
        static bool CheckTriangle(int k, int m, int n)
        {
            return (k+m)>n && (m+n)>k && (k+n)>m;
              
        }
    }
}
