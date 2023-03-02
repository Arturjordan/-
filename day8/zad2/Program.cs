using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex regex = new Regex(@"\b(\w+?)\s\1\b");
            MatchCollection mc = regex.Matches(text);
            foreach (Match m in mc)
            {
                Console.WriteLine(m.Value);
            }
            Console.ReadLine();
        }
    }
}
