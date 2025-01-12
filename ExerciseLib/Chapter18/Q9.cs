using System.Collections;

class Q9
{
    // Q9. Implement the data structure "Set" in a class HashedSet<T>, 
    // using your class HashTable<K, T> to hold the elements. Implement 
    // all standard set operations like Add(T), Find(T), Remove(T), 
    // Count, Clear(), union and intersect.

    // not yet completed, cannot implement IEnumerable interface.
    static void ans()
    {
        HashedSet<string> test = new HashedSet<string>("2");
        test.Add("3");
        test.Add("4");
        test.Add("5");

        Console.WriteLine("The set contains: ");
        foreach(var i in test)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        string s = "3";

        Console.WriteLine("count of set is " + test.Count);
        Console.WriteLine("set contain {0}? {1}", s, test.Contain(s));
        Console.WriteLine("set remove {0}? {1}", s, test.Remove(s));
        Console.WriteLine("set contain {0}? {1}", s, test.Contain(s));
        Console.WriteLine("count of set is " + test.Count);

        Console.WriteLine("The set contains: ");
        foreach(var i in test)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        HashedSet<string> test2 = new HashedSet<string>();
        test2.Add("1");
        test2.Add("2");
        test2.Add("3");
        test2.Add("5");
        test.Intersect(test2);

        Console.WriteLine("The set contains after intersection: ");
        foreach(var i in test)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        HashedSet<string> test3 = new HashedSet<string>();
        test3.Add("8");
        test3.Add("9");
        test3.Add("10");
        test3.Add("5");
        test.Union(test3);

        Console.WriteLine("The set contains after union: ");
        foreach(var i in test)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        test.Clear();
        Console.WriteLine("count of set after clear " + test.Count);
    }
}
class HashedSet<T> : IEnumerable<T>
{
    private HashTable<T, T> set;
    public HashedSet()
    {
        this.set = new HashTable<T, T>();
    }

    public HashedSet(T value)
    {
        if(this.set == null)
        {
            this.set = new HashTable<T, T>();
        }
        this.set.Add(value, value);
    }
    public void Add(T value)
    {
        this.set.Add(value, value);
    }
    public bool Contain(T value)
    {
        if (value.Equals(this.set.Find(value)))
        {
            return true;
        }
        return false;
    }
    public bool Remove(T value)
    {
        return this.set.Remove(value);
    }
    public void Clear()
    {
        this.set.Clear();
    }
    public void Union(HashedSet<T> other)
    {
        HashTable<T, T> temp = new HashTable<T, T>();
        foreach(KeyValuePair<T, T> ele in this.set)
        {
            temp.Add(ele.Key, ele.Value);
        }
        foreach(T ele in other)
        {
            if(!this.Contain(ele))
            {
                temp.Add(ele, ele);
            }
        }
        this.set = temp;
    }
    public void Intersect(HashedSet<T> other)
    {
        HashTable<T, T> temp = new HashTable<T, T>();
        foreach(var ele in other)
        {
            if(this.Contain(ele))
            {
                temp.Add(ele, ele);
            }
        }
        this.set = temp;
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach(var entry in this.set)
        {
            T output = entry.Key;
            yield return output;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Count
    {
        get{ return this.set.Count;}
    }
}