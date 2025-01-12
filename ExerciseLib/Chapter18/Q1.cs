class Q1
{
    // Q1. Write a program that counts, in a given array of integers, 
    // the number of occurrences of each integer.
    static void ans()
    {
        int[] array = {3, 4, 4, 2, 3, 3, 4, 3, 2};
        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach(int i in array)
        {
            counts[i] = 0;
        }

        foreach(int i in array)
        {
            int count = counts[i];
            counts[i] = count + 1;
        }

        foreach(var k in counts)
        {
            Console.WriteLine("{0} -> {1} times", k.Key, k.Value);
        }
    }
}