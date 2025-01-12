class Ch8Q12
{
    static void ans()
    {
        int arb = -1;
        while (arb < 0 || arb >= 4000)
        {
            Console.Write("Enter an arabic number: ");
            arb = int.Parse(Console.ReadLine());
        }

        int remainder = 0;
        string roma = null;

        switch (arb / 1000)
        {
            case 0: break;
            case 1: roma = roma + "M"; break;
            case 2: roma = roma + "MM"; break;
            case 3: roma = roma + "MMM"; break;
            default: break;
        }

        arb = arb % 1000;

        switch (arb / 100)
        {
            case 0: break;
            case 1: roma = roma + "C"; break;
            case 2: roma = roma + "CC"; break;
            case 3: roma = roma + "CCC"; break;
            case 4: roma = roma + "CD"; break;
            case 5: roma = roma + "D"; break;
            case 6: roma = roma + "DC"; break;
            case 7: roma = roma + "DCC"; break;
            case 8: roma = roma + "DCCC"; break;
            case 9: roma = roma + "CM"; break;
            default: break;
        }

        arb = arb % 100;

        switch (arb / 10)
        {
            case 0: break;
            case 1: roma = roma + "X"; break;
            case 2: roma = roma + "XX"; break;
            case 3: roma = roma + "XXX"; break;
            case 4: roma = roma + "XL"; break;
            case 5: roma = roma + "L"; break;
            case 6: roma = roma + "LX"; break;
            case 7: roma = roma + "LXX"; break;
            case 8: roma = roma + "LXXX"; break;
            case 9: roma = roma + "XC"; break;
            default: break;
        }

        arb = arb % 10;

        switch (arb)
        {
            case 0: break;
            case 1: roma = roma + "I"; break;
            case 2: roma = roma + "II"; break;
            case 3: roma = roma + "III"; break;
            case 4: roma = roma + "IV"; break;
            case 5: roma = roma + "V"; break;
            case 6: roma = roma + "VI"; break;
            case 7: roma = roma + "VII"; break;
            case 8: roma = roma + "VIII"; break;
            case 9: roma = roma + "IX"; break;
            default: break;
        }

        Console.WriteLine("The Roman number: " + roma);
    }
}
