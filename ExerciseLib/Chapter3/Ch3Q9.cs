namespace Ch3Q9;

class Q9
{
    public static void Answer()
    {
        float x = 4.5f;
        float y = 2.3f;

        if (Math.Sqrt(x * x + y * y) < 5)
        {
            Console.WriteLine("within the circle");
        }
        else
        {
            Console.WriteLine("not within the circle");
        }
    }
}