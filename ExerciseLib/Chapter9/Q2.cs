class Ch9Q2
{
    static void ans()
    {
        Console.Write("Enter the first integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the third integer: ");
        int c = int.Parse(Console.ReadLine());

        int mx = GetMax(GetMax(a, b), c);

        Console.WriteLine("The maximal integer is " + mx);
    }

    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
