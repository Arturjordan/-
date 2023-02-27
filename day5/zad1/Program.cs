using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double y1;
                double y2;
                Console.WriteLine("Введите X: ");
                int X = Convert.ToInt32(Console.ReadLine());
                y1 = X + (2 * X) / (4 * Math.Sin(X));
                Console.WriteLine("Первый Y = " + y1);
                y2 = X - 3 + (1 / (Math.Tan(X - 1)));
                Console.WriteLine("Второй Y = " + y2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль запрещено! ");
            }
            catch (FormatException)
            {
                Console.WriteLine("Не введено значение! ");
            }
            finally
            {
                Console.WriteLine("Завершение программы! ");
            }
            Console.ReadLine();

        }
    }
}
