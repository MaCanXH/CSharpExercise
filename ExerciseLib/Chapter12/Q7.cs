class Ch12Q7
{
	static void ans()
    {
        int n = -1;
        bool valid = true;
        try
        {
            Console.Write("Enter a positive integer: ");
            n = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
            valid = false;
        }
        finally
        {
            if (n < 0 && valid == true)
            {
                Console.WriteLine("Invalid number!");
            }
            else if ( n >= 0)
            {
                        Console.WriteLine("The square root of {0} is {1}.", n, Math.Sqrt(n));
            }
                Console.WriteLine("Goodbye!");
        }
    }
}
