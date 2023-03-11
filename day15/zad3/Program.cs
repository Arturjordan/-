using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(First));
            Thread thread2 = new Thread(new ThreadStart(Second));

            thread1.Start();
            thread1.Join();
            thread2.Start();
            thread2.Join();

         
        }
        static void First() 
        {
            Console.WriteLine("Введите А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Первый поток");
            int item = 0;
            
            for (int i = A; i < N; i++)
            {
                item +=  Convert.ToInt32(Math.Pow(A, N));
            }
            Console.WriteLine(item);

        }
        static void Second()
        {
            Console.WriteLine("Введите А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Второй поток");
            int item = 1;
            
            for (int i = A; i < N; i++)
            {
                item += item * Convert.ToInt32(Math.Pow(A, N));
            }
            Console.WriteLine(item);
            

        }
    }
}
