class Q19
{
    //recursion was applied in this problem
    static void ans()
    {
        Console.Write("1 2 ");

        for (long i = 3; i <= 1000; i++)//10,000,000 long runtime
        {
            bool prime = true;

            for (int j = 2; j < Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime) { Console.Write("{0,10}", i); }
        }
    }
}
