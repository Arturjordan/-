using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int K = 2345;
                Console.WriteLine("Введите целочисленное число D1: ");
                int D1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целочисленное число D2:");
                int D2 = Convert.ToInt32(Console.ReadLine());
                AddLeftDigit(D1, ref K);
                Console.WriteLine(K);
                AddLeftDigit(D2, ref K);
                Console.WriteLine(K);
                Console.ReadLine();
            }
            catch (DivideByZeroException dv)
            {
                Console.WriteLine(dv.Message + "Деление на ноль! ");
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message + "Не верно введен формат! ");
            }
            Console.ReadLine();
        }

        public static void AddLeftDigit(int D, ref int K)
        {
                if (D <= 0 || D > 9 || K <= 0)
                    throw new ArgumentException("Неверное значение параметров");
                int n = K;
                while (n != 0)
                {
                    n /= 10;
                    D *= 10;
                }
                K += D;       
        }
        
    }
}
