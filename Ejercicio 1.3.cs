using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12,
                13,
                14,
                15,
                16,
                17,
                18,
                19,
                20,
                21,
                22,
                23,
                24,
                25,
                26,
                27,
                28,
                29,
                30
            };

            int currentLength = numbers.Length;
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randomIndex = rand.Next(currentLength);

                Console.WriteLine("---------- Iteración " + (i + 1) + " ----------");
                Console.WriteLine("Índice aleatorio: " + randomIndex);
                Console.WriteLine("Número elegido: " + numbers[randomIndex]);
                Console.WriteLine();

                numbers[randomIndex] = numbers[currentLength - 1];
                currentLength--;
            }
        }
    }
}