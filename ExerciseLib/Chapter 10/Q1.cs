class Ch10Q1
{
    static int n = 0;
    static void ans()
    {
        Console.Write("enter the number n for n nested loop: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        NestedLoop(arr, 0);
    }

    static void NestedLoop(int[] arr, int counter)
    {
        if (counter == n)
        {
            PrintLoop(arr);
            return;
        }
        for(int i = 0; i < n; i++)
        {
            arr[counter] = i + 1;
            NestedLoop(arr, counter + 1);
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