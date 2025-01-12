class Ch10Q5
{
    static string[] str = {"test", "rock", "fun"};
    static int n = str.Length;
    static void ans()
    {
        Console.WriteLine("all subsets of a given set of N words is");
        int k = str.Length;

        string[] arr = new string[k];

        subset(arr, k);
    }
    static void subset(string[] arr, int len)
    {
        if (len == 0) return;

        subset(arr, len - 1);
        Combo(arr, 0, 0, len);
    }
    static void Combo(string[] arr, int idx, int start, int len)
    {
        if (idx == len)
        {
            PrintLoop(arr);
            return;
        }
        for (int i = start; i < n; i++)
        {
            arr[idx] = str[i];
            start = start + 1;
            Combo(arr, idx + 1, start, len);
        }
    }

    static void PrintLoop(string[] arr)
    {
        foreach (string element in arr)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine();
    }
}