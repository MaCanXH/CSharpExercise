class Q5
{
    static void ans5()
    {
        Console.Write("Please enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        int b = int.Parse(Console.ReadLine());


        //to check which number is smaller
        if (a < b)
        {

        }
        else
        {
            int c = a;
            a = b;
            b = c;
        }

        //to find out the divisible by for-loop.
        Console.WriteLine("Number divisible by 5 between " + a + " and " + b + " are:");
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i + ", ");
            }
        }
    }
}