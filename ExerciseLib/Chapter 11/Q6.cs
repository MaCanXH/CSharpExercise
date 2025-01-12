class Ch11Q6
{
	static void ans()
	{
		Console.WriteLine("Enter the number of choice: ");
		Console.WriteLine("1. three sides");
		Console.WriteLine("2. side and the altitude to it");
		Console.WriteLine("3. two sides and the angle between them in degrees");
		int choice = int.Parse(Console.ReadLine());
	
		if (choice == 1)
		{
			Console.Write("Enter the length of first side: ");
			double a = double.Parse(Console.ReadLine());
			Console.Write("Enter the length of second side: ");
			double b = double.Parse(Console.ReadLine());
			Console.Write("Enter the length of third side: ");
			double c = double.Parse(Console.ReadLine());
	
			double p = (a + b + c) / 2.0;
			Console.Write("The area is " + (Math.Sqrt(p * (p - a) * (p - b) * (p - c))));
		}
		else if (choice == 2)
		{
			Console.Write("Enter the side: ");
			double a = double.Parse(Console.ReadLine());
			Console.Write("Enter the altitude: ");
			double b = double.Parse(Console.ReadLine());

			Console.WriteLine("The area is " + ((a * b) / 2.0));
		}
		else if (choice == 3)
		{
			Console.Write("Enter the first side: ");
			double a = double.Parse(Console.ReadLine());
			Console.Write("Enter the second side: ");
			double b = double.Parse(Console.ReadLine());
			Console.Write("Enter the angle: ");
			double c = double.Parse(Console.ReadLine());

			Console.WriteLine("The area is " + (a * b * Math.Sin(Math.PI * c / 180) / 2.0));
		}
		else
		{
			Console.WriteLine("incorrect input!!");
		}
	}
}
