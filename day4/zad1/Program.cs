using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void F(double x, double n)
        {
            double y;
            y = (Math.Pow(x,n)) / (n);
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


            F(x,n);
            Console.ReadLine();
           
        }



    }
}
