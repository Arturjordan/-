using System;
using System.Collections.Generic;
using System.Linq;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string abc = "ab#c##d";
            Stack<char> stack = new Stack<char>();

            foreach (var item in abc)
            {
                if (item == '#')
                {
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else
                {
                    stack.Push(item);
                }
            }
            var array = stack.ToArray();
            Array.Reverse(array);
            string NewString = new string(array);
            Console.WriteLine(NewString);
        }
        
    }
}

