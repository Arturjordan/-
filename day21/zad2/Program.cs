using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Math;

namespace zad2
{
    internal class Program
    {
        static double First(double x)
        {
            return ((((Math.Pow(x,2)) + (2 * x) - 3) + ((x + 1) * (Math.Sqrt(Math.Pow(x,2) - 9)))) / (((Math.Pow(x,2)) - (2 * x)) - 3) + ((x - 1) * (Math.Sqrt(Math.Pow(x,2) - 9))));
        }

        static double Second(double x)
        {
            return Math.Sqrt(((x + 3) / (x - 3)));
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Task[] tasks = new Task[2]
            {
                new Task(() => Console.WriteLine($"1 задача: {First(x)}")),
                new Task(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"2 задача: {Second(x)}");
                })
            };
            foreach (var task in tasks)
            {
                task.Start();
                task.Wait();
            }
        }
    }
}
