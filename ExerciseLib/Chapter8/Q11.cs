class Q11
{
    static void ans()
    {
        Console.Write("Enter a Roman number: ");
        string roma = Console.ReadLine();

        int[] arr = new int[roma.Length];

        for (int i = 0, n = roma.Length; i < n; i++)
        {
            switch (roma[i])
            {
                case 'I': arr[i] = 1; break;
                case 'V': arr[i] = 5; break;
                case 'X': arr[i] = 10; break;
                case 'L': arr[i] = 50; break;
                case 'C': arr[i] = 100; break;
                case 'D': arr[i] = 500; break;
                case 'M': arr[i] = 1000; break;
                default: break;
            }
        }
        //front adding approach
        int sum = arr[0];

        for (int i = 0, n = arr.Length; i < n - 1; i++)
        {
            if (arr[i] >= arr[i + 1])
            {
                sum += arr[i + 1];
            }
            else
            {
                sum = sum - arr[i] * 2 + arr[i + 1];
            }
        }

        // or end adding approach

/*        int sum = 0;

        for (int i = 0, n = arr.Length; i < n - 1; i++)
        {
            if (arr[i] >= arr[i + 1])
            {
                sum += arr[i];
            }
            else
            {
                sum -= arr[i];
            }
        }
        sum = sum + arr[arr.Length - 1];*/

        Console.WriteLine("The arabic number: " + sum);
    }
}
