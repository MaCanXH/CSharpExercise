class Q8
{
    static void ans8()
    {
        int a;
        int b;
        int c;
        int d;
        int e;
        int greatest;
        bool x;

        do
        {
            Console.Write("Please enter the first integer: ");
            x = int.TryParse(Console.ReadLine(), out a);
            //Console.WriteLine(x);
        }
        while (x == false);

        do
        {
            Console.Write("Please enter the second integer: ");
            x = int.TryParse(Console.ReadLine(), out b);
            //Console.WriteLine(x);
        }
        while (x == false);

        do
        {
            Console.Write("Please enter the third integer: ");
            x = int.TryParse(Console.ReadLine(), out c);
            // Console.WriteLine(x);
        }
        while (x == false);

        do
        {
            Console.Write("Please enter the fourth integer: ");
            x = int.TryParse(Console.ReadLine(), out d);
            //Console.WriteLine(x);
        }
        while (x == false);

        do
        {
            Console.Write("Please enter the fifth integer: ");
            x = int.TryParse(Console.ReadLine(), out e);
            //Console.WriteLine(x);
        }
        while (x == false);

        greatest = a;
        if (greatest < b) { greatest = b; }
        if (greatest < c) { greatest = c; }
        if (greatest < d) { greatest = d; }
        if (greatest < e) { greatest = e; }

        Console.WriteLine("the greatest is " + greatest);
    }
}