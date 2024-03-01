using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class StackOnMas<T>
    {
        private T[] array;
        private const int capacity = 4;
        private int size;

        public StackOnMas()
        {
            size = 0;
            array = new T[capacity];
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public T Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            return array[size--];
        }

        public void Push(T newElem)
        {
            if (size == array.Length)
            {
                T[] newArray = new T[2 * array.Length];
                Array.Copy(array, newArray, size);
                array = newArray;
            }
            array[++size] = newElem;
        }
    }
}
