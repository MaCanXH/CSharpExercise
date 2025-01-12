class Q8
{
    static void ans()
    {
        int[] arr = { 64, 25, 12, 22, 11 };
        int temp = arr[0];

        //compare arr[i] with the following value in the set
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                //perform sawpping of value
                if (arr[j] < arr[i])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        Console.WriteLine("The sorted array is");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}