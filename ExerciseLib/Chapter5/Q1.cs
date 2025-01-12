class Q1
{
    static void ans1()
    {
        int a = 21;
        int b = 20;
        int c;

        Console.WriteLine("Before: a = " + a + ", b = " + b);

        if (a > b)
        {
            c = a;
            a = b;
            b = c;
        }
        Console.WriteLine("After: a = " + a + ", b = " + b);
    }
}