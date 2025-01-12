class Q15
{
    static void ans()
    {
        Console.Write("Enter a hexadecinmal number: ");
        string hexa = Console.ReadLine();

        int bas = 1; //base number
        int length = hexa.Length; //obtain the length of the input
        int deci = 0; //initialize the decimal number

        for (int i = length - 1; i >= 0; i--)
        {
            char c = hexa[i];
            switch (c)
            {
                case '0': deci = deci + 0 * bas; break;
                case '1': deci = deci + 1 * bas; break;
                case '2': deci = deci + 2 * bas; break;
                case '3': deci = deci + 3 * bas; break;
                case '4': deci = deci + 4 * bas; break;
                case '5': deci = deci + 5 * bas; break;
                case '6': deci = deci + 6 * bas; break;
                case '7': deci = deci + 7 * bas; break;
                case '8': deci = deci + 8 * bas; break;
                case '9': deci = deci + 9 * bas; break;
                case 'A': deci = deci + 10 * bas; break;
                case 'B': deci = deci + 11 * bas; break;
                case 'C': deci = deci + 12 * bas; break;
                case 'D': deci = deci + 13 * bas; break;
                case 'E': deci = deci + 14 * bas; break;
                case 'F': deci = deci + 15 * bas; break;
                default: break;
            }
            bas *= 16;
        }

        Console.WriteLine("The decimal number is " + deci);
    }
}