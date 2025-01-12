class Ch10Q4
{
    static int k = 0;
    static string[] str = {"test", "rock", "fun"};
    static int n = str.Length;
    static void ans()
    {
        Console.Write("enter the k: ");
        k = int.Parse(Console.ReadLine());

        string[] arr = new string[k];

        Combo(arr, 0, 0);
    }

    static void Combo(string[] arr, int idx, int start)
    {
        if (idx == k)
        {
            PrintLoop(arr);
            return;
        }
        for (int i = start; i < n; i++)
        {
            arr[idx] = str[i];
            start = start + 1;
            Combo(arr, idx + 1, start);
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