class Q11
{
    static void ans()
    {

        Console.Write("Enter the number N: ");
        int N = int.Parse(Console.ReadLine());

        long result = 1;
        long checker;
        int zeroCount = 0;

        for (int i = 1; i <= N; i++)
        {
            result *= i;
        }
        checker = result;

        while ((checker % 10) == 0)
        {
            zeroCount++;
            checker /= 10;
        }

        Console.WriteLine("N = {0} -> {0}! = {1} -> {2}", N, result, zeroCount);
    }
}