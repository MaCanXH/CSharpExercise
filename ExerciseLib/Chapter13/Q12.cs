class Ch13Q12
{
	static void ans()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0,15}", n);
        Console.WriteLine("{0,15:F}", n);
        Console.WriteLine("{0,15:X}", n);
        Console.WriteLine("{0,15:P}", n);
        Console.WriteLine("{0,15:E}", n);
    }
}
