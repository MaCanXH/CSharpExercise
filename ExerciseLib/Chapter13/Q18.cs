using System.Globalization;

class Ch13Q18
{
	static void ans()
    {
        Console.Write("Enter the date and time in format (\"day.month.year hour:minutes:seconds\"): ");
        string dateT = Console.ReadLine();

        string format = "dd.MM.yyyy HH:mm:ss";
        CultureInfo provider = CultureInfo.InvariantCulture;

        DateTime f = DateTime.ParseExact(dateT,format,provider);
        double b = 6.5;
        Console.WriteLine("The time after 6hrs and 30mins is");
        Console.WriteLine(f.AddHours(b));
    }
}
