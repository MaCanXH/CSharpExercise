using System.Drawing;
using System.IO.Compression;

class Q14
{
    static void ans()
    {
        CirQue<int> test = new CirQue<int>();
        test.AddLast(12);
        test.AddLast(1);
        test.AddLast(2);
        test.AddLast(6);
        test.AddLast(-10);
        test.AddLast(9);
        Console.WriteLine("the size is " + test.Size);
        test.Remove(2);
        Console.WriteLine(test.GetEle(4));
        Console.WriteLine("the size is " + test.Size);
        test.Insert(12, 2);
        Console.WriteLine(test.GetEle(2));
        Console.WriteLine("the size is " + test.Size);

    }

    public class CirQue<T>
    {
        private T[] item;
        private int size;
        public CirQue ()
        {
            item = new T[5];
            size = 0;
        }
        public void AddLast(T value)
        {
            this.Resize();
            this.item[size] = value;
            this.size++;
        }
        public int Size
        {
            get{return this.size;}
        }
        public void Insert(T value, int idx)
        {
            if (idx > this.Size || idx < 0)
            {
                throw new IndexOutOfRangeException("out of bound");
            }
            Resize();
            Array.Copy(this.item, idx, this.item, idx + 1, this.Size - idx);
            item[idx] = value;
            this.size++;
        }
        public void Remove(int idx)
        {
            if (idx > this.Size || idx < 0)
            {
                throw new IndexOutOfRangeException("out of bound");
            }
            Array.Copy(item, idx + 1, item, idx, this.Size - (idx + 1));
            size--;
        }
        public T GetEle(int idx)
        {
            return item[idx];
        }
        private void Resize()
        {
            if(this.size + 1 > this.item.Length)
            {
                T[] temp = new T[this.item.Length * 2];
                Array.Copy(item, temp, item.Length);
                this.item = temp;
            }
        }
    }
}