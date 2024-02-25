using System.Text;

namespace LinkedList
{
    public class LinkedList<T>
    {
        public Element<T> Top { get; set; }

        public void AddFirst(T item)
        {
            var newElement = new Element<T>();
            newElement.Value = item;
            newElement.Next = Top;
            Top = newElement;
        }

        public void AddLast(T item)
        {
            if (Top == null)
            {
                AddFirst(item);
                return;
            }
            var current = Top;

            while (current.Next != null)
                current = current.Next;

            current.Next = new Element<T> { Value = item };
        }

        public void RemoveValue(T item)
        {
            if (Top is null) return;
            if (Top.Value.Equals(item))
            {
                Top = Top.Next;
                return;
            }
            var current = Top;
            while (current.Next != null)
            {
                if (current.Next.Value.Equals(item))
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }

        }

        public void RemoveAtIndex(int k)
        {
            if (Top is null) return;
            if (k == 0)
            {
                Top = Top.Next;
                return;
            }
            int index = 0;
            var current = Top;
            while (current.Next != null)
            {
                if (index == k - 1)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                index++;
                current = current.Next;
            }
        }

        public bool Contains(T item)
        {
            var current = Top;
            while (current != null)
            {
                if (current.Value.Equals(item))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public int Counts(T item)
        {
            var current = Top;
            var count = 0;
            while (current != null)
            {
                if (current.Value.Equals(item))
                    count += 1;
                current = current.Next;
            }
            return count;
        }

        public void Clear() => Top = null;

        public override string ToString()
        {
            if (Top is null) return null;
            var sb = new StringBuilder();
            var el = Top;
            while (el != null)
            {
                sb.Append($"{el.Value} -> ");
                el = el.Next;
            }
            sb.Remove(sb.Length - 4, 3);
            return sb.ToString();
        }
    }

    public class Element<T>
    {
        public Element<T> Next { get; set; }
        public T? Value { get; set; }
    }
}