class Q7
{
    static void ans()
    {
        Console.Write("Please enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please enter K: ");
        int K = int.Parse(Console.ReadLine());

        int[] arr = new int[N];
        int start = 0;
        int max = 0;
        int sum = 0;

        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter element [{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N - K; i++)
        {
            for (int j = 0; j < K; j++)
            {
                sum += arr[i + j];
            }
            if (sum > max)
            {
                max = sum;
                start = i;
            }
            sum = 0;
        }

        Console.WriteLine("The elements are :");
        for (int i = start; i < start + K; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("The maximal sum is " + max);
    }
}