using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число а: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            A arel = new A(num1, num2);
            arel.vzv();
            arel.vkz();
            Console.ReadLine(); 
        }
        class A
        {
            public double a = 1; // поле данных
            public double b = 2; // поле данных

            public A(double a, double b)
            {
                this.a = a;
                this.b = b;
            }

            public void vzv()
            {
                Console.WriteLine($"{Math.Pow((a + b), 2)}");
            }

            public void vkz()
            {
                Console.WriteLine($"{(Math.Sin(b) + 4) / (2 * a)}");
            }
            
        }

    }
}
