using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MasQueue<T>
    {
        private T[] array;
        private int top;
        private int rear;
        private int capacity;
        private int count;

        public MasQueue(int size)
        { 
            array = new T[size];
            capacity = size;
            top = 0;
            rear = -1;
            count = 0;
        }

        public void Enqueue(T item)
        {
            if (count == capacity)
            {
                Console.WriteLine("Queue is full");
                return;
            }

            rear = (rear + 1) % capacity;
            array[rear] = item;
            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
            {
                throw new Exception("Queue is empty");
            }

            T item = array[top];
            top = (top + 1) % capacity;
            count--;
            return item;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void PrintQueue()
        {
            int i = top;
            int j = 0;
            while (j < count)
            {
                Console.Write(array[i] + " ");
                i = (i + 1) % capacity;
                j++;
            }
            Console.WriteLine();
        }
    }
}
