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
            try
            {
                double f;
                Console.WriteLine("Введите вещественный X: ");
                double X = Convert.ToDouble(Console.ReadLine());

                if (X < 1 && X > -5)
                {
                    f = X - 3;
                    Console.WriteLine(f);
                }
                else if (X >= 1)
                {
                    f =  (Math.Pow(X,2)) / ((3 * X) - 9);
                    Console.WriteLine(f);
                }
                else throw new Exception("Ошибка: выход из диапозона допустимых значений X");
            }
            catch (DivideByZeroException DfX)
            {
                Console.WriteLine("Деление на ноль запрещено! " + DfX.Message);
            }
            catch (FormatException fX)
            {
                Console.WriteLine("Не введено значение X! " + fX.Message);
            }
            finally 
            {
                Console.WriteLine("Программа завершена! ");
            }
            Console.ReadLine();
        }
    }
}
