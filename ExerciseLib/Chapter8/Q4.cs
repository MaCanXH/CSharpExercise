class Q4
{
    static void ans()
    {
        Console.Write("Please enter a decimal number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("The number in binary system is ");

        Console.WriteLine(BinSystem(n));
    }

    static string BinSystem(int n)
    {
        string bin = null;
        if (n == 0)
        {
            bin = "0";
            return bin;
        }

        while (n != 0)
        {
            bin = (n % 2) + bin;

            n = n / 2;
        }
        return bin;
    }
}
