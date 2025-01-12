class Q6
{
    static void ans()
    {
        Console.Write("enter number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("enter number K ");
        int k = int.Parse(Console.ReadLine());


        int result = n;
        // N! / K! = N * (N - 1) * (N - 2) * ... * (K + 1)

        for (int i = n; i > (k + 1); i--)
        {
            result = result * (i - 1);
        }

        if (n == k)
        {
            result = 1;
        }

        Console.WriteLine("N! / K! = " + result);
    }
}