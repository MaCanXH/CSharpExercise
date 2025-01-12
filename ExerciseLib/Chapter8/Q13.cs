class Ch8Q13
{
    static void ans()
    {
        Console.Write("Enter the number N: ");
        string n = Console.ReadLine();

        int s, d = 0;

        do
        {
            Console.Write("Enter S base: ");
            s = int.Parse(Console.ReadLine());
        }
        while (s != 2 && s != 8 && s != 10 && s != 16);

        do
        {
            Console.Write("Enter D base: ");
            d = int.Parse(Console.ReadLine());
        }
        while (d != 2 && d != 8 && d != 10 && d != 16);

        n = Convert.ToString(Convert.ToInt32(n, s), d);

        Console.WriteLine("The converted number is " + n);
    }
}
