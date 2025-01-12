class Q10
{
    static void ans()
    {
        int N = 5;
        int M = 16;
        Queue<int> shortPath = new Queue<int>();

        shortPath.Enqueue(M);

        // loop from N/2 then N-2 then N-1 and enqueue the queue
        // finally print the out the path in reverse order
        while(M / 2 >= N)
        {
            shortPath.Enqueue(M / 2);
            M = M / 2;
        }
        while(M - 2 >= N)
        {
            shortPath.Enqueue(M - 2);
            M = M - 2;
        }
        while(M - 1 >= N)
        {
            shortPath.Enqueue(M - 1);
            M = M - 1;
        }

        Console.WriteLine("The shortest path from {0} to {1} is", N, M);
        for(int i = shortPath.Count - 1; i >= 0; i--)
        {
            if(i == 0)
            {
                Console.Write(shortPath.ElementAt(i));
            }
            else
            {
                Console.Write(shortPath.ElementAt(i) + " -> ");
            }
        }
    }
}