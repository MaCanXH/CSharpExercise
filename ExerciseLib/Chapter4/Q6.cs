class Q6
{
    static void ans6()
    {
        Console.Write("Please enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second numner: ");
        int b = int.Parse(Console.ReadLine());

        int c = Math.Max(a, b);

        Console.WriteLine("The greater number is " + c);
    }
}