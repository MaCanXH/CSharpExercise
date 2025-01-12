class Ch11Q1
{
	static void ans()
	{
		Console.Write("Please enter a year: ");
		int year = int.Parse(Console.ReadLine());
	
		if( DateTime.IsLeapYear(year))
		{
			Console.WriteLine("It is a leap year.");
		}
		else
		{
			Console.WriteLine("It is not a leap year.");
		}
	}
}
