class Q15
{
    static void ans()
    {
        DoublyLinkedList test = new DoublyLinkedList(12);
        test.AddLast(2);
        test.AddLast(4);
        test.AddLast(6);
        test.AddLast(13);
        test.AddLast(8);
        test.AddLast(-2);
        test.Sort();
        int[] testArray = test.ToArray();
        for(int i = 0; i < testArray.Length; i++)
        {
            Console.Write(testArray[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("The size: " + test.Size);
    }
    public class DoublyLinkedList
    {
        private class DoublyLinkedListNode
        {
            public int item;
            public DoublyLinkedListNode Next;
            public DoublyLinkedListNode Prev;
            public DoublyLinkedListNode (int i, DoublyLinkedListNode n, DoublyLinkedListNode p)
            {
                this.item = i;
                this.Next = n;
                this.Prev = p;
            }
        }
        private DoublyLinkedListNode item;
        private DoublyLinkedListNode first;
        private DoublyLinkedListNode last;
        private int size;
        public DoublyLinkedList (int i)
        {
            this.item = new DoublyLinkedListNode(i, null, null);
            size = 1;
            first = item;
            last = item;
        }
        public int Size
        {
            get{return size;}
        }

        // public void AddFirst(int i)
        // {
        //     item = new DoublyLinkedListNode(i, item, null);
        //     size++;
        // }
        public void AddLast(int i)
        {
            DoublyLinkedListNode p = item;
            while(p.Next != null)
            {
                p = p.Next;
            }
            p.Next = new DoublyLinkedListNode(i, null, p);
            size++;
        }
        public void Remove(int value)
        {
            DoublyLinkedListNode p = item;
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
        public int Find(int value)
        {
            DoublyLinkedListNode p = item;
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
        public void Insert(int value, int index)
        {
            DoublyLinkedListNode p = item;
            for(int i = 0; i < index; i++)
            {
                p = p.Next;
            }
            p.Prev.Next = new DoublyLinkedListNode(value, p, p.Prev);
            p.Prev = p.Prev.Next;
            size++;
        }
        public int FindEle(int index)
        {
            DoublyLinkedListNode p = item;
            for (int i = 0; i < index; i++)
            {
                p = p.Next;
            }
            return p.item;
        }
        public int[] ToArray()
        {
            DoublyLinkedListNode p = item;
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = p.item;
                p = p.Next;
            }
            return array;
        }
        public void Sort()
        {
            DoublyLinkedListNode p = this.item;
            for(int i = this.Size - 1; i >= 0; i--)
            {
                p = this.item;
                for(int j = 0; j < i; j++)
                {
                    if(p.item > p.Next.item)
                    {
                        this.Swap(p, p.Next);
                    }
                    p = p.Next;
                }
            }
        }
        private void Swap(DoublyLinkedListNode a, DoublyLinkedListNode b)
        {
            int temp = a.item;
            a.item = b.item;
            b.item = temp;
        }
    }
}