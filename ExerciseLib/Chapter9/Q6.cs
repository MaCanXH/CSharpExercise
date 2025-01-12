class Ch9Q6
{
    static void ans()
    {
        int[] arr = { 1, 2, 2, 5, 6, 7, 9, 10, 11, 20, 20 };
        int len = arr.Length;
        Console.WriteLine("The array is ");
        for (int i = 0; i < len; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        Console.Write("The position of the first occurence is " + FirstOccur(arr, len));
    }

    static int FirstOccur(int[] arr, int len)
    {
        for (int i = 0; i < len; i++)
        {
            if (i == 0 && arr[i] > arr[i + 1])
            {
                return i;
            }
            else if (i == len - 1 && arr[i] > arr[i - 1])
            {
                return i;
            }
            else if (i > 0 && arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                return i;
            }
        }
        return -1;
    }
}
