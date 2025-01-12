class Q5
{
    // Q5. Implement a hash-table, maintaining triples (key1, key2, value) 
    // and allowing quick search by the pair of keys and adding of triples.
    static void ans()
    {
        Triple<string, int> test = new Triple<string, int>();
        test["n1", "n2"] = 1; // add a new elemnt
        test["n2", "n2"] = 2; // add a new elemnt
        test["n1", "n3"] = 3; // add a new elemnt with existing key1
        test["n1", "n2"] = 4; // replace the element

        Console.WriteLine(test["n1", "n2"]); // replaced result
        Console.WriteLine(test["n1", "n3"]); // exiting key1 result
    }
}

// <summary> Implementation of Triple with 2 keys </summary>
// <typeparam name = "K"> Type of keys. </typeparam>
// <typeparam name = "V"> Type of values. </typeparam>
class Triple<K, V>
{
    // use of hash-table of hash-table
    private Dictionary<K, Dictionary<K, V>> triple;
    
    // <summary> create a empty hash-table of hash-table</summary>
    public Triple()
    {
        this.triple = new Dictionary<K, Dictionary<K, V>>();
    }
    // <summary> Finds the value assigned to the given keys (key1 and key2)</summary>
    // <returns> the value found or null when not found </returns>
    public V Get(K key1, K key2)
    {
        // check if the triple contains key1
        if (this.triple.ContainsKey(key1))
        {
            // if contains key1 then check if contains key2
            if(this.triple[key1].ContainsKey(key2))
            {
                return triple[key1][key2];
            }
        }
        return default(V);
    }
    public void Set(K key1, K key2, V value)
    {
        // check if the triple contains key1
        if (this.triple.ContainsKey(key1))
        {
            // check if contains key2, 
            // if contains then replace the orginal value
            // if not, then add a new key2 and its value in the hash-table
            if( this.triple.ContainsKey(key2))
            {
                this.triple[key1][key2] = value;
            }
            else
            {
                this.triple[key1].Add(key2, value);
            }
        }
        // if triple not contains key1, create a new hash-table
        else
        {
            Dictionary<K, V> temp = new Dictionary<K, V>();
            temp.Add(key2, value);
            this.triple.Add(key1, temp);
        }
    }
    // <summary> Gets/ Sets the value by given keys. Get returns null when the 
    // key is not found. Set replaces teh existing value or creates a new 
    // hash-table/ key-vlaue pair if the key does not exist.</summary>
    public V this[K key1, K key2]
    {
        get{ return this.Get(key1, key2);}
        set{this.Set(key1, key2, value);}
    }
}