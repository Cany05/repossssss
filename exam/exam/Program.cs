using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cube;
            Dictionary<string, List<int>> cubesByDigitSignature = new Dictionary<string, List<int>>();

            for (int i = 1; ; i++)
            {
                cube = i * i * i;
                string digitSignature = GetDigitSignature(cube);

                if (!cubesByDigitSignature.ContainsKey(digitSignature))
                {
                    cubesByDigitSignature[digitSignature] = new List<int>();
                }

                cubesByDigitSignature[digitSignature].Add(cube);

               
                if (cubesByDigitSignature[digitSignature].Count == 3)
                {
                    var foundCubes = cubesByDigitSignature[digitSignature];
                    Console.WriteLine($"Наименьшее число: {foundCubes.Min()} (куб числа {GetCubeRoot(foundCubes.Min())})");
                    Console.WriteLine($"Кубы: {string.Join(", ", foundCubes)}");
                    break;
                }
            }

            Console.ReadKey();
        }

        static string GetDigitSignature(int number)
        {
          
            char[] digits = number.ToString().ToCharArray();
            Array.Sort(digits);
            return new string(digits);
        }

        static int GetCubeRoot(int number)
        {
            return (int)Math.Round(Math.Pow(number, 1.0 / 3.0));
        }
    }
}