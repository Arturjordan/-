using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Arr = new int[3, 5];
            Random random = new Random();
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Arr[i, j] = random.Next(0, 10);
                }
            }
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Console.Write(Arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int firstSum = 0;
            int secondSum = 0;
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        firstSum += Arr[i, j];
                    }
                    else if (i == Arr.GetLength(0) - 2)
                    {
                        secondSum += Arr[i, j];
                    }
                }
            }
            if (firstSum > secondSum)
                Console.WriteLine($"Сумма элементов первой строки больше {firstSum} > {secondSum}");
            else if (firstSum < secondSum)
                Console.WriteLine($"Сумма элементов предпоследнего столбца больше {secondSum} > {firstSum}");
            else
                Console.WriteLine("Столбцы равны");
            Console.ReadLine();
        }
    }
}
