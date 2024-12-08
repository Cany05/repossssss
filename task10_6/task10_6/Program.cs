using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cattleAmount, money, bulls, cows, calves;
            double totalCost;
            money = 100;
            cattleAmount = 100;

            for (bulls = 0; bulls <= money / 10; bulls++)
            {
                for (cows = 0; cows <= (money - bulls * 10) / 5; cows++)
                {

                    calves = cattleAmount - bulls - cows;
                    if (calves >= 0)
                    {
                        totalCost = bulls * 10 + cows * 5 + calves * 0.5;
                        if (totalCost == 100)
                        {
                            Console.WriteLine($"Быков: {bulls}; Коров: {cows}; Телят: {calves}");

                        }
                    }
                }

               
            }
                Console.ReadKey();

        }
    }
}