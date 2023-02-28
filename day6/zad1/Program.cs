using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static int[] Input()
        {
            Console.WriteLine("Введите размерность массива: ");
            int A = int.Parse(Console.ReadLine());
            int[] a = new int[A];
            for (int i = 0; i < A; i++)
            {
                Console.Write("A[{0}]= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);

            }
        }

        static void Change(int[] a) 
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
        static void Main() 
        {
            int[] MyArray = Input();
            Console.WriteLine("Исходный массив: ");
            Print(MyArray);
            Console.WriteLine("Значение меньше нуля: ");
            Change(MyArray);
            Console.ReadLine();
        }
    }
}
