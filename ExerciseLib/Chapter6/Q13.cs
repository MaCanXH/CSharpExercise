class Q13
{
    static void ans()
    {
        Console.Write("Enter a binary number: ");
        int N = int.Parse(Console.ReadLine());

        int quotient = N;
        int remainder;
        int sum = 0;
        int bas = 1; //base

        while (quotient > 0)
        {
            remainder = quotient % 10;
            sum = sum + remainder * bas;
            bas *= 2;
            quotient = quotient / 10;

        }

        Console.Write("The binary number is " + sum);
    }
}