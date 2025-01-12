class Q10
{
    static void ans()
    {

        Console.Write("enter N (N < 20): ");
        int N = int.Parse(Console.ReadLine());

        //normal matrix

        /*for (int i = 1; i <= (N * N); i++)
        {
            Console.Write(i + " ");
            if ((i % N) == 0)
            {
                Console.WriteLine();
            }
        }
        */

        //method 1

        for (int row = 0; row < N; row++)
        {
            for (int col = 1; col <= N; col++)
            {
                Console.Write(col + row + " ");

            }
            Console.WriteLine();
        }

        Console.WriteLine();

        //method 2

        for (int row = 1; row <= N; row++)
        {
            for (int col = row; col <= (row + N - 1); col++)
            {
                Console.Write(col + " ");

            }
            Console.WriteLine();
        }

    }
}