using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class StackMas
    {
        private T[] array;
        private int top, capacity;

        public StackMas()
        {
            capacity = 0;
            top = -1;
            array = new int[capacity];

        }

        public void Push(int item)
        {
            array[top++] = item;
        }

        public void PrintArr()
    }
}
