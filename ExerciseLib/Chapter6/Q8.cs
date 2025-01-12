class Q8
{
    static void ans()
    {
        Console.Write("enter n: ");
        long n = long.Parse(Console.ReadLine());

        long a = 1;
        long b = 1;
        long c = 1;

        for (int i = 1; i <= (2 * n); i++)
        {
            a *= i;
        }
        for (int i = 1; i <= (n + 1); i++)
        {
            b *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            c *= i;
        }

        Console.WriteLine("the nth Catalan number = " + a / (b * c));
    }
}