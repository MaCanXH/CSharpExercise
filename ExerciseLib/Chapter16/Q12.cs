class Q12
{
    static void ans()
    {
        DynamicStack<int> test = new DynamicStack<int>(22);
        test.Push(12);
        test.Push(11);
        test.Push(14);
        test.Push(15);
        test.Push(2);
        Console.WriteLine(test.Pop());
        Console.WriteLine(test.Pop());
        Console.WriteLine(test.Pop());
        Console.WriteLine(test.Pop());
        Console.WriteLine(test.Peek());
        test.Clear();
        Console.WriteLine("count of stack: " + test.Count);
        test.Push(66);
        Console.WriteLine(test.Peek());
        Console.WriteLine("count of stack: " + test.Count);
    }
    
    public class DynamicStack<T>
    {
        private class StackNode<T>
        {
            public T item;
            public StackNode<T> Prev;
            public StackNode (T i, StackNode<T> p)
            {
                this.item = i;
                this.Prev = p;
            }
        }
        int count = 0;
        StackNode<T> Last;
        public DynamicStack (T i)
        {
            Last = new StackNode<T> (i, null);
            count++;
        }
        public void Push(T i)
        {
            Last = new StackNode<T> (i, Last);
            count++;
        }
        public T Pop()
        {
            StackNode<T> result = Last;
            Last = Last.Prev;
            count--;
            return result.item;
        }
        public T Peek()
        {
            return Last.item;
        }
        public void Clear()
        {
            Last.item = default(T);
            Last.Prev = null;
            count = 0;
        }
        public int Count
        {
            get{return count;}
        }
    }
}