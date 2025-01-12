class Q9
{
    static void ans()
    {
        Console.Write("enter n: ");
        long n = long.Parse(Console.ReadLine());
        Console.Write("enter x: ");
        long x = long.Parse(Console.ReadLine());

        long numer = 1;
        long denom = 1;
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            numer *= i;
            //Console.WriteLine("numer = "+numer);
            denom *= x;
            //Console.WriteLine("denom = "+denom);
            sum += (double)numer / denom;
            //Console.WriteLine("sum = "+ sum);

        }
        Console.Write("the sum of 1 + 1!/x + 2!/x^2 + ... + n!/x^n = " + sum);
    }
}