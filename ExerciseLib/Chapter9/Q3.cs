class Ch9Q3
{
    static void ans()
    {
        Console.Write("Enter a digit: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("The last digit is " + LastDigit(n));
    }

    static string LastDigit(int n)
    {
        string s = n.ToString();
        int len = s.Length;
        string lastd = null;

        switch (s[len - 1])
        {
            case '0': lastd = "zero"; break;
            case '1': lastd = "one"; break;
            case '2': lastd = "two"; break;
            case '3': lastd = "three"; break;
            case '4': lastd = "four"; break;
            case '5': lastd = "five"; break;
            case '6': lastd = "six"; break;
            case '7': lastd = "seven"; break;
            case '8': lastd = "eight"; break;
            case '9': lastd = "nine"; break;
            default: break;
        }
        return lastd;
    }

}
