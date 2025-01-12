using System.Collections;
class Q8
{
    // Q8. Implement the data structure hash-table in a class 
    // HashTable<K,T>. Keep the data in an array of key-value pairs 
    // (KeyValuePair<K,T>[]) with initial capacity of 16. Resole the 
    // collisions with quadratic probing. When the hash table load runs
    //  over 75%, perform resizing to 2 times larger capacity. Implement 
    // the following methods and properties: Add(key, value), Find(key) 
    // -> value, Remove(key), Count, Clear(), this[] and Keys. Try to 
    // make the hash-table to support iterating over its elements with 
    // foreach.

    static void ans()
    {
        HashTable<string, int> test = new HashTable<string, int>(3, 0.75f);
        test["n1"] = 1;
        test["n2"] = 2;
        test["n3"] = 3;
        test["n1"] = 3;

        Console.WriteLine(test["n1"]);
        Console.WriteLine(test.Count);
        Console.WriteLine(test.Remove("d1"));
        Console.WriteLine(test.Remove("n1"));
        Console.WriteLine(test.Find("n1"));
        Console.WriteLine(test.Count);
        foreach (var i in test)
        {
            Console.WriteLine(i);
        }
        test.Clear();
        Console.WriteLine(test.Count);
    }
}
class HashTable<K, V> : IEnumerable<KeyValuePair<K, V>>
{
    private KeyValuePair<K, V>[] table;
    private const int DEFAULT_CAPACITY = 16;
    private const float DEFAULT_LOAD_FACTOR = 0.75f;
    private float loadFactor; 
    private int threshold; 
    private int size; 
    private int initialCapacity;
    public HashTable(): this(DEFAULT_CAPACITY, DEFAULT_LOAD_FACTOR){}
    public HashTable(int capacity, float loadFactor)
    {
        this.initialCapacity = capacity;
        this.table = new KeyValuePair<K, V>[capacity];
        this.loadFactor = loadFactor;
        this.threshold = (int)(capacity * loadFactor);
    }
    private int QuadraProbing(int oldPosition, int count)
    {
        int newPosition = (int)(oldPosition + 0.5 * count + 0.5 * count * count) % this.initialCapacity;
        return newPosition;
    }
    public void Add(K key, V value)
    {
        KeyValuePair<K, V> add = new KeyValuePair<K, V>(key, value);
        for (int i = 0; i < table.Length; i++)
        {
            if(!table[i].Equals(default(KeyValuePair<K, V>)) && table[i].Key.Equals(key))
            {
                table[i] = add;
                return;
            }
        }
        if(this.size >= this.threshold)
        {
            Expand();
        }
        int index = Math.Abs(key.GetHashCode());
        int count = 0;
        int pos = QuadraProbing(index, count);
        
        while(!this.table[pos].Equals(default(KeyValuePair<K,V>)))
        {
            count++;
            index = Math.Abs(key.GetHashCode());
            pos = QuadraProbing(index, count);
        }
        this.table[pos] = add;
        this.size++;
    }
    public V Find(K key)
    {
        foreach(KeyValuePair<K, V> target in table)
        {
            if(!target.Equals(default(KeyValuePair<K, V>)) && target.Key.Equals(key))
            {
                return target.Value;
            }
        }
        return default(V);
    }
    public bool Remove(K key)
    {
        for (int i = 0; i < table.Length; i++)
        {
            if(!table[i].Equals(default(KeyValuePair<K, V>)) && table[i].Key.Equals(key))
            {
                table[i] = new KeyValuePair<K, V>();
                this.size--;
                return true;
            }
        }
        return false;

    }
    public int Count
    {
        get{return this.size;}
    }
    public void Clear()
    {
        this.table = new KeyValuePair<K, V>[this.initialCapacity];
        this.size = 0;
    }
    public V this[K key]
    {
        get{return this.Find(key);}
        set{this.Add(key, value);}
    }
    private void Expand()
    {
        this.initialCapacity = this.initialCapacity * 2;
        this.threshold = (int)(initialCapacity * this.loadFactor);
        KeyValuePair<K, V>[] oldTable = this.table;
        this.table = new KeyValuePair<K, V>[initialCapacity];
        this.size = 0;
        foreach(KeyValuePair<K, V> target in oldTable)
        {
            if(!target.Equals(default(KeyValuePair<K, V>)))
            this.Add(target.Key, target.Value);
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<KeyValuePair<K, V>>)this).GetEnumerator();
    }

    IEnumerator<KeyValuePair<K, V>> IEnumerable<KeyValuePair<K, V>>.GetEnumerator()
    {
        foreach(var entry in this.table)
        {
            if(!entry.Equals(default(KeyValuePair<K, V>)))
            yield return entry;
        }
    }
}