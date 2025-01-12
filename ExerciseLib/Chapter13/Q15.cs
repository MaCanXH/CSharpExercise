
class Ch13Q15
{
	static void ans()
    {
        string s = ".NET – platform for applications from Microsoft \n CLR – managed execution environment for .NET \n namespace – hierarchical organization of classes";
        string[] temp = s.Split("\n");
        string[] dict = s.Split("–");
        
        Console.WriteLine("Enter a word: ");
        string n = Console.ReadLine();
        
        for (int i = 0; i < dict.Length; i++)
        {
            if (dict[i].IndexOf(n) != -1)
            {
                Console.WriteLine("The explanation: " + dict[i +1]);
            }
            else
            {
                Console.WriteLine("not found!");
            }
        }
    }
}
