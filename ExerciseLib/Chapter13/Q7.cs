class Ch13Q7
{
	static void ans()
    {
        string n = null;
        do
            {
            Console.Write("Enter a string (max 20 char): ");
            n = Console.ReadLine();
            }
        while (n.Length > 20);

        for (int i = 0; i < 20; i++)
        {
            if (i < n.Length)
            {
                Console.Write(n[i]);
            }
            else
            {
                Console.Write("*");
            }
        }
    }
}