class Q14
{
    static void ans()
    {
        Console.Write("Enter a decimal number: ");
        int N = int.Parse(Console.ReadLine());

        int quotient = N;
        int remainder;
        string hexa = null;

        while (quotient > 0)
        {
            remainder = quotient % 16;
            switch (remainder)
            {
                case 0: hexa = "0" + hexa; break;
                case 1: hexa = "1" + hexa; break;
                case 2: hexa = "2" + hexa; break;
                case 3: hexa = "3" + hexa; break;
                case 4: hexa = "4" + hexa; break;
                case 5: hexa = "5" + hexa; break;
                case 6: hexa = "6" + hexa; break;
                case 7: hexa = "7" + hexa; break;
                case 8: hexa = "8" + hexa; break;
                case 9: hexa = "9" + hexa; break;
                case 10: hexa = "A" + hexa; break;
                case 11: hexa = "B" + hexa; break;
                case 12: hexa = "C" + hexa; break;
                case 13: hexa = "D" + hexa; break;
                case 14: hexa = "E" + hexa; break;
                case 15: hexa = "F" + hexa; break;
                case 16: hexa = "H" + hexa; break;
            }
            quotient = quotient / 16;

        }
        if (N == 0)
        {
            Console.Write("The hexadecimal number is 0");
        }
        else
        {
            Console.Write("The hexadecimal number is " + hexa);
        }
    }
}