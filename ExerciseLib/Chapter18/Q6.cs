using System.Collections;

class Q6
{
    // Q6. Implement a hash-table, allowing the maintenance of more 
    // than one value for a specific key.
    static void ans()
    {
        HashTableList<string, int> test = new HashTableList<string, int>();
        test.Add("n1", 1);
        test.Add("n1", 2);
        test.Add("n2", 3);
        test.Add("n3", 4);
        test.Add("n4", 5);
        Console.WriteLine(test.ContainsKey("n1"));
        Console.WriteLine(test.ContainsKey("n5"));
        Console.WriteLine(test.ContainsValue(3));
        Console.WriteLine(test.ContainsValue(6));
        Console.WriteLine(test.Count);
        test.Remove("n1");
        Console.WriteLine(test.Count);
        test.Clear();
        Console.WriteLine(test.Count);

    }
}
// <summary> implementation of Hash-table with Key-List Pair to maintain more
// than one value for a specific key. </summary>
class HashTableList<K, V>
{
    private Dictionary<K, List<V>> HashList;
    // <summary> create an empty hash-table with list. </summary>
    public HashTableList()
    {
        this.HashList = new Dictionary<K, List<V>>();
    }
    // <summary> Add function to add new keys and values </summary>
    public void Add(K key, V value)
    {
        // if there an existing list for a specific key, add the value in the list
        // else create a new list for the key and add a new value
        if(this.HashList.ContainsKey(key))
        {
            HashList[key].Add(value);
        }
        else
        {
            HashList[key] = new List<V>();
            HashList[key].Add(value);
        }
    }
    // <summary> remove the key from the Hash-table </summary>
    // <returns> true if key is found and removed, false if not found </returns>
    public bool Remove(K key)
    {
        if(this.HashList.ContainsKey(key))
        {
            this.HashList[key] = new List<V>();
            return true;
        }
        return false;
    }
    // <summary> clear the Hash-table </summary>
    public void Clear()
    {
        // create an empty dictionary and replace the existing one.
        this.HashList = new Dictionary<K, List<V>>();
    }
    // <summary> check if the Hash-table contains the input key </summary>
    // <returns> true if key is found, false if not found </returns>
    public bool ContainsKey(K key)
    {
        if (this.HashList.ContainsKey(key))
        {
            return true;
        }
        return false;
    }
    // <summary> check if the hash-table contains the input value </summary>
    // <returns> true if the value found, false if not found </returns>
    public bool ContainsValue(V value)
    {
        // iterate through the whole hash-table
        // then for each Key-List pair, iterate through the whole list
        // to compare each value in the list with the input value
        foreach(var KeyListPair in HashList)
        {
            // simplier iteration implementation
            if(KeyListPair.Value.Contains(value))
            {
                return true;
            }

            // actual iteration behind
            // for(int i = 0; i < KeyListPair.Value.Count; i++)
            // {
            //     if(KeyListPair.Value[i].Equals(value))
            //     {
            //         return true;
            //     }
            // }
        }
        return false;
    }
    // <summary> return the size of the hash-table </summary>
    public int Count
    {
        get
        {
            int count = 0;
            foreach(var ListSize in this.HashList)
            {
                count += ListSize.Value.Count;
            }
            return count;
        }
    }
}