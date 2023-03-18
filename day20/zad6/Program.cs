using System;

namespace zad6
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

        /// <summary>
        /// Transfer method for string
        /// </summary>
        /// <param name="message"></param>
        /// <returns>
        /// <param name="message"> message to lower register </param>
        /// </returns>
        /// 

        public static string toLower(string message) => message.ToLower();

        /// <summary>
        /// Transfer method for string
        /// </summary>
        /// <param name="message"></param>
        /// <returns>
        /// <param name="message"> message to upper register </param>
        /// </returns>
        /// 
        public static string toUpper(string message) => message.ToUpper();

        /// <summary>
        /// Transfer method for string
        /// </summary>
        /// <param name="message"></param>
        /// <returns>
        /// <param name="message"> message to trim method </param>
        /// </returns>
        /// 
        public static string Tr(string message) => message.Trim();
    }
}

