class Q9
{
    static void ans9()
    {
        int sum = 0;

        Console.Write("enter the number n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter the number " + i + " : ");
            int add = int.Parse(Console.ReadLine());
            sum = sum + add;
        }

        Console.WriteLine("The sum is " + sum);
    }
}