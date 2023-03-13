using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    public class MyList<T>
    {
        public int index = 3;
        public T[] Values = new T[3];

        public void Add(T value)
        {
            Array.Resize(ref Values, index + 1);

            Values[index] = value;
            index++;
        }
        public T this[int index]
        {
            get => Values[index];
        }

        public int Length
        {
            get => Values.Length;
        }
    }
}
