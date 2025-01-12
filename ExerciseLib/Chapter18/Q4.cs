using System.Net.NetworkInformation;
using System.Collections;

class Q4
{
    // Q4. Implement a DictHashSet<T> class, based on HashDictionary<K, V> 
    // class, we discussed in the text above.
    static void ans()
    {
        DictHashSet<string> test = new DictHashSet<string>("2");
        test.Add("3");
        test.Add("4");
        test.Add("5");
        Console.WriteLine(test.Count);
        Console.WriteLine(test.Contain("1"));
        Console.WriteLine(test.Remove("3"));
        Console.WriteLine(test.Count);
        DictHashSet<string> set = new DictHashSet<string>();
        set.Add("3");
        set.Add("5");
        set.Add("6");
        test.IntersectWith(set);
        // check intersection
        Console.WriteLine("check intersection");
        foreach(var i in test)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        DictHashSet<string> set2 = new DictHashSet<string>();
        set2.Add("7");
        set2.Add("8");
        set2.Add("9");
        test.UnionWith(set2);
        // check union
        Console.WriteLine("check union");
        foreach(var i in test)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        DictHashSet<string> set3 = new DictHashSet<string>();
        set3.Add("1");
        set3.Add("2");
        set3.Add("3");
        set3.Add("4");
        DictHashSet<string> set4 = new DictHashSet<string>();
        set4.Add("1");
        set4.Add("2");

        Console.WriteLine(set4.IsSubsetOf(set3));
        Console.WriteLine(set3.IsSupersetOf(set4));

        test.Clear();
        Console.WriteLine(test.Count);

    }
}
// <summary> Implementatio nof DictHashSet<T> based on HashhDictionary<T, T>
// where both key and value of generic type T. </summary>
// Answer not complete since the iteration function bug.

class DictHashSet<T> : IEnumerable<T>
{
    private HashDictionary<T, T> set;
    public DictHashSet()
    {
        this.set = new HashDictionary<T, T>();
    }

    public DictHashSet(T value)
    {
        if(this.set == null)
        {
            this.set = new HashDictionary<T, T>();
        }
        this.set.Set(value, value);
    }
    public void Add(T value)
    {
        this.set[value] = value;
    }
    public bool Contain(T value)
    {
        if (value.Equals(this.set.Get(value)))
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
    public void IntersectWith(DictHashSet<T> other)
    {
        HashDictionary<T, T> temp = new HashDictionary<T, T>();
        foreach(var ele in this.set)
        {
            if(other.Contain(ele.Key))
            {
                temp.Set(ele.Key, ele.Value);
            }
        }
        this.set = temp;
    }
    public void UnionWith(DictHashSet<T> other)
    {
        HashDictionary<T, T> temp = new HashDictionary<T, T>();
        foreach(var ori in this.set)
        {
            temp.Set(ori.Key, ori.Value);
        }
        foreach(var add in other)
        {
            if(!this.Contain(add))
            {
                temp.Set(add, add);
            }
        }
        this.set = temp;
    }
    public bool IsSubsetOf(DictHashSet<T> other)
    {
        foreach(var i in this.set)  
        {
            if(!other.Contain(i.Key))
            {
                return false;
            }
        }
        return true;
    }
    public bool IsSupersetOf(DictHashSet<T> other)
    {
        foreach(var i in other)
        {
            if(!this.Contain(i))
            {
                return false;
            }
        }
        return true;
    }
    public IEnumerator<T> GetEnumerator()
    {
        foreach(KeyValuePair<T, T> entry in this.set)
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