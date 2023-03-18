using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Program
    {
        delegate double Operation(double x, double y);
        public static void Main()
        {
            Console.WriteLine("Введите число х: ");
            double xNUM = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число y: ");
            double yNUM = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1 - Сумма, 2 - Разность, 3 - Умножение, 4 - Деление");
            double Operation = Convert.ToInt32(Console.ReadLine());
            double result;

            switch (Operation)
            {
                case 1:
                    Operation sum = Add;
                    result = sum(xNUM, yNUM);
                    Console.WriteLine(result);
                    break;
                case 2:
                    Operation sub = Sub;
                    result = sub(xNUM, yNUM);
                    Console.WriteLine(result);
                    break;
                case 3:
                    Operation mul = Mul;
                    result = mul(xNUM, yNUM);
                    Console.WriteLine(result);
                    break;
                case 4:
                    Operation div = Div;
                    result = Div(xNUM, yNUM);
                    Console.WriteLine(result);
                    break;
            }
        }

        /// <summary>
        /// Calculating method of addition
        /// </summary>
        /// <param name="xNUM"></param>
        /// <param name="yNUM"></param>
        /// <returns>
        /// xNUM + yNUM operation
        /// </returns>
        /// 
        public static double Add(double xNUM, double yNUM) => xNUM + yNUM;

        /// <summary>
        /// Calculating method of subtraction
        /// </summary>
        /// <param name="xNUM"></param>
        /// <param name="yNUM"></param>
        /// <returns>
        /// xNUM - yNUM operation
        /// </returns>
        /// 
        public static double Sub(double xNUM, double yNUM) => xNUM - yNUM;

        /// <summary>
        /// Calculating method of Myltiply
        /// </summary>
        /// <param name="xNUM"></param>
        /// <param name="yNUM"></param>
        /// <returns>
        /// xNUM * yNUM operation 
        /// </returns>
        /// 

        public static double Mul(double xNUM, double yNUM) => xNUM * yNUM;

        /// <summary>
        /// Calculating method of Divizion
        /// </summary>
        /// <param name="xNUM"></param>
        /// <param name="yNUM"></param>
        /// <returns>
        /// xNUM / yNUM operation 
        /// </returns>
        /// 
        public static double Div(double xNUM, double yNUM)
        {
            if (xNUM == 0)
            {
                throw new DivideByZeroException();
                Console.WriteLine("Ошибка деления на ноль");
            }
            else if (yNUM == 0)
            {
                throw new DivideByZeroException();
                Console.WriteLine("Ошибка деления на ноль");
            }
            else
            {
                return xNUM / yNUM;
            }
        }
    }
}
