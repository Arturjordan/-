using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(23);
            list.Add(41);
            list.Add(89);
            Console.WriteLine($"Элемент с индексом 3: {list[3]}");
            Console.WriteLine($"Длина: {list.Length}");
            list.GetArray();
        }
    }
}
