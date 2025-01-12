using System.Collections;
public interface IDictionary<K, V> :
IEnumerable<KeyValuePair<K, V>>
{
    ///<summary>Finds the value mapped to the given key</summary>
    /// <param name="key">the key to be searched</param>
    /// <returns>value for the specified key if it presents,
    /// or null if there is no value with such key</returns>
    V Get(K key);
    /// <summary>Assigns the specified value to the specified key
    /// in the dictionary. If the key already exists, its value is
    /// replaced with the new value and the old value is returned
    /// </summary>
    /// <param name="key">Key for the new value</param>
    /// <param name="value">Value to be mapped to that key</param>
    /// <returns>the old (replaced) value for the specified key
    /// or null if the key does not exist</returns>
    V Set(K key, V value);
    /// <summary>Gets or sets the value of the entry in the
    /// dictionary identified by the key specified</summary>
    /// <remarks>A new entry will be created if the value is set
    /// for a key not currently in the dictionary</remarks>
    /// <param name="key">the key to identify the entry</param>
    /// <returns>the value of the entry in the dictionary
    /// identified by the provided key</returns>
    V this[K key] { get; set; }
    /// <summary>Removes an element in the dictionary identified
    /// by a specified key</summary>
    /// <param name="key">the key identifying the element to be
    /// removed</param>
    /// <returns>whether the element was removed or not</returns>
    bool Remove(K key);
    /// <summary>Returns the number of entries in the dictionary
    /// </summary>
    int Count { get; }
    /// <summary>Removes all the elements from the dictionary
    /// </summary>
    void Clear();
}

public class HashDictionary<K, V> : IDictionary<K, V>, IEnumerable<KeyValuePair<K, V>>
{
    private const int DEFAULT_CAPACITY = 16; 
    private const float DEFAULT_LOAD_FACTOR = 0.75f; 
    private List<KeyValuePair<K, V>>[] table; 
    private float loadFactor; private int threshold; 
    private int size; private int initialCapacity;
/// <summary>Creates an empty hash table with the 
/// default capacity and load factor</summary> 
    public HashDictionary() : this(DEFAULT_CAPACITY, DEFAULT_LOAD_FACTOR) { }
/// <summary>Creates an empty hash table with given 
/// capacity and load factor</summary> 
    public HashDictionary(int capacity, float loadFactor) 
    { 
        this.initialCapacity = capacity; 
        this.table = new List<KeyValuePair<K, V>>[capacity]; 
        this.loadFactor = loadFactor; 
        this.threshold = (int)(capacity * this.loadFactor); 
    }
    private List<KeyValuePair<K, V>> FindChain( K key, bool createIfMissing) 
    { 
        int index = key.GetHashCode(); 
        index = index & 0x7FFFFFFF; // clear the negative bit
        index = index % this.table.Length; 
        if (this.table[index] == null && createIfMissing) 
        { 
            this.table[index] = new List<KeyValuePair<K, V>>(); 
        } return this.table[index] as List<KeyValuePair<K, V>>; 
    }
    public V Get(K key) 
    { 
        List<KeyValuePair<K, V>> chain = this.FindChain(key, false); 
        if (chain != null) 
        { 
            foreach (KeyValuePair<K, V> entry in chain) 
            { 
                if (entry.Key.Equals(key)) 
                { 
                    return entry.Value; 
                } 
            } 
        }
        return default(V); 
    }
    public V Set(K key, V value) 
    { 
        if (this.size >= this.threshold) 
        { 
            this.Expand();
        }
        List<KeyValuePair<K, V>> chain = this.FindChain(key, true); 
        for (int i = 0; i < chain.Count; i++) 
        {
             KeyValuePair<K, V> entry = chain[i]; 
            if (entry.Key.Equals(key)) 
            { // Key found -> replace its value with the new value 
                KeyValuePair<K, V> newEntry = new KeyValuePair<K, V>(key, value); 
                chain[i] = newEntry; return entry.Value; 
            } 
        } 
        chain.Add(new KeyValuePair<K, V>(key, value)); 
        this.size++;
        return default(V); 
    }
    public V this[K key] 
    {
        get { return this.Get(key); } 
        set { this.Set(key, value); } 
    }
    public bool Remove(K key) 
    { 
        List<KeyValuePair<K, V>> chain = this.FindChain(key, false);
        if (chain != null) 
        { 
            for (int i = 0; i < chain.Count; i++) 
            { 
                KeyValuePair<K, V> entry = chain[i]; 
                if (entry.Key.Equals(key)) 
                { // Key found -> remove it 
                    chain.RemoveAt(i); 
                    this.size--; 
                    return true; 
                } 
            } 
        } return false; 
    }
/// <summary>Returns the number of key-value pairs /// in the hash table (its size)</summary> 
    public int Count 
    { 
        get { return this.size; } 
    }
/// <summary>Clears all ements of the hash table</summary> 
    public void Clear() 
    { 
        this.table = new List<KeyValuePair<K, V>>[this.initialCapacity]; 
        this.size = 0; 
    }
    private void Expand() 
    { 
        int newCapacity = 2 * this.table.Length; 
        List<KeyValuePair<K, V>>[] oldTable = this.table; 
        this.table = new List<KeyValuePair<K, V>>[newCapacity];
        this.threshold = (int)(newCapacity * this.loadFactor); 
        foreach (List<KeyValuePair<K, V>> oldChain in oldTable) 
        { 
            if (oldChain != null) 
            { 
                foreach (KeyValuePair<K, V> keyValuePair in oldChain) 
                { 
                    List<KeyValuePair<K, V>> chain = FindChain(keyValuePair.Key, true); 
                    chain.Add(keyValuePair); 
                } 
            } 
        } 
    }
    /// <summary>Implements the IEnumerable<KeyValuePair<K, V>> 
    /// to allow iterating over the key-value pairs in the hash 
    /// table in foreach-loops</summary>
    IEnumerator<KeyValuePair<K, V>> IEnumerable<KeyValuePair<K, V>>.GetEnumerator()
    { 
        foreach (List<KeyValuePair<K, V>> chain in this.table) 
        { 
            if (chain != null) 
            { 
                foreach (KeyValuePair<K, V> entry in chain) 
                { 
                    yield return entry; 
                } 
            } 
        } 
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<KeyValuePair<K, V>>)this). GetEnumerator();
    }
}