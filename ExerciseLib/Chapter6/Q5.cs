class Q5
{
    static void ans()
    {
        Console.Write("enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int counter = 1;
        int sum;
        int num1 = 0;
        int num2 = 1;

        Console.Write("0, 1, ");
        while (counter <= (n - 2))
        {
            sum = num1 + num2;
            num1 = num2;
            num2 = sum;
            Console.Write(sum + ", ");
            counter++;
        }
    }
}