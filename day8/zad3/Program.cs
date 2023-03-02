using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст :");
            string text = Console.ReadLine();

            Console.WriteLine("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] offers = text.Split('.');

            Regex regex = new Regex(@"\w+");
            foreach (string offer in offers)
            {
                MatchCollection words = regex.Matches(offer);
                if (words.Count >= n)
                {
                    Console.WriteLine(offer);

                }
            }
            Console.ReadLine();
        }
    }
}
