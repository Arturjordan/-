using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    public class Array
    {
        public int[,] Arr;
        public Array(int row, int col)
        {
            this.Arr = new int[row, col];
        }
        public int GetValue(int row, int col)
        {
            return Arr[row, col];
        }
        public int SetValue(int row, int col, int val)
        {
            return Arr[row, col] = val;
        }
        public int GetLength(int d)
        {
            return Arr.GetLength(d);
        }
        public Array GetArr(Array arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    SetValue(i, j, random.Next(10));
                    Console.Write("{0,4}", arr.GetValue(i, j));
                }
                Console.WriteLine();
            }
            return arr;
        }
        public static Array operator +(Array Arr, int num)
        {
            for (int j = 0; j < Arr.GetLength(0); j++)
            {
                Arr.SetValue(j, 0, Arr.GetValue(j, 0) + Arr.GetValue(j, num));
            }
            return Arr;
        }
        public void Print(Array Arr)
        {
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Console.Write("{0,4}", Arr.GetValue(i, j));
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Array Arr = new Array(3, 4);
            Arr.GetArr(Arr);
            Console.WriteLine();
            Arr.Print(Arr + 2);
            Console.ReadLine();
        }
    }
}





//using System;
//using System.Collections;

//namespace zad2
//{
//    class Massiv
//    {
//        static void Main()
//        {
//            int n = 0;
//            int m = 0;
//            int[,] intArray = new int[n, m];
//            vvod(intArray, n, m);
//            Console.ReadLine();
//            stolstrok(intArray);
//            Console.ReadLine();
//            print(n, m);
//        }


//        public Massiv(int n, int m)//конструктор
//        {
//            int[,] intArray = new int[n, m];
//        }
//        static void vvod(int[,] intArray, int ns, int ms)
//        {
//            Console.WriteLine("Введите кол-во строк n");
//            int n = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Введите кол-во столбцов m");
//            int m = Convert.ToInt32(Console.ReadLine());

//            int[,] intArr = new int[ns, ms];

//            Console.WriteLine("Введите элементы массива");

//            for (int i = 0; i < intArray.GetLength(0); i++)
//            {
//                Console.WriteLine("Введите элементы " + i + "-й строки:");
//                for (int j = 0; j < intArray.GetLength(1); j++)
//                {
//                    Console.WriteLine();
//                    intArray[i, j] = int.Parse(Console.ReadLine());

//                }

//            }

//        }
//        static void print(int n, int m)
//        {
//            int[,] intArray = new int[n, m];
//            for (int i = 0; i < intArray.GetLength(0); i++)
//            {
//                for (int j = 0; j < intArray.GetLength(1); j++)
//                {
//                    Console.WriteLine("{0}\t", intArray[i, j]);
//                }
//            }
//            Console.ReadLine();
//        }


//        static void stolstrok(int[,] intArray)
//        {
//            Console.WriteLine("Введите число, которое хотите добавить к первому элементу: ");
//            int g = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(intArray[0, 0] += g);    
//            Console.ReadLine();

//        }
//    }
//}


