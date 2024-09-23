using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01_poem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine("Луна и смерть.");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Зубы кости слоновой\r\nу луны ущербленной.\r\nО, канун умиранья!\r\nНи былинки зеленой,\r\nопустелые гнезда,\r\nпересохшие русла…\r\nУмирать под луною\r\nтак старо и так грустно!");

            Console.ResetColor();
           
            Console.ReadKey();  
        }
    }
}
