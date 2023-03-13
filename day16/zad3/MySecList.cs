using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    public static class MySecList
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            for (int i = 0; i < list.Values.Length; i++)
            {
                Console.WriteLine(list.Values[i]);
            }
            return list.Values;
        }
    }
}
