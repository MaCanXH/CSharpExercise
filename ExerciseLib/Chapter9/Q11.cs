class Ch9Q11
{
    static void ans()
    {
        Console.WriteLine("#1 Put the digits from an integer number into a reversed order.");
        Console.WriteLine("#2 Calculate the average of given sequence of numbers.");
        Console.WriteLine("#3 Solve the linear equation a * x + b = 0.");
        int n = 0;
        do
        {
            Console.Write("Enter the number of the task to perform: ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0 || n > 3);
        Console.WriteLine();
        if (n == 1) Task1();
        else if (n == 2) Task2();
        else if (n == 3) Task3();
    }

    static void Task1()
    {
        int check = 0;
        string x = null;
        do
        {
            Console.Write("Enter a positive integer number in range [1…50,000,000]: ");
            x = Console.ReadLine();
            check = int.Parse(x);
        } while (check <= 0 || check > 50000000);
        int len = x.Length;
        Console.Write("The reversed integer is ");
        for (int i = len - 1; i >= 0; i--)
        {
            Console.Write(x[i]);
        }
    }

    static void Task2()
    {
        int n = 0;
        do
        {
            Console.Write("How many numbers in the sequence? ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0);
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number {0}: ", i);
            int k = int.Parse(Console.ReadLine());
            sum += k;
        }
        Console.WriteLine("The average of the sequence is {0}.", sum / n);
    }

    static void Task3()
    {
        int a = 0;
        do
        {
            Console.Write("Enter coefficient a: ");
            a = int.Parse(Console.ReadLine());
        } while (a == 0);

        Console.Write("Enter coefficient b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("x is {0}", -b / (double)a);
    }
}
