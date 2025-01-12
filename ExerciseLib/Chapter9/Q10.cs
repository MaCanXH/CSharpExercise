class Ch9Q10
{
    static void ans()
    {
        Console.Write("Please enter the number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}! is {1}", n, Factorial(n));
    }

    static double Factorial(double n)
    {
        if (n == 0)
        {
            return 1;
        }

        n = n * Factorial(n - 1);
        return n;
    }
}
