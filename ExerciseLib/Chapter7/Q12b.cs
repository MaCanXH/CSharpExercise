class Q12b
{
    static void ans()
    {
        Console.Write("Please enter size n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int count = 1;

        if (n % 2 == 0)
        {
            for (int i = 0; i < n - 1; i += 2)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[j, i] = count;
                    count++;
                }
                for (int j = n - 1; j >= 0; j--)
                {
                    matrix[j, i + 1] = count;
                    count++;
                }
            }
        }

        else
        {
            for (int i = 0; i < n - 2; i += 2)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[j, i] = count;
                    count++;
                }
                for (int j = n - 1; j >= 0; j--)
                {
                    matrix[j, i + 1] = count;
                    count++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                matrix[i, n - 1] = count;
                count++;
            }
        }

        Console.WriteLine("The matrix is");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,-4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}