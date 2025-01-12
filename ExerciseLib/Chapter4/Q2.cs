class Q2
{
    static void ans2()
    {
        Console.Write("Please enter the radius: ");
        int r = int.Parse(Console.ReadLine());

        Console.WriteLine("The area = {0:f2}", Math.PI * r * r);
        Console.WriteLine("The perimeter = {0:f2}", 2 * r * Math.PI);
    }
}