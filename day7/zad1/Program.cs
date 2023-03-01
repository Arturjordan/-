using System;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            var str = Console.ReadLine().ToLower();
            Console.WriteLine($"Жы в тексте: {str.Contains("жы")}");
            Console.WriteLine($"Шы в тексте: {str.Contains("шы")}");
            Console.WriteLine($"Чя в тексте: {str.Contains("чя")}");
            Console.WriteLine($"Щя в тексте: {str.Contains("щя")}");
            Console.ReadKey();
        }
    }
}
