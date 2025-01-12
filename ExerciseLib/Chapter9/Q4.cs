class Ch9Q4
{
    static void ans()
    {
        int[] arr = { 1, 1, 1, 5, 5, 8, 4, 9, 5, 4, 1 };
        int len = arr.Length;
        Console.WriteLine("The array is ");
        for (int i = 0; i < len; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Enter the number n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("The number {0} appears in the array {1} times.", n, FindNum(arr, len, n));
    }

    static int FindNum(int[] arr, int len, int n)
    {
        int count = 0;
        for (int i = 0; i < len; i++)
        {
            if (arr[i] == n)
            {
                count++;
            }
        }
        return count;
    }
}
