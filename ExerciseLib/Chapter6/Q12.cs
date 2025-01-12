class Q12
{
    static void ans()
    {
        Console.Write("Enter a decinmal number: ");
        int N = int.Parse(Console.ReadLine());

        int quotient = N;
        int remainder;
        string binary = null;

        while (quotient != 0)
        {
            remainder = quotient % 2;
            quotient = quotient / 2;

            binary = remainder + binary;
        }

        Console.Write("The binary number is " + binary);
    }
}