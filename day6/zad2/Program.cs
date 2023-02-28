using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = new int[98];
            Random rand = new Random();
            Console.Write("Последовательность: ");
            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = rand.Next(10);
                Console.Write($"{firstArr[i]} ");
            }
            Console.WriteLine();
            int min = firstArr.Min();
            int max = firstArr.Max();
            Console.Write("Преобразованная последовательность: ");
            for (int i = 0; i < firstArr.Length; i++)
            {
                if ((firstArr[i] != max) && (firstArr[i] != min))
                {
                    Console.Write($"{firstArr[i]} ");
                }
            }
            Console.ReadLine();
        }

    }
}
