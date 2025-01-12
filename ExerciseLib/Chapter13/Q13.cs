class Ch13Q13
{
	static void ans()
    {
        Console.Write("Enter the url: ");
        string url = Console.ReadLine();
        char[] sepa = new char[] {':', '/'}; 
        string[] arr = url.Split(sepa, StringSplitOptions.RemoveEmptyEntries);

    Console.WriteLine("[protocol] = " + arr[0]);
    Console.WriteLine("[server] = " + arr[1]);
    Console.WriteLine("[resource] = /" + arr[2]);
    }
}
