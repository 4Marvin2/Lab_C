using System;
using System.Collections.Generic;
using System.Text;
using SimpleListProject;

namespace lab03
{
    class SimpleStack<T> : SimpleList<T>
        where T : System.IComparable
    {
        public void Push(T element)
        {
            Add(element);
        }
        public T Pop()
        {
            T element = Get(Count - 1);
            GetItem(Count - 1);
            Count--;
            return element;
        }
    }
}
