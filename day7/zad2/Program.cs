using System;

namespace zad2

{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            if (!VvodVerniy(s))
            {
                Console.WriteLine("Необходимо ввести только цифры и буквы");
                return;
            }
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    sum += Convert.ToInt32(s[i].ToString());
                }
            }
            if (sum == s.Length)
            {
                Console.WriteLine("Сумма цифр в строке = длине строки");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Сумма цифр в строке != длине строки");
                Console.ReadLine();
            }
        }
        static bool VvodVerniy(string inputStr)
        {
            for (int i = 0; i < inputStr.Length; i++)
            {
                if (!char.IsLetterOrDigit(inputStr[i]))
                {
                    return false;
                }
            }
            return true;
            Console.ReadLine();
        }
        
    }
}
