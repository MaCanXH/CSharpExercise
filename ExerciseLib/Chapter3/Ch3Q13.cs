class Q13
{
    public static void ans13()
    {
        int n = 35;
        int v = 1;
        int p = 2;

        int bit = v << p;

        n = n & (~bit);
        n = n | bit;

        Console.WriteLine(n);
    }
}

