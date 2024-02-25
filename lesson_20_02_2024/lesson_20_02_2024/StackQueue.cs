using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Queue<T>
    {
        private LinkedList<T> elements;

        public Queue()
        {
            elements = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            elements.AddLast(item);
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Очередь пуста");
            }

            T item = elements.Top.Value;
            elements.RemoveAtIndex(0);
            return item;
        }

        public bool IsEmpty()
        {
            return elements.Top == null;
        }

        public override string ToString()
        {
            return elements.ToString();
        }
    }

    public class Stack<T>
    {
        private LinkedList<T> elements;

        public Stack()
        {
            elements = new LinkedList<T>();
        }

        public void Push(T item)
        {
            elements.AddFirst(item);
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Стек пуст");
            }

            T item = elements.Top.Value;
            elements.RemoveAtIndex(0);
            return item;
        }

        public bool IsEmpty()
        {
            return elements.Top == null;
        }

        public override string ToString()
        {
            return elements.ToString();
        }
    }
}