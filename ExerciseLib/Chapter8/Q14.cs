class Ch8Q14
{
    static void Main()
    {
        float f = 0.000001f;
        double d = 0.000001d;
        decimal dec = 0.000001m;

        Console.Write("Enter the type of data (float = 1, double = 2, decimal = 3): ");
        string typ = Console.ReadLine();

        if (typ == "1")
        {
            Console.WriteLine("The sum is " + Calcu(f));
        }
        if (typ == "2")
        {
            Console.WriteLine("The sum is " + Calcu(d));
        }
        if (typ == "3")
        {
            Console.WriteLine("The sum is " + Calcu(dec));
        }
    }
    static float Calcu(float k)
    {
        float sum = 0;
        for (int i = 0; i < 50000000; i++)
        {
            sum += k;
        }
        return sum;
    }
    static double Calcu(double k)
    {
        double sum = 0;
        for (int i = 0; i < 50000000; i++)
        {
            sum += k;
        }
        return sum;
    }
    static decimal Calcu(decimal k)
    {
        decimal sum = 0;
        for (int i = 0; i < 50000000; i++)
        {
            sum += k;
        }
        return sum;
    }
}
