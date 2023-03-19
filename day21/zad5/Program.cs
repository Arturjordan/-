using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace zad5
{
    internal class Program
    {
        static void Experence(int x, ParallelLoopState pnl) 
        {
            long sum = 1;
            
            for (int i = 0; i <= x; i++)
            {
                sum *= i;   
            }

            int sub = 0;
            for (int i = 0; i <= x; i++)
            {
                sub -= i;
            }

            if ((sum < 300) && (sub > 300))
            {
                pnl.Break();
            }
            Console.WriteLine($"сумма: {sum}, вычитание: {sub}");
        }
        static void Main(string[] args)
        {
            ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 1, 4, 61, 85 }, Experence);
            if (!result.IsCompleted)
                Console.WriteLine($"прерываение на {result.LowestBreakIteration}");

        }
    }
}
