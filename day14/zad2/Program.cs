using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace zad2
{
    delegate double JustOperation(double x, double y);
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double xNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x");
            double yNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выбор действия: ");
            Console.WriteLine("1 - ADD, 2 - SUB, 3 - DIV");
            int Operation = Convert.ToInt32(Console.ReadLine());
            double res;


            switch (Operation)
            {
                case 1:
                    JustOperation addder = Add;
                    res = DelegateWatch(xNum, yNum, addder);
                    Console.WriteLine(res);
                    break;
                case 2:
                    JustOperation subliciton = Sub;
                    res = DelegateWatch(xNum, yNum, subliciton);
                    Console.WriteLine(res);
                    break;
                case 3:
                    JustOperation divizion = Div;
                    res = DelegateWatch(xNum, yNum, divizion);
                    Console.WriteLine(res);
                    break;
                default:
                    Console.WriteLine("Операции не существует! ");
                    break;
            }


        }

        public static double DelegateWatch(double xNum, double yNum, JustOperation oper) {
            double res = oper(xNum, yNum);
            return res;
        }
        public static double Add(double x, double y) => x + y;
        public static double Sub(double x, double y) => x - y;
        public static double Div(double x, double y) => x / y;
        
    }
}

