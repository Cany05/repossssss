using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число");
         int a = int.Parse(Console.ReadLine());
            int first = a / 1000;
            int second = a % 1000 /100;
            int third = a % 100/10;
            int fourth = a % 10;

            int b = third*1000+first*100+second*10+fourth;
           
            Console.WriteLine("Полученное число: "+b);
            Console.ReadKey();
        }
    }
}
