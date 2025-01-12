using System.Collections;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

class Q7
{
    // Q7. Implement a hash-table, using "cuckoo hashing" with 3 hash-functions.
    // answer for reference type remain to be solves
    static void ans()
    {
        CuckooHashTable<int, int> test = new CuckooHashTable<int, int>(3, 0.75f);
        test[1] = 1;
        test[2] = 2;
        test[3] = 3;
        test[4] = 4;
        test[4] = 7;

        Console.WriteLine(test[4]);
        Console.WriteLine(test.Count);
        test.Remove(3);
        Console.WriteLine(test[3]);
        Console.WriteLine(test.Count);
    }
}
class CuckooHashTable<K, V>
{
    private const int DEFAULT_CAPACITY = 16;
    private const float DEFAULT_LOAD_FACTOR = 0.75f;
    private int ver = 3;
    private KeyValuePair<K, V>[] table;
    private float loadFactor;
    private int threshold;
    private int size;
    private int initialCapacity;
    private KeyValuePair<K, V> [,] cuckootable;
    private int[] pos;
    public CuckooHashTable():this(DEFAULT_CAPACITY, DEFAULT_CAPACITY){}
    public CuckooHashTable(int capcity, float loadFactor)
    {
        this.initialCapacity = capcity;
        this.table = new KeyValuePair<K, V>[capcity];
        this.loadFactor = loadFactor;
        this.threshold = (int)(capcity * loadFactor);
        this.cuckootable = new KeyValuePair<K, V>[this.ver, capcity];
        this.pos = new int[this.ver];
    }
    /* return hashed value for a key
    * function: ID of hash function 
    according to which key has to hashed
    * key: item to be hashed */
    private int hashFunction(K key, int function)
    {
        switch(function)
        {
            case 1: return Math.Abs(key.GetHashCode()) % table.Length;
            case 2: return Math.Abs((key.GetHashCode()) * 83 + 7) % table.Length;
            case 3: return (key.GetHashCode() * key.GetHashCode() + 19) % table.Length;
            default: return int.MinValue; 
        }
    }
    /* function to place a key in one of 
    its possible positions
    * tableID: table in which key 
    has to be placed, also equal to function
    according to which key must be hashed
    * count: number of times function has already 
    been called in order to place the first input key
    * cap: maximum number of times function 
    can be recursively called before stopping and
    declaring presence of cycle */
    public void place(KeyValuePair<K, V> Ele, int tableID, int count, int cap)
    {
        /* if function has been recursively 
        called max number of times,
        stop and declare cycle. Rehash. */
        if(count == cap)
        {
            Console.WriteLine("{0} unpositioned", Ele.Key);
            Console.WriteLine("Cycle present. Rehash.");
            return;
        }
        /* calculate and store possible positions 
        * for the key. Check if key already present 
        at any of the positions. If YES, return. */
        for (int i = 0; i < this.ver; i++)
        {
            pos[i] = hashFunction(Ele.Key, i + 1);

            if (cuckootable[i, pos[i]].Key.Equals(Ele.Key))
            {
                return;
            }

        }
        /* check if another key is already present 
        at the position for the new key in the table
        * If YES: place the new key in its position
        * and place the older key in an alternate position
        for it in the next table */
        if (!cuckootable[tableID, pos[tableID]].Equals(default(KeyValuePair)))
        {
            KeyValuePair<K, V> dis = cuckootable[tableID, pos[tableID]];
            cuckootable[tableID, pos[tableID]] = Ele;
            this.place(dis, (tableID + 1) % ver, count + 1, cap);
        }
        else
        {
            cuckootable[tableID, pos[tableID]] = Ele;
        }
    }
    /* function to combine the cuckoo table into hash table if theres value */
    private void Finaltable(KeyValuePair<K, V>[] table, KeyValuePair<K, V>[,] cuckootable)
    {
        for (int i = 0; i < cuckootable.GetLength(0); i++)
        {
            for (int j = 0; j < cuckootable.GetLength(1); j++)
            {
                if(!cuckootable[i,j].Equals(default(KeyValuePair<K, V>)))
                {
                    table[j] = cuckootable[i,j];
                }
            }
        }
    }
    public V Get(K key) 
    { 
        foreach (KeyValuePair<K, V> target in table)
        {
            if(target.Key.Equals(key))
            {
                return target.Value;
            }
        }
        return default(V); 
    }
    public void Set(K key, V value)
    {
        // check and replace the key value pair if the key exist in the hash table
        KeyValuePair<K, V> add = new KeyValuePair<K, V>(key, value);
        for(int i = 0; i < this.table.Length; i++)
        {
            if(this.table[i].Key.Equals(key))
            {
                this.table[i] = add;
                return;
            }
        }
        if (this.size >= this.threshold)
        {
            this.Expand();
        }
        place(add, 0, 0, table.Length);
        Finaltable(this.table, this.cuckootable);
        this.size++;
    }
    public V this[K key]
    {
        get{return this.Get(key);}
        set{this.Set(key, value);}
    }
    public void Remove(K key)
    {
        for (int i = 0; i < table.Length; i++)
        {
            if(table[i].Key.Equals(key))
            {
                table[i] = default(KeyValuePair<K, V>);
            }
        }
        this.size--;
    }
    public int Count
    {
        get{return this.size;}
    }
    private void Expand()
    {
        this.initialCapacity = this.initialCapacity * 2;
        this.threshold = (int)(this.initialCapacity * this.loadFactor);
        KeyValuePair<K, V>[] oldTable = table;
        this.table = new KeyValuePair<K, V>[initialCapacity];
        this.cuckootable = new KeyValuePair<K, V>[this.ver, initialCapacity];
        foreach(KeyValuePair<K, V> value in oldTable)
        {
            place(value, 0, 0, table.Length);
        }
    }
}