class Q9
{
    static void ans()
    {
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int tempSum = 0, maxSum = 0;
        int firstidx = 0, lastidx = 1;
        int len = arr.Length;

        for (int i = 0; i < len; i++)
        {
            tempSum = arr[i];
            for (int j = i + 1; j < len; j++)
            {
                tempSum += arr[j];
                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                    firstidx = i;
                    lastidx = j;
                }
            }
        }

        Console.WriteLine("The  subsequence of numbers with maximal sum are: ");
        for (int i = firstidx; i <= lastidx; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.Write("The maximal sum is " + maxSum);

    }
}