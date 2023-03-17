using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Animal
    {
        public string name;
        public int count;
        public Animal(string name, int count)
        {
            this.name = name;
            this.count = count;
        }
        virtual public void PrintInf()
        {
            Console.WriteLine($"Название животного: '{name}' На планете их осталось: {count}");
        }
    }
}
