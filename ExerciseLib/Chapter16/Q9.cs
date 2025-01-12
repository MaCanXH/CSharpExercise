class Q9
{
    static void ans()
    {
        Console.Write("Enter the N: ");
        int n = int.Parse(Console.ReadLine());
        Sequence(n);

    }

    static void Sequence(int n)
    {
        Queue<int> seq = new Queue<int>();
        seq.Enqueue(n);
        int counter = 0;
        while (counter <= 50)
        {
            seq.Enqueue(n + 1);
            seq.Enqueue(2 * n + 1);
            seq.Enqueue(n + 2);
            n = seq.Dequeue();
            Console.Write(n + " ");
            counter++;
        }
    }
}