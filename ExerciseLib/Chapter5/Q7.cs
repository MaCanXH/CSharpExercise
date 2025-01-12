class Q7
{
    static void ans7()
    {
        int a = 51;
        int b = 6;
        int c = 7;
        int d = 8;
        int e = -9;

        int greatest = a;

        Console.WriteLine("The five numbers are {0}, {1}, {2}, {3}, " +
            "{4}", a, b, c, d, e);

        if (greatest < b)
        {
            greatest = b;
        }
        if (greatest < c)
        {
            greatest = c;
        }
        if (greatest < d)
        {
            greatest = d;
        }
        if (greatest < e)
        {
            greatest = e;
        }
        Console.WriteLine("the greatest number is " + greatest);
    }
}