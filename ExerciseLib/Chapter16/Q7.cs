class Q7
{
    static void ans()
    {
        int[] occurance = new int[1001];
        int[] arr = {3, 4, 4, 2, 3, 3, 4, 3, 2};

        for(int i = 0; i < arr.Length; i++)
        {
            int idx = arr[i];
            occurance[idx]++;
        }

        for(int i = 0; i < occurance.Length; i++)
        {
            if(occurance[i] != 0)
            {
                Console.WriteLine("{0} -> {1} times", i, occurance[i]);
            }
        }
    }
}