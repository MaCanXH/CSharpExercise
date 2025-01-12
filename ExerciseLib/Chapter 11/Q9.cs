class Ch11Q9
{
	static void Main()
{
	DateTime[] holidays = new DateTime[]
            {
                new DateTime(2024, 12, 24),
                new DateTime(2024, 12, 25),
                new DateTime(2025, 01, 01),
                new DateTime(2025, 01, 02),
                new DateTime(2025, 03, 02),
                new DateTime(2025, 03, 03),
                new DateTime(2025, 04, 10),
                new DateTime(2025, 04, 13),
                new DateTime(2025, 05, 01),
                new DateTime(2025, 05, 06),
                new DateTime(2025, 09, 19),
                new DateTime(2025, 09, 20),
                new DateTime(2025, 12, 24),
                new DateTime(2025, 12, 25),
            };
	DateTime[] worksSaturdays = new DateTime[]
            {
                new DateTime(2025, 01, 24),
                new DateTime(2025, 03, 21),
                new DateTime(2025, 09, 12),
                new DateTime(2025, 12, 12),
            };

	int workdays = 0;

Console.Write("Enter the date (YYYY/MM/DD): ");
DateTime endDate = System.Convert.ToDateTime(Console.ReadLine());
DateTime now = DateTime.Now;

do
{
	now = now.AddDays(1);
	
	if (now.DayOfWeek >= DayOfWeek.Monday && now.DayOfWeek <= DayOfWeek.Friday)
{
	workdays++;
}

foreach (var i in holidays)
{
	if (i.Date == now.Date)
{
	workdays--;
}
}
foreach (var i in worksSaturdays)
{
	if (i.Date == now.Date)
{
	workdays++;
}
}
}
while (now.Date != endDate.Date);

Console.WriteLine("The total workdays from now to {0} are {1}", endDate, workdays);
}
}
