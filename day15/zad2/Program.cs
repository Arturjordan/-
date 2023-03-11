using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace zad2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(PotokOperciy));

            thread1.Start();
            thread1.Join();

        }
        static void PotokOperciy() { 
        Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            int step = 0;
            Console.WriteLine("Potok is Run!!!!!!");
            for (int i = 0; i <= 10; i++)
            {
                step += i;
            }
            Console.WriteLine(step);
            sWatch.Stop();
            Console.WriteLine(sWatch .ElapsedMilliseconds.ToString());
        }
    }
}
