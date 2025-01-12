class Q11
{
    static void ans11()
    {
        int digit1;
        int digit2;
        int digit3;

        string text1 = "";
        string text2 = "";
        string text3 = "";

        Console.WriteLine("Please enter your number [0…999]");
        int x = int.Parse(Console.ReadLine());

        //store the numbers in the variables on different digits
        digit1 = x % 10;
        digit2 = x / 10 % 10;
        digit3 = x / 100;

        switch (digit3)
        {
            case 0: text3 = ""; break;
            case 1: text3 = "One hundred"; break;
            case 2: text3 = "Two hundred"; break;
            case 3: text3 = "Three hundred"; break;
            case 4: text3 = "Four hundred"; break;
            case 5: text3 = "Five hundred"; break;
            case 6: text3 = "Six hundred"; break;
            case 7: text3 = "Seven hundred"; break;
            case 8: text3 = "Eight hundred"; break;
            case 9: text3 = "Nine hundred"; break;
        }
        switch (digit1)
        {
            case 0: text1 = "Zero"; break;
            case 1: text1 = "One"; break;
            case 2: text1 = "Two"; break;
            case 3: text1 = "Three"; break;
            case 4: text1 = "Four"; break;
            case 5: text1 = "Five"; break;
            case 6: text1 = "Six"; break;
            case 7: text1 = "Seven"; break;
            case 8: text1 = "Eight"; break;
            case 9: text1 = "Nine"; break;
        }

        if (digit2 == 1)
        {
            switch (digit1)
            {
                case 0: text2 = "Ten"; break;
                case 1: text2 = "Eleven"; break;
                case 2: text2 = "Twelve"; break;
                case 3: text2 = "Thirteen"; break;
                case 4: text2 = "Fourteen"; break;
                case 5: text2 = "Fifteen"; break;
                case 6: text2 = "Sixteen"; break;
                case 7: text2 = "Seventeen"; break;
                case 8: text2 = "Eighteen"; break;
                case 9: text2 = "Nineteen"; break;
            }
        }
        else
        {
            switch (digit2)
            {
                case 0: text2 = ""; break;
                case 2: text2 = "Twenty"; break;
                case 3: text2 = "Thirty"; break;
                case 4: text2 = "Fourty"; break;
                case 5: text2 = "Fifty"; break;
                case 6: text2 = "Sixty"; break;
                case 7: text2 = "Seventy"; break;
                case 8: text2 = "Eighty"; break;
                case 9: text2 = "Ninety"; break;
            }
        }

        if (digit3 != 0 && digit2 == 1) { Console.WriteLine(text3 + " and " + text2); }
        else if (digit3 != 0 && digit2 == 0 && digit1 != 0) { Console.WriteLine(text3 + " and " + text1); }
        else if (digit3 != 0 && digit2 == 0 && digit1 == 0) { Console.WriteLine(text3); }
        else if (digit3 != 0 && digit2 != 0 && digit1 == 0) { Console.WriteLine(text3 + " and " + text2); }
        else if (digit3 == 0 && digit2 == 1) { Console.WriteLine(text2); }
        else if (digit3 == 0 && digit2 != 0 && digit1 == 0) { Console.WriteLine(text2); }
        else if (digit3 == 0 && digit2 != 0 && digit2 != 1 && digit1 != 0) { Console.WriteLine(text2 + " " + text1); }
        else { Console.WriteLine(text3 + " " + text2 + " " + text1); }

    }
}