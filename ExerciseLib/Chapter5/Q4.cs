class Q4
{
    static void ans4()
    {
        double a = 12.45;
        double b = -8.2;
        double c = -20.1;
        double smallest;
        double mid;
        double biggest;

        if (a > b && a > c)
        {
            biggest = a;
            if (b > c)
            {
                mid = b;
                smallest = c;
            }
            else
            {
                mid = c;
                smallest = b;
            }
        }
        else if (b > c)
        {
            biggest = b;
            if (a > c)
            {
                mid = a;
                smallest = c;
            }
            else
            {
                mid = c;
                smallest = a;
            }
        }
        else
        {
            biggest = c;
            if (b > a)
            {
                mid = b;
                smallest = a;
            }
            else
            {
                mid = a;
                smallest = b;
            }
        }

        Console.WriteLine("number in descending order: ");
        Console.WriteLine(biggest + " " + mid + " " + smallest);
    }
}