class Q2
    //or count the negative numbers, even = "-", odd = "+"
    //shoule also consider the case with 0
    //e.g. if a < 0, counter++; if b < 0 counter++; if c < 0 counter++
{
    static void ans2()
    {
        float a = 21.32f;
        float b = 17.63f;
        float c = 12.7f;

        Console.WriteLine("a = {0} b = {1} c = {2}", a, b, c);
        if (a < 0 && b > 0 && c > 0)
        {
            Console.WriteLine("the product sign is \"-\".");
        }
        else if (a > 0 && b < 0 && c > 0)
        {
            Console.WriteLine("the product sign is \"-\".");
        }
        else if (a > 0 && b > 0 && c < 0)
        {
            Console.WriteLine("the product sign is \"-\".");
        }
        else if (a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine("the product sign is \"-\".");
        }
        else
        {
            Console.WriteLine("the product sign is \"+\".");
        }
    }
}