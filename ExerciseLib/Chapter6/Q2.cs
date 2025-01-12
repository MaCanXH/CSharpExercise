class Q2
{
    static void ans()
    {
        bool notdiv = true;

        Console.Write("please enter a number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            notdiv = true;
            if ((i % 3 == 0) && (i % 7 == 0))
            {
                notdiv = false;
            }
            if (notdiv)
            {
                Console.WriteLine(i);
            }
        }
    }
}