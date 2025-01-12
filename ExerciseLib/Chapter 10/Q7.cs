class Ch10Q7
{
    static void ans()
    {
        Console.Write("Enter a number n: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for(int i = 0; i < n; i++) arr[i] = i + 1;

        Permu(arr, 0, n - 1);
    }

    //in this method, the first iteration will first the first number in each turn
    //(the swapping in the first iteration is swapping with itself)
    //then swap the fixed index (start) with the next index in the for loop
    //after the iteration, the indexes swap back to the original place
    static void Permu(int[] arr, int start, int end)
    {
        if(start == end)
        {
            PrintArray(arr);
        }
        else
        {
            for(int i = start; i <= end; i++)
            {
                Swap(arr, start, i); //swapping the fixed index with next index, first time is self swap
                Permu(arr, start + 1, end); //call recursively, to the next index
                Swap(arr, start, i); //swap back to the original place
            }
        }
    }
    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    static void PrintArray(int[] arr)
    {
        for (int i = 0;i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}