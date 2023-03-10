using System;


namespace zad1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Son asd = new Son("Alex", 10, "Blue", "Black");
            int between_year = asd.Years();
            Dad fgh = new Dad("balc", "asd", 123);
            int between_years = fgh.Years();


            Console.WriteLine(between_year);
            Console.WriteLine(between_years);
        }
    }
}
