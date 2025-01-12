class Q1
{
    static void ans()
    {
        //for loop is also applicable
        int i = 1;

        Console.Write("please enter a number: ");
        int n = int.Parse(Console.ReadLine());

        while (i <= n)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}