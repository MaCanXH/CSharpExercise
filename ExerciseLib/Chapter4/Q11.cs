class Q11
{
    static void ans11()
    {
        int a = 0;
        int b = 1;
        int c;
        Console.WriteLine("The first 100 numbers in the Fibonacci sequence are: ");
        Console.Write("0, 1, ");
        for (int i = 2; i <= 100; i++)
        {
            c = a + b;
            Console.Write(c + ", ");
            a = b;
            b = c;
        }
    }
}
