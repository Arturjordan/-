﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        public static void Main()
        {

            B b = new B();
            Console.WriteLine("a={0} ", b.a, "b={0} ", b.b, "d={0} ", b.d);
            Console.WriteLine("2={0} ", b.c, "c2={0} ", b.c2);
        }
    }

    internal class B
    {
        internal object b;
        internal int a;
        internal int c;
        internal object c2;
        internal object d;
    }
}
