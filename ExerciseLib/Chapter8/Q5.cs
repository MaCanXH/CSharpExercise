class Q5
{
    static void ans()
    {
        Console.Write("Enter a binary number: ");
        string bin = Console.ReadLine();

        int sum = 0;

        for (int i = 0, len = bin.Length; i < len; i++)
        {
            int binBase = 1;
            for (int j = i; j < len - 1; j++)
            {
                binBase *= 2;
            }
            sum += (bin[i] - '0') * binBase;
        }

        Console.WriteLine("The decimal number: " + sum);

    }
}
