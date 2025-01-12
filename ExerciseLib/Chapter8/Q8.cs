class Q8
{
    static void ans()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hex = Console.ReadLine();

        Console.WriteLine("The binary number: " + Convert.ToString(Convert.ToInt32(hex, 16), 2));
    }
}
