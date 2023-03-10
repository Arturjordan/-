using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class B : A
    {
        internal int d = 10;

        internal int c2
        {
            get
            {
                while (d > 1)
                {
                    return a + b + c;
                }
                return c;
            }
            set { c2 = value; }
        }
    }
}
