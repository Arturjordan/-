using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Пример: ");
            Animal first = new Animal("Сибирский тигр", 2034);
            Inf.Info<Animal>(first);
            A1 list = new A1();
            Dictionary<int, string> rep = new Dictionary<int, string>(3);
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите имя животного: ");
                string NameAn = null;
                NameAn = Console.ReadLine();
                Console.Write("Введите сколько их осталось на земле: ");
                int g = Convert.ToInt32(Console.ReadLine());

                list.Add(new Animal(NameAn, g));
                rep[i + 1] = NameAn;
            }
            Console.WriteLine("============ ");
            foreach (KeyValuePair<int, string> keyValue in rep)
            {
                Console.WriteLine($"{keyValue.Key} - {keyValue.Value}");
            }
            Console.WriteLine("============ ");
            foreach (Animal x in list)
                x.PrintInf();
            list.RemoveAt(1);
            Console.WriteLine("============ ");
            A1 pl = (A1)list.Clone();
            foreach (Animal x in pl) x.PrintInf();
            Console.ReadLine();
        }
    }
}

