using System.Drawing;
using System.Reflection.Metadata;

class Q11
{
    static void ans()
    {
        DoublyLinkedList<int> test = new DoublyLinkedList<int>(12);
        test.AddLast(2);
        test.AddLast(4);
        test.AddLast(22);
        test.AddLast(-2);
        test.AddLast(9);
        test.AddLast(5);
        test.Remove(22);
        test.Insert(5, 3);
        int[] testArray = test.ToArray();
        for(int i = 0; i < testArray.Length; i++)
        {
            Console.Write(testArray[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("The size: " + test.Size);
    }

    public class DoublyLinkedList<T>
    {
        private class DoublyLinkedListNode<T>
        {
            public T item;
            public DoublyLinkedListNode<T> Next;
            public DoublyLinkedListNode<T> Prev;
            public DoublyLinkedListNode (T i, DoublyLinkedListNode<T> n, DoublyLinkedListNode<T> p)
            {
                this.item = i;
                this.Next = n;
                this.Prev = p;
            }
        }
        private DoublyLinkedListNode<T> item;
        private static DoublyLinkedListNode<T> first;
        private static DoublyLinkedListNode<T> last;
        private static int size;
        public DoublyLinkedList (T i)
        {
            this.item = new DoublyLinkedListNode<T>(i, null, null);
            size = 1;
            first = item;
            last = item;
        }
        public int Size
        {
            get{return size;}
        }

        // public void AddFirst(T i)
        // {
        //     item = new DoublyLinkedListNode<T>(i, item, null);
        //     size++;
        // }
        public void AddLast(T i)
        {
            DoublyLinkedListNode<T> p = item;
            while(p.Next != null)
            {
                p = p.Next;
            }
            p.Next = new DoublyLinkedListNode<T>(i, null, p);
            size++;
        }
        public void Remove(T value)
        {
            DoublyLinkedListNode<T> p = item;
            while(p.Next != null)
            {
                if(Object.Equals(p.item, value))
                {
                    break;
                }
                p = p.Next;
            }
            if(p.Next == null)
            {
                if(Object.Equals(p.item, value))
                {
                    p.Prev.Next = null;
                    // p.Prev = null;
                    size--;
                    return;
                }
                else
                {
                    Console.WriteLine("There is no such item in the list");
                    return;
                }
            }
            p.Prev.Next = p.Next;
            p.Next.Prev = p.Prev;
            size--;
        }
        public int Find(T value)
        {
            DoublyLinkedListNode<T> p = item;
            int index = 0;
            while (p.Next != null)
            {
                if(Object.Equals(p.item, value))
                {
                    return index;
                }
                p = p.Next;
                index++;
            }
            return -1;
        }
        public void Insert(T value, int index)
        {
            DoublyLinkedListNode<T> p = item;
            for(int i = 0; i < index; i++)
            {
                p = p.Next;
            }
            p.Prev.Next = new DoublyLinkedListNode<T>(value, p, p.Prev);
            p.Prev = p.Prev.Next;
            size++;
        }
        public T FindEle(int index)
        {
            DoublyLinkedListNode<T> p = item;
            for (int i = 0; i < index; i++)
            {
                p = p.Next;
            }
            return p.item;
        }
        public T[] ToArray()
        {
            DoublyLinkedListNode<T> p = item;
            T[] array = new T[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = p.item;
                p = p.Next;
            }
            return array;
        }
    }
}