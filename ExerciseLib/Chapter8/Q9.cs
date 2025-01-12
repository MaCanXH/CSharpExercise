class Q9
{
    static void ans()
    {
        Console.Write("Enter a binary number: ");
        string bin = Console.ReadLine();

        Console.WriteLine("The hexadecimal number: " + Convert.ToString(Convert.ToInt32(bin, 2), 16));
    }
}
