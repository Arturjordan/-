using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class A1
    {
        private ArrayList list;
        public A1()
        {
            list = new ArrayList();
        }
        public A1(ArrayList a)
        {
            list = a;
        }
        public void Add(Animal m)
        {
            list.Add(m);
        }
        public A1 Clone()
        {
            return new A1(list);
        }
        public void RemoveAt(int i)
        {
            list.RemoveAt(i);
        }
        public void Clear()
        {
            list.Clear();
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
