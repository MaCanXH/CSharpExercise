class Ch9Q9
{
    static void ans()
    {
        int[] arr = { 2, 13, 5, -1, 5, 19, 0, -4 };
        int len = arr.Length;

        Console.WriteLine("The array is ");
        for (int i = 0; i < len; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("The biggest element is " + BiggestEle(arr, 0));
        Console.WriteLine("The array in descending order is ");
        for (int i = 0; i < len; i++)
        {
            Console.Write(BiggestEle(arr, i) + " ");
        }
    }

    static int BiggestEle(int[] arr, int counter)
    {
        int len = arr.Length;
        int maxEle = arr[counter];
        int maxidx = counter;

        for (int i = counter; i < len; i++)
        {
            if (arr[i] > maxEle)
            {
                maxEle = arr[i];
                maxidx = i;
            }
        }

        int temp = arr[maxidx];
        arr[maxidx] = arr[counter];
        arr[counter] = temp;

        return maxEle;
    }
}
