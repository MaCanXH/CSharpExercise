class Ch11Q2
{
		static void ans()
	{
		Console.WriteLine("The 10 random numbers in the range [100, 200] is");
		Random rand = new Random();
		for (int i = 0 ; i < 10; i++)
		{
			int num = rand.Next(100, 201);
			Console.Write("{0, 4}", num);
		}
	}
}
