class Q2
{
    static void ans()
    {
        long a = 1111010110011110;
        string n = a.ToString();
        int length = n.Length;
        int decSum = 0;

        for (int i = 0; i < length; i++)
        {
            int tempSum = 1;
            for (int j = i; j < length - 1; j++)
            {
                tempSum *= 2;
                //Console.WriteLine(tempSum);
            }

            tempSum = (n[i] - '0') * tempSum; //n[i] is a char, therefore minus 48 can return the correct value
            decSum += tempSum;
        }

        int hex = decSum;
        string hexSum = null;

        Console.WriteLine("{0} to decimal is {1}", a, decSum);

        while (hex != 0)
        {
            switch (hex % 16)
            {
                case 0: hexSum = "0" + hexSum; break;
                case 1: hexSum = "1" + hexSum; break;
                case 2: hexSum = "2" + hexSum; break;
                case 3: hexSum = "3" + hexSum; break;
                case 4: hexSum = "4" + hexSum; break;
                case 5: hexSum = "5" + hexSum; break;
                case 6: hexSum = "6" + hexSum; break;
                case 7: hexSum = "7" + hexSum; break;
                case 8: hexSum = "8" + hexSum; break;
                case 9: hexSum = "9" + hexSum; break;
                case 10: hexSum = "A" + hexSum; break;
                case 11: hexSum = "B" + hexSum; break;
                case 12: hexSum = "C" + hexSum; break;
                case 13: hexSum = "D" + hexSum; break;
                case 14: hexSum = "E" + hexSum; break;
                case 15: hexSum = "F" + hexSum; break;
                default:
                    break;
            }
            hex = hex / 16;
        }

        Console.WriteLine("{0} to hexadecimal is {1}", a, hexSum);
    }
}
