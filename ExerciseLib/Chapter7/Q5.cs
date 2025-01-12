class Q5
{
    static void ans()
    {
        int[] array = { 1, 1, 2, 3, 4, 2, 3, 4, 5, 6, 4 };
        int start = 0;
        int len = 1;
        int bestLen = 1;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] + 1 == (array[i + 1]))
            {
                len++;
                if (len > bestLen)
                {
                    bestLen = len;
                    start = i + 1 - bestLen + 1;
                }
            }
            else { len = 1; }
        }

        Console.WriteLine("the maximal sequence is ");
        for (int i = start; i < (start + bestLen); i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}