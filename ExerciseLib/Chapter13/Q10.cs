class Ch13Q10
{
	static void ans()
    {
        string s = " We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string[] arr = s.Split(".");
        
        Console.Write("Enter the search word: ");
        string SWord = " " + Console.ReadLine() + " ";

        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i].IndexOf(SWord) != -1)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
