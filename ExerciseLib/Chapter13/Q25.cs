class Ch13Q25
{
	static void ans()
    {
        Console.WriteLine("Enter the list of word to be sorted separated by commas: ");
        string s = Console.ReadLine();
        string[] arr = s.Split(",");
        
        Array.Sort(arr);

        foreach (string i in arr)
        {
            Console.Write(i + " ");
        }
    }
}
