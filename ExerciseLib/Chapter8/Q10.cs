class Q10
{
    static void ans()
    {
        Console.Write("Enter a binary number: ");
        string bin = Console.ReadLine();

        int sum = 0;

        for (int i = 0, n = bin.Length; i < n; i++)
        {
            sum = sum * 2 + (bin[i] - '0');
        }

        Console.WriteLine("The decimal number: " + sum);
    }
}

//recursion method

/*Console.Write("Enter the binary number: ");
string bin = Console.ReadLine();
int len = bin.Length;
Console.WriteLine("The decimal number: " + Horner(bin, len - 1));

static int Horner(string s, int len)
{
    if (len == 0)
    {
        int dec = s[len] - '0';
        return dec;
    }
    int sum = Horner(s, len - 1) * 2 + (s[len] - '0');

    return sum;
}*/