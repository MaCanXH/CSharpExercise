class Ch13Q22
{
    static int[] LetterCounter = new int[200];
	static void ans()
    {
        Console.WriteLine("Enter the text message: ");
        string txt = Console.ReadLine();
        LetterCount(txt);
        
        Console.WriteLine("The occurrence of letter as shown below: ");
        CountPrint();
    }
static void LetterCount(string t)
    {
        for (int i = 65; i <= 122; i++)
        {
            for (int j = 0; j < t.Length - 1; j++)
            {
                if((int)t[j] == i)
                {
                    LetterCounter[i] += 1;
                }
            }
        }
    }
    static void CountPrint()
    {
        for (int i = 65; i <= 90; i++)
        {
            Console.WriteLine("Letter {0}: {1,5} times        Letter {2}: {3,5} times", (char)i, LetterCounter[i], (char)(i + 32), LetterCounter[i + 32]);
        }
    }
}
