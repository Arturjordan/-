using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static int Number(int number) 
        { 
            int firstNumber = number / 100;
            int secondNumber = ((number - (number / 100) * 100)) / 10;
            int thirdNumber = number % 100;

            //123
            Console.WriteLine($"The first result is = {firstNumber * 100 + secondNumber * 10 + thirdNumber}");
            //132
            Console.WriteLine($"The second result is = {firstNumber * 100 + secondNumber + thirdNumber * 10}");
            //312
            Console.WriteLine($"The third result is = {firstNumber + secondNumber * 10 + thirdNumber * 100}");
            //321
            Console.WriteLine($"The fourth result is = {firstNumber * 10 + secondNumber + thirdNumber * 100}");
            //213
            Console.WriteLine($"The fifth result is = {firstNumber * 10 + secondNumber * 100 + thirdNumber}");
            //231
            Console.WriteLine($"The sixth result is = {firstNumber + secondNumber * 100 + thirdNumber * 10}");

            return number;  
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите 3-х значное число: ");
                int Chislo = Convert.ToInt32(Console.ReadLine());
                Task task = new Task(() => Number(Chislo));
                task.Start();
                task.Wait();

                Task task2 = Task.Factory.StartNew(() => Number(Chislo));
                task2.Wait();

                Task task3 = Task.Run(() => Number(Chislo));
                task3.Wait();
            }
            catch (Exception)
            {
                Console.WriteLine("Было введено не 3-х значное число!");
                throw;
            }
          
        }
    }
}
