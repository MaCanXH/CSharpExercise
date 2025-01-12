using System.Reflection.Metadata;

class Q13
{
    static void ans()
    {
        Deque<int> test = new Deque<int>(12);
        test.AddFirst(212);
        test.AddFirst(2);
        test.AddFirst(32);
        test.AddLast(45);
        test.Remove(5);
        Console.WriteLine("this length of the queue is " + test.Count);
        int[] array = test.ToArray();
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

    }

    public class Deque<T>
    {
        private class QueNode<T>
        {
            public T item;
            public QueNode<T> Prev;
            public QueNode (T i, QueNode<T> p)
            {
                this.item = i;
                this.Prev = p;
            }
        }
        QueNode<T> first;
        QueNode<T> last;
        int count;
        public int Count
        {
            get{return count;}
        }
        public Deque(T i)
        {
            first = new QueNode<T>(i, null);
            last = first;
            count = 1;
        }
        public void AddFirst(T i)
        {
            first.Prev = new QueNode<T>(i, null);
            first = first.Prev;
            count++;
        }
        public void AddLast(T i)
        {
            last = new QueNode<T>(i, last);
            count++;
        }
        public void Remove(int index)
        {
            QueNode<T> p = last;
            // index of the queue started from 0
            // when the input index is larger or equal to the count
            // it is out of bound
            if(index >= count)
            {
                // Console.WriteLine("out of bound!");
                // return;
                throw new Exception("out of bound!");
            }
            if(index == 0)
            {
                last = p.Prev;
                count--;
                return;
            }
            for (int i = 0; i < index - 1; i++)
            {
                p = p.Prev;
            }
            p.Prev = p.Prev.Prev;
            count--;
        }
        public void Clear()
        {
            this.last = null;
            this.first = null;
            count = 0;
        }
        public T[] ToArray()
        {
            T[] array = new T[count];
            QueNode<T> p = last;
            for (int i = count - 1; i >= 0; i--)
            {
                array[i] = p.item;
                p = p.Prev;
            }
            return array;
        }
    }
}