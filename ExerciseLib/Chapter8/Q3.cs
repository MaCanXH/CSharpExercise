class Q3
{
    static void ans()
    {
        //using variable string to store the hexadecimal number as string
        string a = "FA";
        string b = "2A3E";
        string c = "FFFF";
        string d = "5A0E9";

        int first = DecSys(a);
        int second = DecSys(b);
        int third = DecSys(c);
        int fourth = DecSys(d);

        Console.WriteLine("hexadecimal number {0} in decimal is : {1}", a, first);
        Console.WriteLine("hexadecimal number {0} in decimal is : {1}", b, second);
        Console.WriteLine("hexadecimal number {0} in decimal is : {1}", c, third);
        Console.WriteLine("hexadecimal number {0} in decimal is : {1}", d, fourth);

        Console.WriteLine("hexadecimal number {0} in binary is : {1}", a, BinSys(first));
        Console.WriteLine("hexadecimal number {0} in binary is : {1}", b, BinSys(second));
        Console.WriteLine("hexadecimal number {0} in binary is : {1}", c, BinSys(third));
        Console.WriteLine("hexadecimal number {0} in binary is : {1}", d, BinSys(fourth));
    }
    //DecSys is a function to convert hexadecimal number into decimal number
    static int DecSys(string hex)
    {
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
        return sum;
    }
    //BinSys is used to convert the decimal digit into binary number
    static string BinSys(int n)
    {
        //initialize a string array and ready to store the binary "string"
        string bin = null;
        //to include the 0 case
        if (n == 0)
        {
            bin = "0";
            return bin;
        }

        while (n > 0)
        {
            bin = (n % 2) + bin;

            n = n / 2;
        }
        return bin;
    }
}
