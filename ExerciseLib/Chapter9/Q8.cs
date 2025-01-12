class Ch9Q8
{
    static void ans()
    {
        Console.Write("Please enter the first positive integer: ");
        string a = Console.ReadLine();
        Console.Write("Please enter the second positive integer: ");
        string b = Console.ReadLine();
        Console.WriteLine("The sum is ");

        if (a.Length > b.Length)
        {
            LongSum(a, b, a.Length, b.Length);
        }
        else
        {
            LongSum(b, a, b.Length, a.Length);
        }
    }

    static void LongSum(string a, string b, int Llen, int Slen)
    {
        if (Llen == Slen)
        {
            int[] temp = new int[Llen + 1];
            for (int i = Llen - 1; i >= 0; i--)
            {
                temp[i + 1] = temp[i + 1] + (a[i] - '0' + b[i] - '0') % 10;
                temp[i] = (a[i] - '0' + b[i] - '0') / 10;
            }
            if (temp[0] != 0)
            {
                for (int k = 0; k <= Llen; k++)
                {
                    Console.Write(temp[k]);
                }
            }
            else
            {
                for (int k = 1; k <= Llen; k++)
                {
                    Console.Write(temp[k]);
                }
            }

        }
        else
        {
            int[] temp = new int[Llen];
            int Ldiff = Llen - Slen;
            for (int i = Slen - 1; i >= 0; i--)
            {
                temp[i + Ldiff] = temp[i + Ldiff] + (a[i + Ldiff] - '0' + b[i] - '0') % 10;
                temp[i + Ldiff - 1] = (a[i + Ldiff] - '0' + b[i] - '0') / 10;
            }
            for (int j = Ldiff - 1; j >= 0; j--)
            {
                temp[j] += (a[j] - '0');
            }

            for (int k = 0; k < Llen; k++)
            {
                Console.Write(temp[k]);
            }
        }
    }
}
