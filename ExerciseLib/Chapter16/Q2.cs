class Q2
{
    static void ans()
    {
        Stack<int> stack = new Stack<int>();
        int size = 0;

        Console.Write("Enter an integer: ");
        string n = Console.ReadLine();
        while(n != "")
        {
            size++;
            stack.Push(int.Parse(n));
            Console.Write("Enter an integer: ");
            n = Console.ReadLine();
        }
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}