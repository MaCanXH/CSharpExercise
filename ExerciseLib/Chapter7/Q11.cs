class Q11
{
    static void ans()
    {
        int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        Console.Write("enter s: ");
        int s = int.Parse(Console.ReadLine());
        int index = 0, lastIndex = 1, sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum = arr[i];
            for (int j = i + 1; j < arr.Length; j++)
            {
                sum += arr[j];
                if (sum == s)
                {
                    index = i;
                    lastIndex = j;
                    break;
                }
            }
        }
        Console.WriteLine("the sequence of neighboring number is ");
        for (int i = index; i <= lastIndex; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}