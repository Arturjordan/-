using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Function(int x) 
        {
            double rz = (Math.Sin(x) - Math.Cos(x));
            Console.WriteLine($"Результатом выполнения функции Sin(x) - Cos(x), при x={x} будет равно {Math.Round(rz, 3)}");
        }
        static void Main(string[] args)
        {
            int firstNumber = -6;

            int secondNumber = 6;

            Parallel.For(firstNumber, secondNumber, Function);
        }
    }
}
