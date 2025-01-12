class Q1
{
    static void ans()
    {
        List<int> list = new List<int>();
        string n;
        // here, int len is declared to store the size of the list 
        // instead of using list.Capacity
        // because list.Capacity is actually the size of the array
        // but the list actual size
        // if we use it for the iteration below, out of range condition may occur at some point
        int len = 0; 
        Console.Write("Enter an integer: ");
        n = Console.ReadLine();
        while(n != "")
        {
            list.Add(int.Parse(n));
            len++;
            Console.Write("Enter an integer: ");
            n = Console.ReadLine();
        }
        int sum = 0;
        for (int i = 0; i < len; i++)
        {
            sum += list[i];
        }
        Console.WriteLine("The sum is " + sum);
        Console.WriteLine("The average is " + (double)sum / list.Capacity);
    }
}