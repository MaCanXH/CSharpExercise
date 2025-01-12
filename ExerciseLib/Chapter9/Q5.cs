class Ch9Q5
{
    static void ans()
    {
        int[] arr = { 12, 15, 0, -5, 16, 5, 6, 20, -1, -20, 9 };
        int len = arr.Length;
        Console.WriteLine("The array is ");
        for (int i = 0; i < len; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("The elements greater than the neighbor are");
        GreaterNei(arr, len);
    }

    static void GreaterNei(int[] arr, int len)
    {
        int[] temp = new int[len];
        int count = 0;
        for (int i = 0; i < len; i++)
        {
            if (i == 0 && arr[i] > arr[i + 1])
            {
                temp[count] = arr[i];
                count++;
            }
            else if (i == len - 1 && arr[i] > arr[i - 1])
            {
                temp[count] = arr[i];
                count++;
            }
            else if (i > 0 && i < len - 1 && arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                temp[count] = arr[i];
                count++;
            }
        }
        for (int j = 0; j < count; j++)
        {
            Console.Write(temp[j] + " ");
        }
    }
}
