class Ch13Q17
{
	static void ans()
    {
        Console.Write("Enter the first date: ");
        string FirstDate = Console.ReadLine();
        Console.Write("Enter the second date: ");
        string SecondDate = Console.ReadLine();

        DateTime f = ConvertDate(FirstDate);
        DateTime s = ConvertDate(SecondDate);

        Console.WriteLine("Distance: {0} days", s - f);
    }
    static DateTime ConvertDate(string d)
    {
        string[] date = d.Split('.');
        DateTime result = Convert.ToDateTime(date[2] + "/" + date[1] + "/" + date[0]);
        return result;
    }
}
