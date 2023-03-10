using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        delegate string JustOperation(string message);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение");
            string message = Console.ReadLine();
            Console.WriteLine("Выбор действия: ");
            Console.WriteLine("1 - Перевести текст в нижний регистр, 2 - Перевести текст в верхний регистр, 3 - Удаление");
            int Operation = Convert.ToInt32(Console.ReadLine());
            string res;


            switch (Operation)
            {
                case 1:
                    JustOperation lower = toLower;
                    res = lower(message);
                    Console.WriteLine(res);
                    break;
                case 2:
                    JustOperation upper = toUpper;
                    res = upper(message);
                    Console.WriteLine(res);
                    break;
                case 3:
                    JustOperation Trim = Tr;
                    res = Trim(message);
                    Console.WriteLine(res);
                    break;
            }


        }
        public static string toLower(string message) => message.ToLower();
        public static string toUpper(string message) => message.ToUpper();
        public static string Tr(string message) => message.Trim();
    }
}
