using CreatingAndUsingObjects;

class Ch11Q8
{
	static void ans()
	{
		for (int i = 1; i <= 10; i++)
		{
			Cat tempcat = new Cat();
			tempcat.Name = "Cat" + i;
			tempcat.SayMiau();
		}
	}
}
