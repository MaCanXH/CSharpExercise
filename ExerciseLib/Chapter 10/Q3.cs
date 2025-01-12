class Ch10Q3
{
    static int n = 0;
    static int k = 0;
    static void ans()
    {
        Console.Write("enter the number n for n nested loop: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("enter the k for the number of class: ");
        k = int.Parse(Console.ReadLine());

        int[] arr = new int[k];

        Combo(arr, 0, 1);
    }

    static void Combo(int[] arr, int idx, int start)
    {
        if (idx == k)
        {
            PrintLoop(arr);
            return;
        }
        for (int i = start; i <= n; i++)
        {
            arr[idx] = i;
            Combo(arr, idx + 1, i);
        }
    }

    static void PrintLoop(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine();
    }
}