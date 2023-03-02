using System;
using System.Text.RegularExpressions;


namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex regex = new Regex(@".+[а,я,е,у,и,о]{2}[ ]");
            MatchCollection mc = regex.Matches(text);
            foreach (Match m in mc)
            {
                Console.WriteLine(m.Value);
            }
            Console.ReadLine();
        }
    }
}
