using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[25];
            int countNeqative = 0;
            Random random = new Random();
            using (StreamWriter _stwriter = new StreamWriter(@"C:\input.txt"))
                for (int i = 0; i < mass.Length; i++)
                    _stwriter.WriteLine(random.Next(-100, 100));
            using (StreamReader _stread = new StreamReader(@"C:\input.txt"))
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = int.Parse(_stread.ReadLine());
                }
            }
            int max = mass.Max();
            int min = mass.Min();
            for (int e = 0; e < mass.Length; e++)
            {
                if (mass[e] <= 0)
                {
                    countNeqative++;
                }
            }
            Console.WriteLine("Максимум:{0}\nМинимум:{1}\nКоличество отрицательных цифр:{2}", max, min, countNeqative);

        }
    }
}
