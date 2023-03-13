using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class MyList<T>
    {
        
        public T[] myList;

        public T this[int ind]
        {
            get { return myList[ind]; }
            set { myList[ind] = value; }
        }

        public MyList(int count)
        {
            myList = new T[count];
        }

        public void Addition(T items)
        {
            T[] extList = new T[myList.Length + 1];
            extList[extList.Length - 1] = items;
            myList = extList;
        }

        public int Size
        {
            get { return myList.Length; }

        }
    }
}

