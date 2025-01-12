// Implement a class BiDictionary<K1,K2,T>, which allows adding triplets 
// {key1, key2, value} and quickly search by either of the keys key1, 
// key2 as well as searching by combination of the both keys. Note: 
// Adding many elements with the same keys is allowed.

class Q4
{
    static void ans()
    {
        BiDictionary<string, char, int> test = new BiDictionary<string, char, int>();
        test.Add("test", 'i', 1);
        test.Add("test", 'j', 2);
        test.Add("test2", 'i', 3);
        test.Add("test2", 'i', 7);
        test.Add("test2", 'i', 8);
        test.Add("test2", 'j', 4);
        test.Add("test3", 'i', 5);
        test.Add("test3", 'j', 6);

        Console.Write("For key1 = \"test\": ");
        foreach(int i in test.Get("test"))
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.Write("For key1 = \"test2\": ");
        foreach(int i in test.Get("test2"))
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.Write("For key1 = \"test3\": ");
        foreach(int i in test.Get("test3"))
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.Write("For key2 = \'i\': ");
        foreach(int i in test.Get('i'))
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.Write("For key1 = \'j\': ");
        foreach(int i in test.Get('j'))
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.Write("For key1 = \"test2\" and key2 = \'i\': ");
        foreach(int i in test.Get("test2",'i'))
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

class BiDictionary<K1, K2, T>
{
    private Dictionary<K1, List<T>> KeyEle1;
    private Dictionary<K2, List<T>> KeyEle2;
    public BiDictionary()
    {
        this.KeyEle1 = new Dictionary<K1, List<T>>();
        this.KeyEle2 = new Dictionary<K2, List<T>>();
    }
    public void Add(K1 key1, K2 key2, T item)
    {
        List<T> list1;
        List<T> list2;
        if(!KeyEle1.TryGetValue(key1, out list1))
        {
            list1 = new List<T>();
            KeyEle1[key1] = list1;
        }
        list1.Add(item);
        if(!KeyEle2.TryGetValue(key2, out list2))
        {
            list2 = new List<T>();
            KeyEle2[key2] = list2;
        }
        list2.Add(item);
    }
    public List<T> Get(K1 key)
    {
        return KeyEle1[key];
    }
    public List<T> Get(K2 key)
    {
        return KeyEle2[key];
    }
    public List<T> Get(K1 key1, K2 key2)
    {
        List<T> list1 = KeyEle1[key1];
        List<T> list2 = KeyEle2[key2];
        List<T> combineList = new List<T>();
        foreach(T item in list1)
        {
            if(list2.Contains(item))
            {
                combineList.Add(item);
            }
        }
        return combineList;
    }
}