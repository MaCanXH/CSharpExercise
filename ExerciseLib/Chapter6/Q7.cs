class Q7
{
    static void ans()
    {
        Console.Write("enter N: ");
        long N = long.Parse(Console.ReadLine());
        Console.Write("enter K: ");
        long K = long.Parse(Console.ReadLine());

        long n = 1;
        long k = 1;
        long l = 1;

        for (int i = 1; i <= N; i++)
        {
            n *= i;
        }
        for (int i = 1; i <= K; i++)
        {
            k *= i;
        }
        for (int i = 1; i <= (N - K); i++)
        {
            l *= i;
        }

        Console.WriteLine("N! * K!/(N-K)! = " + n * k / l);
    }
}