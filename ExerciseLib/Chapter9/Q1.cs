class Ch9Q1
{
    static void ans()
    {
        Console.Write("Please enter your name: ");
        string n = Console.ReadLine();

        Hello(n);
    }

    static void Hello(string n)
    {
        Console.WriteLine("Hello, " + n + "!");
    }
}
