class Q15
{
    static void ans()
    {
        char[] alpha = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        Console.Write("enter a word: ");
        string x = Console.ReadLine();

        for (int i = 0; i < x.Length; i++)
        {
            for (int j = 0; j < alpha.Length; j++)
            {
                if (alpha[j] == x[i])
                {
                    Console.Write("{0,4}", j);
                }
            }
        }

    }
}

//or change the input to char[] array

/*char[] alpha = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

Console.Write("enter a word: ");
char[] x = (Console.ReadLine()).ToCharArray();

for (int i = 0; i < x.Length; i++)
{
    for (int j = 0; j < alpha.Length; j++)
    {
        if (alpha[j] == x[i])
        {
            Console.Write("{0,4}", j);
        }
    }
}
*/

