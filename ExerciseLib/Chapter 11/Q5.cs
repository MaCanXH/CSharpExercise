class Ch11Q5
{
	static void ans()
	{
		Console.Write("Enter one side of the right triangle: ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("Enter another side of the right triangle: ");
		int b = int.Parse(Console.ReadLine());
		Console.Write("The hypotenuse of the right triangle is " + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
	}
}
