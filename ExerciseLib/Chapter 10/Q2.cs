class Ch10Q2
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

        Variation(arr, 0);
    }

    static void Variation(int[] arr, int counter)
    {
        if (counter == k)
        {
            PrintLoop(arr);
            return;
        }
        for (int i = 0; i < n; i++)
        {
            arr[counter] = i + 1;
            Variation(arr, counter + 1);
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