class Q7
{
    static void ans()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hex = Console.ReadLine();

        int len = hex.Length; //length of the input hexa will be used to count the current power index
        int sum = 0;

        //nested loop is used for the computation
        //outer for loop (i) is used to keep track the current power index
        //inner for loop (j) is used to repeatedly self-multiply (to simulate power function)
        //length - 1 is the times of self-multiply required currently
        for (int i = 0; i < len; i++)
        {
            int hexDigit = 0;
            int hexBase = 1;
            //switch case is used to covert the hexa-digit into decimal digit
            switch (hex[i])
            {
                case '0': hexDigit = 0; break;
                case '1': hexDigit = 1; break;
                case '2': hexDigit = 2; break;
                case '3': hexDigit = 3; break;
                case '4': hexDigit = 4; break;
                case '5': hexDigit = 5; break;
                case '6': hexDigit = 6; break;
                case '7': hexDigit = 7; break;
                case '8': hexDigit = 8; break;
                case '9': hexDigit = 9; break;
                case 'A': hexDigit = 10; break;
                case 'B': hexDigit = 11; break;
                case 'C': hexDigit = 12; break;
                case 'D': hexDigit = 13; break;
                case 'E': hexDigit = 14; break;
                case 'F': hexDigit = 15; break;

            }
            //simulate the power function
            for (int j = i + 1; j < len; j++)
            {
                hexBase *= 16;
            }
            sum += hexDigit * hexBase;
        }

        Console.WriteLine("The decimal number: " + sum);
    }
}
