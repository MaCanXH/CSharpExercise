class Ch9Q7
{
    static void ans()
    {
        Console.Write("Please enter a decimal number: ");
        string dec = Console.ReadLine();
        Console.Write("The reversed number is ");
        Reverse(dec);
    }
    static void Reverse(string dec)
    {
        int len = dec.Length;

        for (int i = len - 1; i >= 0; i--)
        {
            Console.Write(dec[i]);
        }
    }
}