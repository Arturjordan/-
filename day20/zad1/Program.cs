using System;

namespace zad1
{
    internal class Program
    {
        /// <summary>
        /// Calculation methods
        /// </summary>
        /// <param name="x">x side value</param>
        /// <param name="n">y side value</param>
        /// <returns>
        /// <param name="y">return out param y </param>
        /// </returns>
        static void F(double x, double n)
        {
            double y;
            y = (Math.Pow(x, n)) / (n);
            Console.WriteLine(y);
        }

       
        static void Main(string[] args)
        {
            double n;
            double x;
            Console.Write("Введите x: ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("Введите n: ");
            n = Double.Parse(Console.ReadLine());


            F(x, n);
            Console.ReadLine();

        }
    }
}
