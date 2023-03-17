using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Inf
    {
        public static void Info<tip>(tip obj)
        where tip : Animal
        {
            obj.PrintInf();
        }
    }
}
