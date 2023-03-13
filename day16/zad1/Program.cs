using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        public static void Main()
        {
            MyList<int> mylist = new MyList<int>(5);
            mylist[0] = 1;
            mylist.Addition(10);
            Console.WriteLine(" кол-во элементов: {0}", mylist.Size);
            Console.WriteLine("введите индекс элемента в списке, который хотите получить:");
            int getValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Get value: {mylist[getValue]}");

            for (int i = 0; i < mylist.Size; i++)
            {
                Console.WriteLine(mylist[i]);
            }

            Console.ReadKey();
        }
    }
}
