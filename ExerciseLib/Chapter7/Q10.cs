class Q10
{
    static void ans()
    {
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int tempFreq = 1;
        int freq = 1;
        int num = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    tempFreq++;
                }
            }
            if (tempFreq > freq)
            {
                num = arr[i];
                freq = tempFreq;
            }
            tempFreq = 1;
        }
        Console.WriteLine("the most frequently occurring number is " + num + " and " + freq + " times.");

    }
}