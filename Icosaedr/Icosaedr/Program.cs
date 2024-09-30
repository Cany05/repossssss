using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icosaedr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны икосаэдра:");
            var a = double.Parse(Console.ReadLine());
            var V = (5 * Math.Pow(a,3) * (3 + Math.Sqrt(5))) / 12;
            var S = 5 * a * a * Math.Sqrt(3);
            Console.WriteLine();
            Console.WriteLine("Объем икосаэдра = " + V);
            Console.WriteLine("Площадь поверхности икосаэдра = " + S);
            Console.ReadKey();
        }
    }
}
